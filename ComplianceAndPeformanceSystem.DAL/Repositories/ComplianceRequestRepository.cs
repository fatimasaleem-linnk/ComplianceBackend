using ComplianceAndPeformanceSystem.Contract.Common.Exceptions;
using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Dtos.Compliance;
using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.Helper;
using ComplianceAndPeformanceSystem.Contract.IRepositories;
using ComplianceAndPeformanceSystem.Contract.IServices;
using ComplianceAndPeformanceSystem.Contract.Models;
using ComplianceAndPeformanceSystem.Core.Entities;
using ComplianceAndPeformanceSystem.Core.Entities.ComplainceVisit;
using ComplianceAndPeformanceSystem.Core.Entities.ComplainceVisit.ComplainceReport;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Security.Cryptography.Xml;

namespace ComplianceAndPeformanceSystem.DAL.Repositories;

internal class ComplianceRequestRepository(
    IComplianceAndPeformanceDbContext dbContext,
    ICurrentUserService currentUserService,
    ICurrentLanguageService currentLanguageService,
    IUserRepository userRepository,
    Func<NotificationTypeEnum, INotificationService> notificationService
    ) : IComplianceRequestRepository
{
    public async Task<ComplianceRequest> GetLatestComplianceRequest()
    {
        return await dbContext.ComplianceRequest
            .Include(s => s.ComplianceSpecialists)
            .Include(s => s.ComplianceDetails)
            .ThenInclude(s => s.ComplianceVisitSpecialists)
            .Include(s => s.Status)
            .OrderByDescending(s => s.CreatedOn)
            .FirstOrDefaultAsync();
    }

    public async Task<List<AttachmentDto>> GetVisitAttachments(List<Guid> visitIds)
    {
        return await dbContext.Attachments
            .Where(s => s.EntityName == AttachmentEntityEnum.VisitAttachment
                     && visitIds.Contains(s.EntityId)
                     && s.AttachmentTypeId == (long)AttachmentTypeEnum.VisitAttachment)

            .Select(a => new AttachmentDto
            {
                AttachmentId = a.Id,
                EntityId = a.EntityId,
                AttachmentGuid = a.AttachmentGuid,
                AttachmentName = a.AttachmentName,
                EntityName = a.EntityName,
                AttachmentType = (AttachmentTypeEnum)a.AttachmentTypeId,
            })
            .ToListAsync();
    }
    public async Task<List<LookupValue>> GetLookupValues()
    {
        return await dbContext.LookupValue.ToListAsync();
    }

    #region Phase 1
    public async Task<ResponseResult<List<ComplianceNotificationMessageDto>>> GetComplianceNotifications(List<string> rolesName)
    {
        var notifications =  dbContext.ComplianceNotificationMassage.AsQueryable();
        if(rolesName != null)
            notifications = notifications.Where(s => rolesName.Contains(s.Role));

        return ResponseResult<List<ComplianceNotificationMessageDto>>.Success(await notifications.Select(s => new ComplianceNotificationMessageDto()
        {
            Id = s.Id,
            ActionUrl = s.ActionUrl,
            MessageBody = currentLanguageService.Language == LanguageEnum.En ? s.MessageBodyEn : s.MessageBodyAR,
            MessageTitle = currentLanguageService.Language == LanguageEnum.En ? s.MessageTitleEn : s.MessageTitleAR,
            MessageType = s.MessageType
        }).ToListAsync());
    }
    public async Task CreateComplianceRequest()
    {

        var record = await dbContext.ComplianceRequest.Where(s => s.IsDeleted != true)
               .OrderByDescending(s => s.CreatedOn).FirstOrDefaultAsync();

        if (record == null)
        {
            ComplianceRequest complianceRequest = new ComplianceRequest()
            {
                Id = Guid.NewGuid(),
                AssignTaskNameAr = $"إعداد وإنشاء خطة الإمتثال السنوي لعام {DateTime.Now.Year}م",
                AssignTaskNameEn = $"Preparing and establishing the annual compliance plan for the year {DateTime.Now.Year}",
                RemainingDays = 3,
                PassedDays = 0,
                StatusId = (int)ComplianceStatusEnum.New
            };

            await dbContext.ComplianceRequest.AddAsync(complianceRequest);
        }

    }
    public async Task UpdateRemainingDays()
    {
        userRepository = new UserRepository();
        var users = (await userRepository.GetUsers(new List<string>())).Model;

        var record = await dbContext.ComplianceRequest
               .Include(s => s.ComplianceSpecialists)
               .Include(s => s.ComplianceApprovals)
               .OrderByDescending(s => s.CreatedOn).FirstOrDefaultAsync();

        if (record != null && DateTime.Now.Date.Subtract(record.CreatedOn.Date).Days > 365) return;
        if (record != null)
        {
            var templates = (await dbContext.Templates.Where(s => s.TemplateTypeId == (long)TemplateTypeEnum.Email).Select(s => new TemplateDto()
            {
                TemplateTypeId = s.TemplateTypeId,
                Content = s.Content,
                Id = s.Id,
                Role = s.Role,
                Subject = s.Subject,
                TemplateTypeName = currentLanguageService.Language == LanguageEnum.Ar ? s.TemplateType.ValueAr : s.TemplateType.ValueEn
            }).ToListAsync());
            if (record.StatusId == (int)ComplianceStatusEnum.New)
            {
                record.RemainingDays = record.AssignedOn.Value.Date.AddDays(60).Subtract(DateTime.Now.Date).Days;
                record.PassedDays = DateTime.Now.Date.Subtract(record.AssignedOn.Value.Date).Days;

                if (record.ComplianceSpecialists != null && record.ComplianceSpecialists.Any())
                {

                    if (record.RemainingDays <= 0)
                    {
                        var complianceManagers = users.Where(s => s.Roles.Contains(RoleEnum.ComplianceManager));
                        var template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.EscalationAnnualCompliancePlanSubmissionOverdueForComplianceManager);
                        if (template != null)
                        {

                            template.Content = template.Content.Replace("{{EmployeeName}}", "مدير عام الادارة");
                            template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                            {
                                Subject = template.Subject,
                                Body = template.Content,
                                To = complianceManagers.Select(s => s.Email).ToList(),
                                CC = record.ComplianceSpecialists.Select(s => s.SpecialistUserEmail).ToList(),
                            });
                        }

                        var performanceMonitoringManagers = users.Where(s => s.Roles.Contains(RoleEnum.PerformanceMonitoringManager));
                        template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.EscalationAnnualCompliancePlanSubmissionOverdueForPeformanceMentoringManager);
                        if (template != null)
                        {

                            template.Content = template.Content.Replace("{{EmployeeName}}", "مدير مراقبة الأداء");
                            template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                            {
                                Subject = template.Subject,
                                Body = template.Content,
                                To = performanceMonitoringManagers.Select(s => s.Email).ToList(),
                                CC = record.ComplianceSpecialists.Select(s => s.SpecialistUserEmail).ToList(),
                            });
                        }

                    }
                    else if (record.RemainingDays == 3)
                    {
                        var template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.FinalReminderTheAnnualCompliancePlanDeadlineForSpecialist);
                        if (template != null)
                        {

                            template.Content = template.Content.Replace("{{EmployeeName}}", "اخصائي الالتزام");
                            template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");
                            template.Content = template.Content.Replace("{{RemaningDays}}", record.RemainingDays.ToString());

                            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                            {
                                Subject = template.Subject,
                                Body = template.Content,
                                To = record.ComplianceSpecialists.Select(s => s.SpecialistUserEmail).ToList(),
                            });
                        }
                    }
                    else if (record.RemainingDays == 5)
                    {
                        var template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.ReminderPrepareTheAnnualCompliancePlanForSpecialist);
                        if (template != null)
                        {

                            template.Content = template.Content.Replace("{{EmployeeName}}", "اخصائي الالتزام");
                            template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");
                            template.Content = template.Content.Replace("{{RemaningDays}}", record.RemainingDays.ToString());

                            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                            {
                                Subject = template.Subject + "(اشعار 5 أيام متبقية)",
                                Body = template.Content,
                                To = record.ComplianceSpecialists.Select(s => s.SpecialistUserEmail).ToList(),
                            });
                        }
                    }
                    else if (record.RemainingDays % 5 == 0)
                    {
                        var template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.ReminderPrepareTheAnnualCompliancePlanForSpecialist);
                        if (template != null)
                        {

                            template.Content = template.Content.Replace("{{EmployeeName}}", "اخصائي الالتزام");
                            template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");
                            template.Content = template.Content.Replace("{{RemaningDays}}", record.RemainingDays.ToString());

                            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                            {
                                Subject = template.Subject + "(اشعار دوري كل 5 أيام)",
                                Body = template.Content,
                                To = record.ComplianceSpecialists.Select(s => s.SpecialistUserEmail).ToList(),
                            });
                        }

                    }
                }
                if (record.RemainingDays < 0)
                {
                    record.StatusId = (int)ComplianceStatusEnum.ComplianceSpecialistPreparingDelayed;
                }
            }

            

            if (record.StatusId == (int)ComplianceStatusEnum.ComplianceSpecialistPreparingDelayed)
            {
                record.RemainingDays = record.AssignedOn.Value.Date.AddDays(60).Subtract(DateTime.Now.Date).Days;
                record.PassedDays = DateTime.Now.Date.Subtract(record.AssignedOn.Value.Date).Days;

            }


            if (record.StatusId == (int)ComplianceStatusEnum.ApprovalOfTheComplianceManager)
            {
                var approvalRecord = record.ComplianceApprovals.OrderByDescending(s => s.CreatedOn).FirstOrDefault(a => a.Role == RoleEnum.ComplianceManager);
                if (approvalRecord != null && approvalRecord.IsApproved == true)
                {
                    record.RemainingDays = approvalRecord.ModifiedOn.Date.AddDays(7).Subtract(DateTime.Now.Date).Days;
                    record.PassedDays = DateTime.Now.Date.Subtract(approvalRecord.ModifiedOn.Date).Days;

                }
            }

            if (record.StatusId == (int)ComplianceStatusEnum.ReturnPlanOfComplianceManager)
            {
                var approvalRecord = record.ComplianceApprovals.OrderByDescending(s => s.CreatedOn).FirstOrDefault(a => a.Role == RoleEnum.ComplianceManager);
                if (approvalRecord != null && approvalRecord.IsApproved == false)
                {
                    record.RemainingDays = approvalRecord.ModifiedOn.Date.AddDays(approvalRecord.DaysForFinish.Value).Subtract(DateTime.Now.Date).Days;
                    record.PassedDays = DateTime.Now.Date.Subtract(approvalRecord.ModifiedOn.Date).Days;
                }
            }

            if (record.StatusId == (int)ComplianceStatusEnum.ReturnPlanOfPerformanceMonitoringManager)
            {
                var approvalRecord = record.ComplianceApprovals.OrderByDescending(s => s.CreatedOn).FirstOrDefault(a => a.Role == RoleEnum.PerformanceMonitoringManager);
                if (approvalRecord != null && approvalRecord.IsApproved == false)
                {
                    record.RemainingDays = approvalRecord.ModifiedOn.Date.AddDays(approvalRecord.DaysForFinish.Value).Subtract(DateTime.Now.Date).Days;
                    record.PassedDays = DateTime.Now.Date.Subtract(approvalRecord.ModifiedOn.Date).Days;

                }
            }

            if (record.StatusId == (int)ComplianceStatusEnum.PendingReviewOfComplianceManager || record.StatusId == (int)ComplianceStatusEnum.ComplianceManagerOverdue)
            {
                var approvalRecord = record.ComplianceApprovals.OrderByDescending(s => s.CreatedOn).FirstOrDefault(a => a.Role == RoleEnum.ComplianceManager);
                if (approvalRecord != null && approvalRecord.IsApproved == null)
                {
                    record.RemainingDays = approvalRecord.CreatedOn.Date.AddDays(7).Subtract(DateTime.Now.Date).Days;
                    record.PassedDays = DateTime.Now.Date.Subtract(approvalRecord.CreatedOn.Date).Days;

                    if(record.RemainingDays == 5)
                    {
                        var template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.ReminderActionRequiredOnAnnualCompliancePlanForComplianceManager);
                        if (template != null)
                        {

                            template.Content = template.Content.Replace("{{EmployeeName}}", "مدير الادارة");
                            template.Content = template.Content.Replace("{{PlanTitle}}", record.AssignTaskNameAr);
                            template.Content = template.Content.Replace("{{RemainingDays}}", record.RemainingDays.ToString());
                            template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                            {
                                Subject = template.Subject,
                                Body = template.Content,
                                To = users.Where(s => s.Roles.Contains(RoleEnum.ComplianceManager)).Select(s => s.Email).ToList(),
                            });
                        }
                    }

                    if (record.RemainingDays <= 0)
                    {
                        var template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.EscalationPlanReviewPeriodExpiredForComplianceManager);
                        if (template != null)
                        {

                            template.Content = template.Content.Replace("{{EmployeeName}}", "مدير الادارة");
                            template.Content = template.Content.Replace("{{PlanTitle}}", record.AssignTaskNameAr);
                            template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                            {
                                Subject = template.Subject + "من قبل مدير الادارة",
                                Body = template.Content,
                                To = users.Where(s => s.Roles.Contains(RoleEnum.ComplianceManager)).Select(s => s.Email).ToList(),
                            });
                        }


                        template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.EscalationPlanReviewPeriodExpiredForPerformanceMonitoringManager);
                        if (template != null)
                        {

                            template.Content = template.Content.Replace("{{EmployeeName}}", "مدير عام مراقبة الاداء");
                            template.Content = template.Content.Replace("{{PlanTitle}}", record.AssignTaskNameAr);
                            template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                            {
                                Subject = template.Subject + "من قبل مدير الادارة",
                                Body = template.Content,
                                To = users.Where(s => s.Roles.Contains(RoleEnum.PerformanceMonitoringManager)).Select(s => s.Email).ToList(),
                            });
                        }
                    }

                    if (record.RemainingDays <= 0)
                    {
                        record.StatusId = (int)ComplianceStatusEnum.ComplianceManagerOverdue;
                    }
                }
            }


            if (record.StatusId == (int)ComplianceStatusEnum.PendingReviewOfPerformanceMonitoringManager || record.StatusId == (int)ComplianceStatusEnum.PeformanceMonitoringManagerOverdue)
            {
                var approvalRecord = record.ComplianceApprovals.OrderByDescending(s => s.CreatedOn).FirstOrDefault(a => a.Role == RoleEnum.PerformanceMonitoringManager);
                if (approvalRecord != null && approvalRecord.IsApproved == null)
                {
                    record.RemainingDays = approvalRecord.CreatedOn.Date.AddDays(7).Subtract(DateTime.Now.Date).Days;
                    record.PassedDays = DateTime.Now.Date.Subtract(approvalRecord.CreatedOn.Date).Days;

                    if (record.RemainingDays == 4)
                    {
                        var template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.ReminderActionRequiredOnApprovedPlanForPerformanceMonitoringManager);
                        if (template != null)
                        {

                            template.Content = template.Content.Replace("{{EmployeeName}}", "مدير عام مراقبة الاداء");
                            template.Content = template.Content.Replace("{{PlanTitle}}", record.AssignTaskNameAr);
                            template.Content = template.Content.Replace("{{RemainingDays}}", record.RemainingDays.ToString());
                            template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                            {
                                Subject = template.Subject + "(اشعار 4 أيام متبقية)",
                                Body = template.Content,
                                To = users.Where(s => s.Roles.Contains(RoleEnum.PerformanceMonitoringManager)).Select(s => s.Email).ToList(),
                            });
                        }
                    }


                    if (record.RemainingDays == 2)
                    {
                        var template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.ReminderActionRequiredOnApprovedPlanForPerformanceMonitoringManager);
                        if (template != null)
                        {

                            template.Content = template.Content.Replace("{{EmployeeName}}", "مدير عام مراقبة الاداء");
                            template.Content = template.Content.Replace("{{PlanTitle}}", record.AssignTaskNameAr);
                            template.Content = template.Content.Replace("{{RemainingDays}}", record.RemainingDays.ToString());
                            template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                            {
                                Subject = template.Subject + "(اشعار بيومين متبقية)",
                                Body = template.Content,
                                To = users.Where(s => s.Roles.Contains(RoleEnum.PerformanceMonitoringManager)).Select(s => s.Email).ToList(),
                            });
                        }
                    }

                    if (record.RemainingDays <= 0)
                    {
                        var template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.EscalationPlanReviewPeriodExpiredForComplianceManager);
                        if (template != null)
                        {

                            template.Content = template.Content.Replace("{{EmployeeName}}", "مدير الادارة");
                            template.Content = template.Content.Replace("{{PlanTitle}}", record.AssignTaskNameAr);
                            template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                            {
                                Subject = template.Subject + "من قبل مدير عام مراقبة الاداء",
                                Body = template.Content,
                                To = users.Where(s => s.Roles.Contains(RoleEnum.ComplianceManager)).Select(s => s.Email).ToList(),
                            });
                        }


                        template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.EscalationPlanReviewPeriodExpiredForPerformanceMonitoringManager);
                        if (template != null)
                        {

                            template.Content = template.Content.Replace("{{EmployeeName}}", "مدير عام مراقبة الاداء");
                            template.Content = template.Content.Replace("{{PlanTitle}}", record.AssignTaskNameAr);
                            template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                            {
                                Subject = template.Subject + "من قبل مدير  عام مراقبة الاداء",
                                Body = template.Content,
                                To = users.Where(s => s.Roles.Contains(RoleEnum.PerformanceMonitoringManager)).Select(s => s.Email).ToList(),
                            });
                        }
                    }

                    if (record.RemainingDays <= 0)
                    {
                        record.StatusId = (int)ComplianceStatusEnum.PeformanceMonitoringManagerOverdue;
                    }
                }
            }

            await dbContext.SaveChangesAsync();
        }
    }
  
 

    public async Task<ResponseResult<KeyValuePair<List<string>, List<string>>>> AssignComplianceSpecialist(AssignComplianceSpecialistModel model)
    {
        bool isUpdate = false;
        List<string> notifiedUser = new List<string>();
        List<string> removedUser = new List<string>();
        var complianceRequest = await dbContext.ComplianceRequest.Include(s => s.ComplianceSpecialists).FirstOrDefaultAsync(s => s.Id == model.RequestId);
        if (complianceRequest != null)
        {
            List<KeyValuePair<string, string>> detailsAr = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> detailsEn = new List<KeyValuePair<string, string>>();

            UserRepository userRepository = new UserRepository();
            var users = await userRepository.GetUsersByIds(model.AssignedUserId);
            if (complianceRequest.ComplianceSpecialists != null && complianceRequest.ComplianceSpecialists.Count() > 0)
            {

                var ids = complianceRequest.ComplianceSpecialists.Select(s => s.SpecialistUserId).ToList();
                notifiedUser = model.AssignedUserId.Except(ids).ToList();
                removedUser = ids.Except(model.AssignedUserId).ToList();

                dbContext.ComplianceSpecialist.RemoveRange(complianceRequest.ComplianceSpecialists);

                detailsAr.Add(new KeyValuePair<string, string>("Seq", $"تم تعديل قائمة الاخصائيين"));
                detailsEn.Add(new KeyValuePair<string, string>("Seq", $"Compliance Specialist has been changed"));
                isUpdate = true;
            }
            else
            {
                detailsAr.Add(new KeyValuePair<string, string>("Seq", $"تم تعيين قائمة الاخصائيين"));
                detailsEn.Add(new KeyValuePair<string, string>("Seq", $"Compliance Specialist has been Assigned"));

                notifiedUser = model.AssignedUserId;
                complianceRequest.RemainingDays = 60;
                complianceRequest.PassedDays = 0;
                complianceRequest.AssignedOn = DateTime.Now;
            }

            foreach (var item in model.AssignedUserId)
            {
                var user = users.Model.FirstOrDefault(s => s.Id == item);

                detailsAr.Add(new KeyValuePair<string, string>("ComplianceSpecialist", $"اسم الاخصائي: {user.UserName}"));
                detailsEn.Add(new KeyValuePair<string, string>("ComplianceSpecialist", $"Compliance Specialist Name: {user.UserName}"));

                detailsAr.Add(new KeyValuePair<string, string>("ComplianceSpecialist", $"البريد الالكتروني الاخصائي: {user.Email}"));
                detailsEn.Add(new KeyValuePair<string, string>("ComplianceSpecialist", $"Compliance Specialist Email: {user.Email}"));

                ComplianceSpecialist record = new ComplianceSpecialist()
                {
                    Id = Guid.NewGuid(),
                    SpecialistUserId = item,
                    ComplianceRequestId = model.RequestId,
                    SpecialistUserEmail = user.Email,
                    SpecialistUserName = user.UserName,

                };
                await dbContext.ComplianceSpecialist.AddAsync(record);
            }

            ComplianceRequestActivity requestActivity = new ComplianceRequestActivity()
            {
                Id = Guid.NewGuid(),
                ComplianceRequestId = model.RequestId,
                CreatedByUserId = currentUserService.User.UserId,
                CreatedByUserEmail = currentUserService.User.UserEmail,
                CreatedByUserName = currentUserService.User.UserName,
                CreatedOn = DateTime.Now,
                ActionAr = isUpdate == false ? "اضافة" : "تعديل",
                ActionEn = isUpdate == false ? "Add" : "Update",
                DetailsAr = JsonConvert.SerializeObject(detailsAr),
                DetailsEn = JsonConvert.SerializeObject(detailsEn),
            };
            await dbContext.ComplianceRequestActivity.AddAsync(requestActivity);
        }
        return ResponseResult<KeyValuePair<List<string>, List<string>>>.Success(new KeyValuePair<List<string>, List<string>>(notifiedUser, removedUser));

    }
    public async Task<ResponseResult<ComplianceRequestDto>?> GetComplianceRequest(ComplianceRequestFilterDto? filter, bool isEmail = false)
    {
        var record = await dbContext.ComplianceRequest
               .Include(s => s.ComplianceSpecialists)
               .Include(s => s.ComplianceDetails)
               .ThenInclude(s => s.ComplianceVisitSpecialists)
               .Include(s => s.Status)
               .OrderByDescending(s => s.CreatedOn).FirstOrDefaultAsync() ?? throw new NotFoundException("ComplianceRequest", "Not found");

        if (DateTime.Now.Subtract(record.CreatedOn).Days > 365) throw new NotFoundException("ComplianceRequest", "Yearly Compliance Request not found \r\n لم يتم العثور على طلب الامتثال السنوي");

        if (isEmail || (currentUserService != null && (record.ComplianceSpecialists.Any(s => s.SpecialistUserName == currentUserService.User.UserName)
        || currentUserService.User.Role.Contains(RoleEnum.PerformanceMonitoringManager) || currentUserService.User.Role.Contains(RoleEnum.ComplianceManager))))
        {

            var visitsIds = record.ComplianceDetails.Select(s => s.Id).ToList();
            var visitDocuments = await dbContext.Attachments.Where(s => s.EntityName == AttachmentEntityEnum.VisitAttachment && visitsIds.Contains(s.EntityId) && s.AttachmentTypeId == (long)AttachmentTypeEnum.VisitAttachment).Select(a => new AttachmentDto()
            {
                AttachmentId = a.Id,
                EntityId = a.EntityId,
                AttachmentGuid = a.AttachmentGuid,
                AttachmentName = a.AttachmentName,
                EntityName = a.EntityName,
                AttachmentType = (AttachmentTypeEnum)a.AttachmentTypeId,
            }).ToListAsync();

            var categoryLookupValue = await dbContext.LookupValue.ToListAsync();
            ComplianceRequestDto complianceRequestDto = new ComplianceRequestDto();

            complianceRequestDto = new ComplianceRequestDto
            {
                Id = record.Id,
                Seq = record.Seq,
                LastSendDate = record.LastSendDate,
                AssignTaskName = currentLanguageService.Language == LanguageEnum.En ? record.AssignTaskNameEn : record.AssignTaskNameAr,
                CreatedOn = record.CreatedOn,
                AssignedOn = record.AssignedOn,
                StatusId = record.StatusId,
                StatusName = currentLanguageService.Language == LanguageEnum.En ? record.Status.ValueEn : record.Status.ValueAr,
                PassedDays = record.PassedDays,
                RemainingDays = record.RemainingDays,
                AssignedSpecialists = record.ComplianceSpecialists?.Select(a => new ComplianceSpecialistDto()
                {
                    SpecialistUserEmail = a.SpecialistUserEmail,
                    SpecialistUserId = a.SpecialistUserId,
                    SpecialistUserName = a.SpecialistUserName
                })?.ToList(),

                CompliancePlans = record.ComplianceDetails?.Where(s => s.IsDeleted == false).OrderByDescending(s => s.Seq).Select(s => new CompliancePlanDto
                {
                    Id = s.Id,
                    Seq = s.Seq,
                    ActivityId = s.ActivityId,
                    ComplianceRequestId = s.ComplianceRequestId,

                    ActivityName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == s.ActivityId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == s.ActivityId)?.ValueAr,

                    LicensedEntityId = s.LicensedEntityId,
                    LicensedEntityName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == s.LicensedEntityId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == s.LicensedEntityId)?.ValueAr,


                    LocationId = s.LocationId,
                    LocationName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == s.LocationId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == s.LocationId)?.ValueAr,

                    PlantNameId = s.PlantNameId,
                    PlantName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == s.PlantNameId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == s.PlantNameId)?.ValueAr,

                    QuarterPlannedForVisitId = s.QuarterPlannedForVisitId,
                    QuarterPlannedForVisitName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == s.QuarterPlannedForVisitId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == s.QuarterPlannedForVisitId)?.ValueAr,
                    QuarterPlannedForVisitNameEn = categoryLookupValue.FirstOrDefault(a => a.Id == s.QuarterPlannedForVisitId)?.ValueEn,

                    VisitTypeId = s.VisitTypeId,
                    VisitTypeName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == s.VisitTypeId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == s.VisitTypeId)?.ValueAr,

                    VisitDate = s.VisitDate,
                    VisitReferenceNumber = s.VisitReferenceNumber,
                    DesignedCapacity = s.DesignedCapacity,

                    VisitStatusId = s.VisitStatusId,
                    VisitStatusName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == s.VisitStatusId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == s.VisitStatusId)?.ValueAr,

                    ModifiedOn = s.ModifiedOn,
                    CreatedOn = s.CreatedOn,


                    LocationVisit = s.LocationVisit,

                    ScheduledDate = s.ScheduledDate,
                    CancelledAt = s.CancelledAt,
                    CancellationReason = s.CancellationReason,
                    RescheduleReason = s.RescheduleReason,

                    ComplianceVisitSpecialists = s.ComplianceVisitSpecialists != null ? s.ComplianceVisitSpecialists.Select(a => new ComplianceVisitSpecialistModel()
                    {
                        ComplianceDetailsId = a.ComplianceDetailsId,
                        Id = a.Id,
                        MobileNumber = a.MobileNumber,
                        CreatedOn = a.CreatedOn,
                        SpecialistUserEmail = a.SpecialistUserEmail,
                        SpecialistUserId = a.SpecialistUserId,
                        SpecialistUserName = a.SpecialistUserName
                    }).ToList() : null,

                    VisitStatusHistory = s.VisitStatusHistory?.Select(a => new VisitStatusHistory
                    {
                        Id = a.Id,
                        ActionAt = a.ActionAt,
                        ActionByUserId = a.ActionByUserId,
                        ActionReason = a.ActionReason,
                        ComplianceDetailsId = a.ComplianceDetailsId,
                        NewStatus = a.NewStatus,
                        OldStatus = a.OldStatus,
                        RequestedNewDate = a.RequestedNewDate
                    }).ToList(),

                    VisitDocuments = visitDocuments.Where(a => a.EntityId == s.Id).ToList(),

                }).ToList(),
            };
            return ResponseResult<ComplianceRequestDto>.Success(complianceRequestDto);
        }

        return null;
    }
    public async Task<ResponseResult<bool>> SaveCompliancePlan(CompliancePlanModel model)
    {
        var complianceSpecialist = await dbContext.ComplianceSpecialist.Where(s => s.ComplianceRequestId == model.ComplianceRequestId).ToListAsync();
        if (complianceSpecialist.Any(s => s.SpecialistUserId == currentUserService.User.UserId))
        {
            ComplianceDetails complianceDetailsRecord = await dbContext.ComplianceDetails.FirstOrDefaultAsync(s => s.Id == model.Id);

            List<KeyValuePair<string, string>> detailsAr = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> detailsEn = new List<KeyValuePair<string, string>>();

            var categoryLookupValue = await dbContext.LookupValue.ToListAsync();
            var anyMatch = await dbContext.ComplianceDetails.AnyAsync(s => s.Id != model.Id && s.IsDeleted == false &&
               (

                   (model.LicensedEntityId == model.LicensedEntityId) &&
                   (model.ActivityId == s.ActivityId) &&
                   (model.PlantNameId == s.PlantNameId) &&
                   //(model.LocationId.HasValue && model.LocationId == complianceDetailsRecord.LocationId) ||
                   (model.QuarterPlannedForVisitId.HasValue && model.QuarterPlannedForVisitId == s.QuarterPlannedForVisitId) &&
                   (model.VisitTypeId == s.VisitTypeId)
               ));


            if (anyMatch)
            {
                throw new Exception("Can't Saved a Plan, one property in the model matches the existing record.");
            }


            if (complianceDetailsRecord != null)
            {
                detailsAr.Add(new KeyValuePair<string, string>("Seq", $"تم اجراء تعديل {complianceDetailsRecord.Seq} "));
                detailsEn.Add(new KeyValuePair<string, string>("Seq", $"record Number {complianceDetailsRecord.Seq} has been changed"));

                if (complianceDetailsRecord.ActivityId != model.ActivityId)
                {
                    detailsAr.Add(new KeyValuePair<string, string>("Activity", $"النشاط الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.ActivityId)?.ValueAr} , النشاط السابق : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.ActivityId)?.ValueAr}"));
                    detailsEn.Add(new KeyValuePair<string, string>("Activity", $"Current Activity: {categoryLookupValue.FirstOrDefault(a => a.Id == model.ActivityId)?.ValueEn} , Old Activity : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.ActivityId)?.ValueEn}"));
                }


                if (complianceDetailsRecord.LicensedEntityId != model.LicensedEntityId)
                {
                    detailsAr.Add(new KeyValuePair<string, string>("LicensedEntity", $"المرخص له الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.LicensedEntityId)?.ValueAr} , المخص له السابق : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.LicensedEntityId)?.ValueAr}"));
                    detailsEn.Add(new KeyValuePair<string, string>("LicensedEntity", $"Current Licensed Entity: {categoryLookupValue.FirstOrDefault(a => a.Id == model.LicensedEntityId)?.ValueEn} , Old Licensed Entity : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.LicensedEntityId)?.ValueEn}"));
                }

                if (complianceDetailsRecord.PlantNameId != model.PlantNameId)
                {
                    detailsAr.Add(new KeyValuePair<string, string>("PlantName", $"اسم المحطة الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.PlantNameId)?.ValueAr} , اسم المحطة السابق : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.PlantNameId)?.ValueAr}"));
                    detailsEn.Add(new KeyValuePair<string, string>("PlantName", $"Current Plant Name: {categoryLookupValue.FirstOrDefault(a => a.Id == model.PlantNameId)?.ValueEn} , Old Plant Name : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.PlantNameId)?.ValueEn}"));
                }


                if (complianceDetailsRecord.LocationId != model.LocationId)
                {
                    detailsAr.Add(new KeyValuePair<string, string>("Location", $"الموقع الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.LocationId)?.ValueAr} , الموقع السابق : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.LocationId)?.ValueAr}"));
                    detailsEn.Add(new KeyValuePair<string, string>("Location", $"Current Location: {categoryLookupValue.FirstOrDefault(a => a.Id == model.LocationId)?.ValueEn} , Old Location : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.LocationId)?.ValueEn}"));
                }

                if (complianceDetailsRecord.QuarterPlannedForVisitId != model.QuarterPlannedForVisitId)
                {
                    detailsAr.Add(new KeyValuePair<string, string>("QuarterPlannedForVisit", $"الربع المخطط له الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.QuarterPlannedForVisitId)?.ValueAr} , الربع المخطط له السابق : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.QuarterPlannedForVisitId)?.ValueAr}"));
                    detailsEn.Add(new KeyValuePair<string, string>("QuarterPlannedForVisit", $"Current Quarter Planned For Visit: {categoryLookupValue.FirstOrDefault(a => a.Id == model.QuarterPlannedForVisitId)?.ValueEn} , Old Quarter Planned For Visit : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.QuarterPlannedForVisitId)?.ValueEn}"));
                }

                if (complianceDetailsRecord.VisitTypeId != model.VisitTypeId)
                {
                    detailsAr.Add(new KeyValuePair<string, string>("VisitType", $"نوع الزيارة الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.VisitTypeId)?.ValueAr} , نوع الزيارة السابق : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.VisitTypeId)?.ValueAr}"));
                    detailsEn.Add(new KeyValuePair<string, string>("VisitType", $"Current Visit Type: {categoryLookupValue.FirstOrDefault(a => a.Id == model.VisitTypeId)?.ValueEn} , Old Visit Type : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.VisitTypeId)?.ValueEn}"));
                }
            }

            if (complianceDetailsRecord == null)
            {
                complianceDetailsRecord = new ComplianceDetails();
                complianceDetailsRecord.Id = Guid.NewGuid();
                complianceDetailsRecord.ComplianceRequestId = model.ComplianceRequestId;
                await dbContext.ComplianceDetails.AddAsync(complianceDetailsRecord);


                detailsAr.Add(new KeyValuePair<string, string>("Seq", $"تم اضافة خطة زيارة "));
                detailsEn.Add(new KeyValuePair<string, string>("Seq", $"New Plan Added"));

                detailsAr.Add(new KeyValuePair<string, string>("Activity", $"النشاط الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.ActivityId)?.ValueAr}"));
                detailsEn.Add(new KeyValuePair<string, string>("Activity", $"Current Activity: {categoryLookupValue.FirstOrDefault(a => a.Id == model.ActivityId)?.ValueEn}"));


                detailsAr.Add(new KeyValuePair<string, string>("LicensedEntity", $"المرخص له الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.LicensedEntityId)?.ValueAr}"));
                detailsEn.Add(new KeyValuePair<string, string>("LicensedEntity", $"Current Licensed Entity: {categoryLookupValue.FirstOrDefault(a => a.Id == model.LicensedEntityId)?.ValueEn}"));

                detailsAr.Add(new KeyValuePair<string, string>("PlantName", $"اسم المحطة الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.PlantNameId)?.ValueAr}"));
                detailsEn.Add(new KeyValuePair<string, string>("PlantName", $"Current Plant Name: {categoryLookupValue.FirstOrDefault(a => a.Id == model.PlantNameId)?.ValueEn}"));


                detailsAr.Add(new KeyValuePair<string, string>("Location", $"الموقع الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.LocationId)?.ValueAr}"));
                detailsEn.Add(new KeyValuePair<string, string>("Location", $"Current Location: {categoryLookupValue.FirstOrDefault(a => a.Id == model.LocationId)?.ValueEn}"));

                detailsAr.Add(new KeyValuePair<string, string>("QuarterPlannedForVisit", $"الربع المخطط له الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.QuarterPlannedForVisitId)?.ValueAr}"));
                detailsEn.Add(new KeyValuePair<string, string>("QuarterPlannedForVisit", $"Current Quarter Planned For Visit: {categoryLookupValue.FirstOrDefault(a => a.Id == model.QuarterPlannedForVisitId)?.ValueEn}"));

                detailsAr.Add(new KeyValuePair<string, string>("VisitType", $"نوع الزيارة الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.VisitTypeId)?.ValueAr}"));
                detailsEn.Add(new KeyValuePair<string, string>("VisitType", $"Current Visit Type: {categoryLookupValue.FirstOrDefault(a => a.Id == model.VisitTypeId)?.ValueEn} "));


            }

            complianceDetailsRecord.VisitTypeId = model.VisitTypeId;
            complianceDetailsRecord.LocationId = model.LocationId;
            complianceDetailsRecord.LicensedEntityId = model.LicensedEntityId;
            complianceDetailsRecord.PlantNameId = model.PlantNameId;
            complianceDetailsRecord.QuarterPlannedForVisitId = model.QuarterPlannedForVisitId;
            complianceDetailsRecord.ActivityId = model.ActivityId;
            complianceDetailsRecord.VisitStatusId = (long?)VisitStatusEnum.New;

            userRepository = new UserRepository();
            var users = (await userRepository.GetUsers(new List<string>())).Model;
            var template = ((await dbContext.Templates.FirstOrDefaultAsync(s => s.TemplateTypeId == (long)TemplateTypeEnum.Email && s.Id == (long)TemplateEnum.DraftSavedAnnualCompliancePlanForSpecialist)));
            if (template != null)
            {
                users = users.Where(s => complianceSpecialist.Any(a => a.SpecialistUserId == s.Id)).ToList();
                template.Content = template.Content.Replace("{{EmployeeName}}", "اخصائي الامتثال");
                template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");
                template.Content = template.Content.Replace("{{LastUpdatedDate}}", DateTime.Now.ToString("dd-MM-yyyy hh:mm tt"));

                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Subject = template.Subject,
                    Body = template.Content,
                    To = users.Select(s => s.Email).ToList(),
                });
            }

            ComplianceRequestActivity requestActivity = new ComplianceRequestActivity()
            {
                Id = Guid.NewGuid(),
                ComplianceRequestId = model.ComplianceRequestId,
                CreatedByUserId = currentUserService.User.UserId,
                CreatedByUserEmail = currentUserService.User.UserEmail,
                CreatedByUserName = currentUserService.User.UserName,
                CreatedOn = DateTime.Now,
                ActionAr = model.Id == null ? "اضافة" : "تعديل",
                ActionEn = model.Id == null ? "Add" : "Update",
                DetailsAr = JsonConvert.SerializeObject(detailsAr),
                DetailsEn = JsonConvert.SerializeObject(detailsEn),
            };

            await dbContext.ComplianceRequestActivity.AddAsync(requestActivity);
            return ResponseResult<bool>.Success(true);
        }

        throw new ValidationException(new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Unauthoried User", "Unauthoried User") });
    }

    public async Task<ResponseResult<bool>> DeleteCompliancePlan(Guid planId)
    {
        var compliancePlan = await dbContext.ComplianceDetails.FirstOrDefaultAsync(s => s.Id == planId);
        var complianceSpecialist = await dbContext.ComplianceSpecialist.Where(s => s.ComplianceRequestId == compliancePlan.ComplianceRequestId).ToListAsync();

        if (compliancePlan != null)
        {
            if (complianceSpecialist.Any(s => s.SpecialistUserId == currentUserService.User.UserId) || currentUserService.User.Role.Contains(RoleEnum.ComplianceManager))
            {

                compliancePlan.IsDeleted = true;

                var categoryLookupValue = await dbContext.LookupValue.ToListAsync();
                List<KeyValuePair<string, string>> detailsAr = new List<KeyValuePair<string, string>>();
                List<KeyValuePair<string, string>> detailsEn = new List<KeyValuePair<string, string>>();



                detailsAr.Add(new KeyValuePair<string, string>("Seq", $"تم حذف خطة زيارة "));
                detailsEn.Add(new KeyValuePair<string, string>("Seq", $"New Plan Deleted"));

                detailsAr.Add(new KeyValuePair<string, string>("Activity", $"النشاط: {categoryLookupValue.FirstOrDefault(a => a.Id == compliancePlan.ActivityId)?.ValueAr}"));
                detailsEn.Add(new KeyValuePair<string, string>("Activity", $" Activity: {categoryLookupValue.FirstOrDefault(a => a.Id == compliancePlan.ActivityId)?.ValueEn} "));


                detailsAr.Add(new KeyValuePair<string, string>("LicensedEntity", $"المرخص له : {categoryLookupValue.FirstOrDefault(a => a.Id == compliancePlan.LicensedEntityId)?.ValueAr} "));
                detailsEn.Add(new KeyValuePair<string, string>("LicensedEntity", $" Licensed Entity: {categoryLookupValue.FirstOrDefault(a => a.Id == compliancePlan.LicensedEntityId)?.ValueEn} "));

                detailsAr.Add(new KeyValuePair<string, string>("PlantName", $"اسم المحطة : {categoryLookupValue.FirstOrDefault(a => a.Id == compliancePlan.PlantNameId)?.ValueAr} "));
                detailsEn.Add(new KeyValuePair<string, string>("PlantName", $" Plant Name: {categoryLookupValue.FirstOrDefault(a => a.Id == compliancePlan.PlantNameId)?.ValueEn} "));


                detailsAr.Add(new KeyValuePair<string, string>("Location", $"الموقع : {categoryLookupValue.FirstOrDefault(a => a.Id == compliancePlan.LocationId)?.ValueAr} "));
                detailsEn.Add(new KeyValuePair<string, string>("Location", $" Location: {categoryLookupValue.FirstOrDefault(a => a.Id == compliancePlan.LocationId)?.ValueEn}"));

                detailsAr.Add(new KeyValuePair<string, string>("QuarterPlannedForVisit", $"الربع المخطط له : {categoryLookupValue.FirstOrDefault(a => a.Id == compliancePlan.QuarterPlannedForVisitId)?.ValueAr}"));
                detailsEn.Add(new KeyValuePair<string, string>("QuarterPlannedForVisit", $" Quarter Planned For Visit: {categoryLookupValue.FirstOrDefault(a => a.Id == compliancePlan.QuarterPlannedForVisitId)?.ValueEn} "));

                detailsAr.Add(new KeyValuePair<string, string>("VisitType", $"نوع الزيارة : {categoryLookupValue.FirstOrDefault(a => a.Id == compliancePlan.VisitTypeId)?.ValueAr}"));
                detailsEn.Add(new KeyValuePair<string, string>("VisitType", $" Visit Type: {categoryLookupValue.FirstOrDefault(a => a.Id == compliancePlan.VisitTypeId)?.ValueEn}"));

                ComplianceRequestActivity requestActivity = new ComplianceRequestActivity()
                {
                    Id = Guid.NewGuid(),
                    ComplianceRequestId = compliancePlan.ComplianceRequestId,
                    ActionAr = "حذف",
                    ActionEn = "Delete",
                    CreatedByUserId = currentUserService.User.UserId,
                    CreatedByUserEmail = currentUserService.User.UserEmail,
                    CreatedByUserName = currentUserService.User.UserName,
                    CreatedOn = DateTime.Now,
                    DetailsAr = JsonConvert.SerializeObject(detailsAr),
                    DetailsEn = JsonConvert.SerializeObject(detailsEn),
                };
                await dbContext.ComplianceRequestActivity.AddAsync(requestActivity);
                return ResponseResult<bool>.Success(true);
            }
            throw new ValidationException(new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Unauthoried User", "Unauthoried User") });
        }
        return ResponseResult<bool>.Success(false);
    }
    public async Task<ResponseResult<List<ComplianceActivityDto>>> GetComplianceActivities(Guid requestId)
    {
        var complianceActivities = await dbContext.ComplianceRequestActivity.Where(s => s.ComplianceRequestId == requestId).OrderByDescending(s => s.CreatedOn).ToListAsync();
        var result = complianceActivities.Select(s =>
        new ComplianceActivityDto()
        {
            CreatedOn = s.CreatedOn,
            CreatedByUserEmail = s.CreatedByUserEmail,
            CreatedByUserName = s.CreatedByUserName,
            ActionAr = s.ActionAr,
            ActionEn = s.ActionEn,
            DetailsAr = JsonConvert.DeserializeObject<List<KeyValuePair<string, string>>>(s.DetailsAr),
            DetailsEn = JsonConvert.DeserializeObject<List<KeyValuePair<string, string>>>(s.DetailsEn)
        }).ToList();

        return ResponseResult<List<ComplianceActivityDto>>.Success(result);
    }
    public async Task<ResponseResult<string>> GetComplianceApproval(Guid requestId)
    {
        var complianceApproval = await dbContext.ComplianceApproval?.Where(s => s.ComplianceRequestId == requestId)?.OrderByDescending(s => s.CreatedOn)?.FirstOrDefaultAsync();
        return ResponseResult<string>.Success(complianceApproval?.Notes);
    }
    public async Task<ResponseResult<string>> SendComplianceRequest(Guid requestId)
    {


        var record = await dbContext.ComplianceRequest
              .Include(s => s.ComplianceSpecialists)
              .Include(s => s.ComplianceDetails)
              .FirstOrDefaultAsync(s => s.Id == requestId);

        if (record != null && (record.ComplianceSpecialists.Any(s => s.SpecialistUserId == currentUserService.User.UserId) && (record.StatusId == (long)ComplianceStatusEnum.New  || record.StatusId == (long)ComplianceStatusEnum.ComplianceSpecialistPreparingDelayed || record.StatusId == (long)ComplianceStatusEnum.ReturnPlanOfPerformanceMonitoringManager || record.StatusId == (long)ComplianceStatusEnum.ReturnPlanOfComplianceManager)))
        {

            List<KeyValuePair<string, string>> detailsAr = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> detailsEn = new List<KeyValuePair<string, string>>();


            string role = "";
            if (record.StatusId == (int)ComplianceStatusEnum.New || record.StatusId == (int)ComplianceStatusEnum.ReturnPlanOfComplianceManager)
            {
                record.StatusId = (int)ComplianceStatusEnum.PendingReviewOfComplianceManager;
                role = RoleEnum.ComplianceManager;

                detailsAr.Add(new KeyValuePair<string, string>("Status", $"تم ارسال الخطة للمراجعة من قبل مدير الادارة"));
                detailsEn.Add(new KeyValuePair<string, string>("Status", $"The Plan Send for review by Compliance Manager"));

            }
            if (record.StatusId == (int)ComplianceStatusEnum.ReturnPlanOfPerformanceMonitoringManager)
            {
                record.StatusId = (int)ComplianceStatusEnum.PendingReviewOfPerformanceMonitoringManager;
                role = RoleEnum.PerformanceMonitoringManager;


                detailsAr.Add(new KeyValuePair<string, string>("Status", $"تم ارسال الخطة للمراجعة من قبل مدير عام مراقبة الاداء"));
                detailsEn.Add(new KeyValuePair<string, string>("Status", $"The Plan Send for review by Performance Monitoring Manager"));

            }

            if (record.StatusId == (int)ComplianceStatusEnum.ComplianceSpecialistPreparingDelayed)
            {
                record.StatusId = (int)ComplianceStatusEnum.PendingReviewOfComplianceManager;
                role = RoleEnum.ComplianceManager;

                detailsAr.Add(new KeyValuePair<string, string>("Status", $"تم ارسال الخطة للمراجعة من قبل مدير الادارة"));
                detailsEn.Add(new KeyValuePair<string, string>("Status", $"The Plan Send for review by Compliance Manager"));
            }

            record.LastSendDate = DateTime.Now;
            ComplianceApproval complianceApprovalRecord = new ComplianceApproval()
            {
                Id = Guid.NewGuid(),
                IsApproved = null,
                Notes = null,
                DaysForFinish = null,
                ComplianceRequestId = requestId,
                Role = role,
                ApprovalEmail = null,
                ApprovalUserName = null,
            };

            await dbContext.ComplianceApproval.AddAsync(complianceApprovalRecord);

            ComplianceRequestActivity requestActivity = new ComplianceRequestActivity()
            {
                Id = Guid.NewGuid(),
                ComplianceRequestId = record.Id,
                CreatedByUserId = currentUserService.User.UserId,
                CreatedByUserEmail = currentUserService.User.UserEmail,
                CreatedByUserName = currentUserService.User.UserName,
                CreatedOn = DateTime.Now,
                ActionAr = role == RoleEnum.ComplianceManager ? "تم الارسال لمدير الادارة" : "تم الارسال لمدير عام مراجعة الاداء",
                ActionEn = role == RoleEnum.ComplianceManager ? "Send to Compliance Manager " : "Send To Performance Monitoring Manager",
                DetailsAr = JsonConvert.SerializeObject(detailsAr),
                DetailsEn = JsonConvert.SerializeObject(detailsEn),
            };

            await dbContext.ComplianceRequestActivity.AddAsync(requestActivity);

            return ResponseResult<string>.Success(role);

        }
        throw new ValidationException(new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Unauthoried User", "Unauthoried User") });

    }
    public async Task<ResponseResult<string>> SendComplianceApprovalToPerformanceMonitoringManager(Guid requestId)
    {
        var record = await dbContext.ComplianceRequest
           .Include(s => s.ComplianceSpecialists)
           .Include(s => s.ComplianceDetails)
           .FirstOrDefaultAsync(s => s.Id == requestId);

        if (record != null)
        {

            List<KeyValuePair<string, string>> detailsAr = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> detailsEn = new List<KeyValuePair<string, string>>();


            string role = "";
            if (record.StatusId == (int)ComplianceStatusEnum.ApprovalOfTheComplianceManager)
            {
                record.StatusId = (int)ComplianceStatusEnum.PendingReviewOfPerformanceMonitoringManager;
               
                detailsAr.Add(new KeyValuePair<string, string>("Status", $"تم ارسال الخطة للمراجعة من قبل مدير عام مراقبة الاداء"));
                detailsEn.Add(new KeyValuePair<string, string>("Status", $"The Plan Send for review by Performance Monitoring Manager"));

            }
            record.LastSendDate = DateTime.Now;
            role = RoleEnum.PerformanceMonitoringManager;
            ComplianceApproval complianceApprovalRecord = new ComplianceApproval()
            {
                Id = Guid.NewGuid(),
                IsApproved = null,
                Notes = null,
                DaysForFinish = null,
                ComplianceRequestId = requestId,
                Role = role,
                ApprovalEmail = null,
                ApprovalUserName = null,
            };

            await dbContext.ComplianceApproval.AddAsync(complianceApprovalRecord);

            ComplianceRequestActivity requestActivity = new ComplianceRequestActivity()
            {
                Id = Guid.NewGuid(),
                ComplianceRequestId = record.Id,
                CreatedByUserId = currentUserService.User.UserId,
                CreatedByUserEmail = currentUserService.User.UserEmail,
                CreatedByUserName = currentUserService.User.UserName,
                CreatedOn = DateTime.Now,
                ActionAr = role == RoleEnum.ComplianceManager ? "تم الارسال لمدير الادارة" : "تم الارسال لمدير عام مراجعة الاداء",
                ActionEn = role == RoleEnum.ComplianceManager ? "Send to Compliance Manager " : "Send To Performance Monitoring Manager",
                DetailsAr = JsonConvert.SerializeObject(detailsAr),
                DetailsEn = JsonConvert.SerializeObject(detailsEn),
            };

            await dbContext.ComplianceRequestActivity.AddAsync(requestActivity);
            return ResponseResult<string>.Success(role);
        }
        throw new ValidationException(new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Unauthoried User", "Unauthoried User") });

    }
    public async Task<ResponseResult<bool>> ApproveOrRejectComplianceRequest(ApproveOrRejectComplianceRequestModel model, ComplianceStatusEnum status)
    {

        List<KeyValuePair<string, string>> detailsAr = new List<KeyValuePair<string, string>>();
        List<KeyValuePair<string, string>> detailsEn = new List<KeyValuePair<string, string>>();
        string actionAr = "";
        string actionEn = "";
        if (model.IsApproved)
        {
            if (model.Role == RoleEnum.PerformanceMonitoringManager)
            {
                actionAr = "موافقة مدير عام مراقبة الاداء";
                actionEn = "Approved by Performance Monitoring Manager";
                detailsAr.Add(new KeyValuePair<string, string>("Status", $"تم الموافقة علي الخطة من قبل مدير عام مراقبة الاداء"));
                detailsEn.Add(new KeyValuePair<string, string>("Status", $"The Plan Approved by Performance Monitoring Manager"));
            }

            if (model.Role == RoleEnum.ComplianceManager)
            {

                actionAr = "موافقة مدير الادارة";
                actionEn = "Approved by Performance Compliance Manager";
                detailsAr.Add(new KeyValuePair<string, string>("Status", $"تم الموافقة علي الخطة من قبل مدير الادارة"));
                detailsEn.Add(new KeyValuePair<string, string>("Status", $"The Plan Approved by Compliance Manager"));
            }
        }

        if (!model.IsApproved)
        {
            if (model.Role == RoleEnum.PerformanceMonitoringManager)
            {
                actionAr = "ارجاع مدير عام مراقبة الاداء";
                actionEn = "Returned by Performance Monitoring Manager";
                detailsAr.Add(new KeyValuePair<string, string>("Status", $"تم اعادة الخطة للاخصائي من قبل مدير عام مراقبة الاداء"));
                detailsAr.Add(new KeyValuePair<string, string>("Notes", $"الملاحظات: {model.Notes}"));
                detailsAr.Add(new KeyValuePair<string, string>("Day", $"ايام عمل انهاء الملاحظات: {model.DaysForFinish}"));
                detailsEn.Add(new KeyValuePair<string, string>("Status", $"The Plan is Returned by Performance Monitoring Manager"));
                detailsEn.Add(new KeyValuePair<string, string>("Notes", $"Notes: {model.Notes}"));
                detailsEn.Add(new KeyValuePair<string, string>("Day", $"Days For Solving Notes: {model.DaysForFinish}"));
            }

            if (model.Role == RoleEnum.ComplianceManager)
            {
                actionAr = "ارجاع مدير الادارة";
                actionEn = "Returned by Performance Compliance Manager";
                detailsAr.Add(new KeyValuePair<string, string>("Status", $"تم اعادة الخطة للاخصائي من قبل مدير الادارة"));
                detailsAr.Add(new KeyValuePair<string, string>("Notes", $"الملاحظات: {model.Notes}"));
                detailsAr.Add(new KeyValuePair<string, string>("Day", $"ايام عمل انهاء الملاحظات: {model.DaysForFinish}"));
                detailsEn.Add(new KeyValuePair<string, string>("Status", $"The Plan is Returned by Compliance Manager"));
                detailsEn.Add(new KeyValuePair<string, string>("Notes", $"Notes: {model.Notes}"));
                detailsEn.Add(new KeyValuePair<string, string>("Day", $"Days For Solving Notes: {model.DaysForFinish}"));
            }
        }

        var lastApproval = await dbContext.ComplianceApproval.Where(s => s.ComplianceRequestId == model.RequestId && s.Role == model.Role).OrderByDescending(s => s.CreatedOn).FirstOrDefaultAsync();
        if (lastApproval != null)
        {
            lastApproval.IsApproved = model.IsApproved;
            lastApproval.Notes = model.Notes;
            lastApproval.DaysForFinish = model.DaysForFinish;
            lastApproval.ApprovalEmail = currentUserService.User.UserEmail;
            lastApproval.ApprovalUserName = currentUserService.User.UserName;
        }

        ComplianceRequestActivity requestActivity = new ComplianceRequestActivity()
        {
            Id = Guid.NewGuid(),
            ComplianceRequestId = model.RequestId,
            CreatedByUserId = currentUserService.User.UserId,
            CreatedByUserEmail = currentUserService.User.UserEmail,
            CreatedByUserName = currentUserService.User.UserName,
            CreatedOn = DateTime.Now,
            ActionAr = actionAr,
            ActionEn = actionEn,
            DetailsAr = JsonConvert.SerializeObject(detailsAr),
            DetailsEn = JsonConvert.SerializeObject(detailsEn),
        };

        await dbContext.ComplianceRequestActivity.AddAsync(requestActivity);

        var record = await dbContext.ComplianceRequest
           .FirstOrDefaultAsync(s => s.Id == model.RequestId);

        record.LastSendDate = DateTime.Now;
        record.StatusId = (long)status;

        return ResponseResult<bool>.Success(true);
    }
    #endregion

    #region Phase 2
    public async Task<ResponseResult<bool>> SaveComplianceVisit(ComplianceVisitModel model, long? VisitStatusId = null)
    {
        ComplianceDetails complianceDetailsRecord = await dbContext.ComplianceDetails.FirstOrDefaultAsync(s => s.Id == model.Id);
        var categoryLookupValue = await dbContext.LookupValue.ToListAsync();

        var currentQuarterNameEn = categoryLookupValue.FirstOrDefault(a => a.Id == model.QuarterPlannedForVisitId)?.ValueEn;
        var modelVisitMonthEn = model.VisitDate.ToString("MMMM", new CultureInfo("en"));

        if (!currentQuarterNameEn.Contains(modelVisitMonthEn))
            return ResponseResult<bool>.Failure(new List<string> { "Visit Date is outside its designated Quarter." }, false);

        if (complianceDetailsRecord != null && currentUserService.User.Role.Any(
            role => role.Equals(RoleEnum.ComplianceSpecialist)
            || role.Equals(RoleEnum.ComplianceManager)))
        {
            List<KeyValuePair<string, string>> detailsAr = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> detailsEn = new List<KeyValuePair<string, string>>();

            if (complianceDetailsRecord.VisitDate == null)
            {
                if (string.IsNullOrWhiteSpace(complianceDetailsRecord.VisitReferenceNumber))
                {
                    complianceDetailsRecord.VisitReferenceNumber = $"VIS-{model.VisitDate.Year}-{model.VisitDate.Month}-{complianceDetailsRecord.Seq}";

                    detailsAr.Add(new KeyValuePair<string, string>("Seq", $"تم تعيين تاريخ الزيارة برقم تعريفي {complianceDetailsRecord.VisitReferenceNumber} "));
                    detailsEn.Add(new KeyValuePair<string, string>("Seq", $"The Visit Date is Assigned an ID number {complianceDetailsRecord.VisitReferenceNumber} has been changed"));

                }

                if (complianceDetailsRecord.VisitStatusId == null)
                {
                    complianceDetailsRecord.VisitStatusId = (long)VisitStatusEnum.New;

                    detailsAr.Add(new KeyValuePair<string, string>("VisitStatus", $"حالة الزيارة الحالية: {categoryLookupValue.FirstOrDefault(a => a.Id == (long)VisitStatusEnum.New)?.ValueAr}"));
                    detailsEn.Add(new KeyValuePair<string, string>("VisitStatus", $"Current Visit Status: {categoryLookupValue.FirstOrDefault(a => a.Id == (long)VisitStatusEnum.New)?.ValueEn}"));

                }

            }

            if (complianceDetailsRecord.ActivityId != model.ActivityId)
            {
                detailsAr.Add(new KeyValuePair<string, string>("Activity", $"النشاط الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.ActivityId)?.ValueAr} , النشاط السابق : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.ActivityId)?.ValueAr}"));
                detailsEn.Add(new KeyValuePair<string, string>("Activity", $"Current Activity: {categoryLookupValue.FirstOrDefault(a => a.Id == model.ActivityId)?.ValueEn} , Old Activity : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.ActivityId)?.ValueEn}"));
            }

            if (complianceDetailsRecord.LicensedEntityId != model.LicensedEntityId)
            {
                detailsAr.Add(new KeyValuePair<string, string>("LicensedEntity", $"المرخص له الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.LicensedEntityId)?.ValueAr} , المخص له السابق : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.LicensedEntityId)?.ValueAr}"));
                detailsEn.Add(new KeyValuePair<string, string>("LicensedEntity", $"Current Licensed Entity: {categoryLookupValue.FirstOrDefault(a => a.Id == model.LicensedEntityId)?.ValueEn} , Old Licensed Entity : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.LicensedEntityId)?.ValueEn}"));
            }

            if (complianceDetailsRecord.PlantNameId != model.PlantNameId)
            {
                detailsAr.Add(new KeyValuePair<string, string>("PlantName", $"اسم المحطة الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.PlantNameId)?.ValueAr} , اسم المحطة السابق : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.PlantNameId)?.ValueAr}"));
                detailsEn.Add(new KeyValuePair<string, string>("PlantName", $"Current Plant Name: {categoryLookupValue.FirstOrDefault(a => a.Id == model.PlantNameId)?.ValueEn} , Old Plant Name : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.PlantNameId)?.ValueEn}"));
            }

            if (complianceDetailsRecord.LocationId != model.LocationId)
            {
                detailsAr.Add(new KeyValuePair<string, string>("Location", $"الموقع الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.LocationId)?.ValueAr} , الموقع السابق : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.LocationId)?.ValueAr}"));
                detailsEn.Add(new KeyValuePair<string, string>("Location", $"Current Location: {categoryLookupValue.FirstOrDefault(a => a.Id == model.LocationId)?.ValueEn} , Old Location : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.LocationId)?.ValueEn}"));
            }

            if (complianceDetailsRecord.QuarterPlannedForVisitId != model.QuarterPlannedForVisitId)
            {
                detailsAr.Add(new KeyValuePair<string, string>("QuarterPlannedForVisit", $"الربع المخطط له الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.QuarterPlannedForVisitId)?.ValueAr} , الربع المخطط له السابق : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.QuarterPlannedForVisitId)?.ValueAr}"));
                detailsEn.Add(new KeyValuePair<string, string>("QuarterPlannedForVisit", $"Current Quarter Planned For Visit: {categoryLookupValue.FirstOrDefault(a => a.Id == model.QuarterPlannedForVisitId)?.ValueEn} , Old Quarter Planned For Visit : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.QuarterPlannedForVisitId)?.ValueEn}"));
            }

            if (complianceDetailsRecord.VisitTypeId != model.VisitTypeId)
            {
                detailsAr.Add(new KeyValuePair<string, string>("VisitType", $"نوع الزيارة الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.VisitTypeId)?.ValueAr} , نوع الزيارة السابق : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.VisitTypeId)?.ValueAr}"));
                detailsEn.Add(new KeyValuePair<string, string>("VisitType", $"Current Visit Type: {categoryLookupValue.FirstOrDefault(a => a.Id == model.VisitTypeId)?.ValueEn} , Old Visit Type : {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.VisitTypeId)?.ValueEn}"));
            }
            if (complianceDetailsRecord.VisitDate == null)
            {
                detailsAr.Add(new KeyValuePair<string, string>("VisitDate", $"تاريخ الزيارة الحالي: {model.VisitDate}"));
                detailsEn.Add(new KeyValuePair<string, string>("VisitDate", $"Current Visit Date: {model.VisitDate}"));
            }
            else if (complianceDetailsRecord.VisitDate != null)
            {
                if (complianceDetailsRecord.VisitStatusId != null)
                {

                    if (complianceDetailsRecord.VisitStatusId == (long)VisitStatusEnum.New)
                    {
                        detailsAr.Add(new KeyValuePair<string, string>("VisitStatus", $"حالة الزيارة الحالية: {categoryLookupValue.FirstOrDefault(a => a.Id == (long)VisitStatusEnum.Scheduled)?.ValueAr}, حالة الزيارة السابق: {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.VisitStatusId)?.ValueAr}"));
                        detailsEn.Add(new KeyValuePair<string, string>("VisitStatus", $"Current Visit Status: {categoryLookupValue.FirstOrDefault(a => a.Id == (long)VisitStatusEnum.Scheduled)?.ValueEn}, Old Visit Status: {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.VisitStatusId)?.ValueEn}"));

                        complianceDetailsRecord.VisitStatusId = (long)VisitStatusEnum.Scheduled;
                    }
                    else
                    {
                        if (VisitStatusId != null)
                        {
                            detailsAr.Add(new KeyValuePair<string, string>("VisitStatus", $"حالة الزيارة الحالية: {categoryLookupValue.FirstOrDefault(a => a.Id == VisitStatusId)?.ValueAr}, حالة الزيارة السابق: {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.VisitStatusId)?.ValueAr}"));
                            detailsEn.Add(new KeyValuePair<string, string>("VisitStatus", $"Current Visit Status: {categoryLookupValue.FirstOrDefault(a => a.Id == VisitStatusId)?.ValueEn}, Old Visit Status: {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetailsRecord.VisitStatusId)?.ValueEn}"));

                            complianceDetailsRecord.VisitStatusId = VisitStatusId;
                        }
                    }

                }
            }
            else if (complianceDetailsRecord.VisitDate != model.VisitDate)
            {
                detailsAr.Add(new KeyValuePair<string, string>("VisitDate", $"تاريخ الزيارة الحالي: {model.VisitDate} , تاريخ الزيارة السابق : {complianceDetailsRecord.VisitDate}"));
                detailsEn.Add(new KeyValuePair<string, string>("VisitDate", $"Current Visit Date: {model.VisitDate} , Old Visit Date : {complianceDetailsRecord.VisitDate}"));


            }

            if (complianceDetailsRecord.DesignedCapacity == null)
            {
                detailsAr.Add(new KeyValuePair<string, string>("DesignedCapacity", $"القدرة التصميمية الحالية: {model.DesignedCapacity}"));
                detailsEn.Add(new KeyValuePair<string, string>("DesignedCapacity", $"Current Designed Capacity: {model.DesignedCapacity}"));
            }
            else if (complianceDetailsRecord.DesignedCapacity != model.DesignedCapacity)
            {
                detailsAr.Add(new KeyValuePair<string, string>("VisitDate", $"القدرة التصميمية الحالية: {model.DesignedCapacity} , القدرة التصميمية السابق : {complianceDetailsRecord.DesignedCapacity}"));
                detailsEn.Add(new KeyValuePair<string, string>("VisitDate", $"Current Designed Capacity: {model.DesignedCapacity} , Old Designed Capacity : {complianceDetailsRecord.DesignedCapacity}"));
            }

            else if (complianceDetailsRecord.LocationVisit == null)
            {
                detailsAr.Add(new KeyValuePair<string, string>("LocationVisit", $"موقع الزيارة : {model.LocationVisit} , موقع الزيارة السابق : {complianceDetailsRecord.LocationVisit}"));
                detailsEn.Add(new KeyValuePair<string, string>("LocationVisit", $"Location Visit: {model.LocationVisit} , Old Location Visit : {complianceDetailsRecord.LocationVisit}"));
            }
            bool isNewVisit = complianceDetailsRecord.VisitDate == null;

            complianceDetailsRecord.VisitTypeId = model.VisitTypeId;
            complianceDetailsRecord.LocationId = model.LocationId;
            complianceDetailsRecord.LicensedEntityId = model.LicensedEntityId;
            complianceDetailsRecord.PlantNameId = model.PlantNameId;
            complianceDetailsRecord.QuarterPlannedForVisitId = model.QuarterPlannedForVisitId;
            complianceDetailsRecord.ActivityId = model.ActivityId;
            complianceDetailsRecord.DesignedCapacity = model.DesignedCapacity;
            complianceDetailsRecord.VisitDate = model.VisitDate;
            complianceDetailsRecord.LocationVisit = model.LocationVisit;
            complianceDetailsRecord.VisitStatusId = (long)VisitStatusEnum.New;


            ComplianceRequestActivity requestActivity = new ComplianceRequestActivity()
            {
                Id = Guid.NewGuid(),
                ComplianceRequestId = model.ComplianceRequestId,
                CreatedByUserId = currentUserService.User.UserId,
                CreatedByUserEmail = currentUserService.User.UserEmail,
                CreatedByUserName = currentUserService.User.UserName,
                CreatedOn = DateTime.Now,
                ActionAr = isNewVisit ? "اضافة" : "تعديل",
                ActionEn = isNewVisit ? "Add" : "Update",
                DetailsAr = JsonConvert.SerializeObject(detailsAr),
                DetailsEn = JsonConvert.SerializeObject(detailsEn),
            };

            await dbContext.ComplianceRequestActivity.AddAsync(requestActivity);
            return ResponseResult<bool>.Success(true);
        }

        throw new ValidationException(new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Unauthoried User", "Unauthoried User") });
    }
    public async Task<ResponseResult<List<CompliancePlanDto>>> GetVisitsByStatusForLoggedInUser(string LoggedInUserId, long visitStatusId)
    {
        var visitIds = await dbContext.ComplianceVisitSpecialist.Where(vs => vs.SpecialistUserId.Equals(LoggedInUserId) && vs.IsDeleted == false).Select(vs => vs.ComplianceDetailsId).Distinct().ToListAsync();

        var visits = await dbContext.ComplianceDetails.Include(c => c.ComplianceVisitSpecialists)
                            .ThenInclude(c => c.ComplianceVisitDisclosure)
                        .Where(c => visitIds.Contains(c.Id) && c.VisitStatusId.Equals(visitStatusId)).ToListAsync();

        if (visits != null && visits.Count() > 0)
        {
            var categoryLookupValue = await dbContext.LookupValue.ToListAsync();

            List<CompliancePlanDto>? userVisits = visits.Select(v => new CompliancePlanDto()
            {
                Id = v.Id,
                Seq = v.Seq,
                ActivityId = v.ActivityId,
                ComplianceRequestId = v.ComplianceRequestId,

                ActivityName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == v.ActivityId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == v.ActivityId)?.ValueAr,

                LicensedEntityId = v.LicensedEntityId,
                LicensedEntityName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == v.LicensedEntityId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == v.LicensedEntityId)?.ValueAr,


                LocationId = v.LocationId,
                LocationName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == v.LocationId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == v.LocationId)?.ValueAr,

                PlantNameId = v.PlantNameId,
                PlantName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == v.PlantNameId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == v.PlantNameId)?.ValueAr,

                QuarterPlannedForVisitId = v.QuarterPlannedForVisitId,
                QuarterPlannedForVisitName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == v.QuarterPlannedForVisitId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == v.QuarterPlannedForVisitId)?.ValueAr,

                VisitTypeId = v.VisitTypeId,
                VisitTypeName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == v.VisitTypeId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == v.VisitTypeId)?.ValueAr,

                ModifiedOn = v.ModifiedOn,
                CreatedOn = v.CreatedOn,

                DesignedCapacity = v.DesignedCapacity,
                VisitDate = v.VisitDate,
                VisitReferenceNumber = v.VisitReferenceNumber,

                VisitStatusId = v.VisitStatusId,
                VisitStatusName = (v.VisitStatusId != null)
                        ? (currentLanguageService.Language == LanguageEnum.En
                            ? categoryLookupValue.FirstOrDefault(a => a.Id == v.VisitStatusId)?.ValueEn
                            : categoryLookupValue.FirstOrDefault(a => a.Id == v.VisitStatusId)?.ValueAr
                        ) : null,


                UnscheduledVisitsForCurrentQuarter = GetUnscheduledVisitsForCurrentQuarter().Result.Count(),

                ComplianceVisitSpecialists = v.ComplianceVisitSpecialists?.Where(s => s.IsDeleted == false)
                        .Select(s => new ComplianceVisitSpecialistModel()
                        {
                            Id = s.Id,
                            ComplianceDetailsId = s.ComplianceDetailsId,
                            SpecialistUserId = s.SpecialistUserId,
                            SpecialistUserName = s.SpecialistUserName,
                            SpecialistUserEmail = s.SpecialistUserEmail,
                            MobileNumber = s.MobileNumber,
                            ComplianceVisitDisclosure = s.ComplianceVisitDisclosure != null
                            ? new ComplianceVisitDisclosureModel()
                            {
                                Id = s.ComplianceVisitDisclosure.Id,
                                ComplianceVisitSpecialistId = s.ComplianceVisitDisclosure.ComplianceVisitSpecialistId,
                                SurveyNotes = s.ComplianceVisitDisclosure.SurveyNotes,
                                HasConflicts = s.ComplianceVisitDisclosure.HasConflicts,
                            }
                            : null,

                        }).ToList(),

            }).ToList();

            return ResponseResult<List<CompliancePlanDto>>.Success(userVisits);
        }

        return null;
    }
    public async Task<List<CompliancePlanDto>> GetNewVisitsForCurrentQuarter()
    {
        var request = await GetComplianceRequest(null, isEmail: true);

        string currentMonthName = DateTime.Now.ToString("MMMM");

        //get current quarter name excluding month
        //e.g: get "First Quarter" from "First Quarter - January"
        var quarterNameEnForPendingVisits = request.Model?.CompliancePlans?.Where(p => p.QuarterPlannedForVisitNameEn.Contains(currentMonthName)).FirstOrDefault()?.QuarterPlannedForVisitNameEn;

        if (quarterNameEnForPendingVisits != null)
        {
            quarterNameEnForPendingVisits = string.Join(" ", quarterNameEnForPendingVisits.Split(' ', StringSplitOptions.RemoveEmptyEntries).Take(2));

            //get scheduled visits for current quarter
            List<CompliancePlanDto>? scheduledVisits = request.Model?.CompliancePlans?.Where(p =>
                p.QuarterPlannedForVisitNameEn.StartsWith(quarterNameEnForPendingVisits)
                && p.VisitStatusId.Equals((long)VisitStatusEnum.New)
                && !String.IsNullOrEmpty(p.VisitReferenceNumber)
            ).ToList();

            return scheduledVisits;
        }

        return null;
    }
    public async Task<List<CompliancePlanDto>> GetUnscheduledVisitsForCurrentQuarter()
    {
        var request = await GetComplianceRequest(null, isEmail: true);

        string currentMonthName = DateTime.Now.ToString("MMMM");

        //get current quarter name excluding month
        //e.g: get "First Quarter" from "First Quarter - January"
        var quarterNameEnForPendingVisits = request.Model?.CompliancePlans?.Where(p => p.QuarterPlannedForVisitNameEn.Contains(currentMonthName)).FirstOrDefault()?.QuarterPlannedForVisitNameEn;

        if (quarterNameEnForPendingVisits != null)
        {
            quarterNameEnForPendingVisits = string.Join(" ", quarterNameEnForPendingVisits.Split(' ', StringSplitOptions.RemoveEmptyEntries).Take(2));

            //get unscheduled visits for current quarter
            List<CompliancePlanDto>? unscheduledVisits = request.Model?.CompliancePlans?.Where(p =>
                p.QuarterPlannedForVisitNameEn.StartsWith(quarterNameEnForPendingVisits)
                && p.VisitStatusId == null
                && String.IsNullOrEmpty(p.VisitReferenceNumber)
            ).ToList();

            return unscheduledVisits;
        }

        return null;
    }
    public async Task<ResponseResult<CompliancePlanDto>> GetComplianceVisitDetail(Guid id)
    {
        var complianceVisit = dbContext.ComplianceDetails?.Where(s => s.Id == id)
            .Include(s => s.ComplianceVisitSpecialists).FirstOrDefault();

        if (complianceVisit != null)
        {
            var categoryLookupValue = await dbContext.LookupValue.ToListAsync();
            CompliancePlanDto result = new CompliancePlanDto()
            {
                Id = complianceVisit.Id,
                Seq = complianceVisit.Seq,
                ActivityId = complianceVisit.ActivityId,
                ComplianceRequestId = complianceVisit.ComplianceRequestId,

                ActivityName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == complianceVisit.ActivityId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == complianceVisit.ActivityId)?.ValueAr,

                LicensedEntityId = complianceVisit.LicensedEntityId,
                LicensedEntityName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == complianceVisit.LicensedEntityId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == complianceVisit.LicensedEntityId)?.ValueAr,


                LocationId = complianceVisit.LocationId,
                LocationName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == complianceVisit.LocationId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == complianceVisit.LocationId)?.ValueAr,

                PlantNameId = complianceVisit.PlantNameId,
                PlantName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == complianceVisit.PlantNameId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == complianceVisit.PlantNameId)?.ValueAr,

                QuarterPlannedForVisitId = complianceVisit.QuarterPlannedForVisitId,
                QuarterPlannedForVisitName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == complianceVisit.QuarterPlannedForVisitId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == complianceVisit.QuarterPlannedForVisitId)?.ValueAr,

                VisitTypeId = complianceVisit.VisitTypeId,
                VisitTypeName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == complianceVisit.VisitTypeId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == complianceVisit.VisitTypeId)?.ValueAr,

                ModifiedOn = complianceVisit.ModifiedOn,
                CreatedOn = complianceVisit.CreatedOn,

                DesignedCapacity = complianceVisit.DesignedCapacity,
                VisitDate = complianceVisit.VisitDate,
                VisitReferenceNumber = complianceVisit.VisitReferenceNumber,

                VisitStatusId = complianceVisit.VisitStatusId,
                VisitStatusName = (complianceVisit.VisitStatusId != null)
                    ? (currentLanguageService.Language == LanguageEnum.En
                        ? categoryLookupValue.FirstOrDefault(a => a.Id == complianceVisit.VisitStatusId)?.ValueEn
                        : categoryLookupValue.FirstOrDefault(a => a.Id == complianceVisit.VisitStatusId)?.ValueAr
                    ) : null,


                UnscheduledVisitsForCurrentQuarter = GetUnscheduledVisitsForCurrentQuarter().Result?.Count() ?? null,

                ComplianceVisitSpecialists = complianceVisit.ComplianceVisitSpecialists?.Where(s => s.IsDeleted == false)
                    .Select(s => new ComplianceVisitSpecialistModel()
                    {
                        Id = s.Id,
                        ComplianceDetailsId = s.ComplianceDetailsId,
                        SpecialistUserId = s.SpecialistUserId,
                        SpecialistUserName = s.SpecialistUserName,
                        SpecialistUserEmail = s.SpecialistUserEmail,
                        MobileNumber = s.MobileNumber,

                    }).ToList() ?? null,
            };
            return ResponseResult<CompliancePlanDto>.Success(result);
        }
        return null;
    }
    public async Task<ResponseResult<List<ComplianceVisitSpecialistModel>>> GetComplianceVisitSpecialists(Guid complianceDetailId)
    {
        var complianceVisitSpecialists = await dbContext.ComplianceVisitSpecialist.Include(s => s.ComplianceVisitDisclosure).Where(s => s.ComplianceDetailsId == complianceDetailId && s.IsDeleted == false).ToListAsync();

        if (complianceVisitSpecialists != null && complianceVisitSpecialists.Count() > 0)
        {
            List<ComplianceVisitSpecialistModel> result = new List<ComplianceVisitSpecialistModel>();
            foreach (var specialist in complianceVisitSpecialists)
            {
                ComplianceVisitSpecialistModel specialistModel = new ComplianceVisitSpecialistModel()
                {
                    Id = specialist.Id,
                    ComplianceDetailsId = specialist.ComplianceDetailsId,
                    SpecialistUserId = specialist.SpecialistUserId,
                    SpecialistUserName = specialist.SpecialistUserName,
                    SpecialistUserEmail = specialist.SpecialistUserEmail,
                    CreatedOn = specialist.CreatedOn,
                    ComplianceVisitDisclosure = specialist.ComplianceVisitDisclosure != null
                    ? new ComplianceVisitDisclosureModel()
                    {
                        Id = specialist.ComplianceVisitDisclosure.Id,
                        HasConflicts = specialist.ComplianceVisitDisclosure.HasConflicts,
                        ComplianceVisitSpecialistId = specialist.ComplianceVisitDisclosure.ComplianceVisitSpecialistId,
                        SurveyNotes = specialist.ComplianceVisitDisclosure.SurveyNotes,
                    }
                    : null
                };

                result.Add(specialistModel);
            }
            return ResponseResult<List<ComplianceVisitSpecialistModel>>.Success(result);
        }
        return null;
    }
    public async Task<ResponseResult<List<ComplianceSpecialistDto>>> GetComplianceRequestSpecialists(Guid visitId)
    {
        var visitDate = (await dbContext.ComplianceDetails.FirstOrDefaultAsync(s => s.Id == visitId))?.VisitDate;

        var visitSpecialist = new List<ComplianceVisitSpecialist>();
        if (visitDate != null)
        {
            visitSpecialist = await dbContext.ComplianceVisitSpecialist
                                                 .Include(s => s.ComplianceDetails)
                                                 .Where(s =>
                                                        (s.IsDeleted == false || s.IsDeleted == null) &&
                                                        s.ComplianceDetails != null &&
                                                        s.ComplianceDetails.VisitDate != null &&
                                                        s.ComplianceDetails.VisitDate.Value.Date.Equals(visitDate)
                                                        ).ToListAsync();
        }

        UserRepository userRepository = new UserRepository();
        var complianceSpecialists = await userRepository.GetUsers(new List<string>() { RoleEnum.ComplianceSpecialist.ToString() });

        if (complianceSpecialists != null && complianceSpecialists.Model != null && complianceSpecialists.Model.Count() > 0)
        {
            List<ComplianceSpecialistDto> result = new List<ComplianceSpecialistDto>();
            foreach (var specialist in complianceSpecialists.Model)
            {
                if (!visitSpecialist.Any(s => s.SpecialistUserId == specialist.Id))
                {
                    ComplianceSpecialistDto specialistModel = new ComplianceSpecialistDto()
                    {
                        SpecialistUserId = specialist.Id,
                        SpecialistUserName = specialist.UserName,
                        SpecialistUserEmail = specialist.Email,
                    };

                    result.Add(specialistModel);
                }
            }
            return ResponseResult<List<ComplianceSpecialistDto>>.Success(result);
        }
        return null;
    }
    private async Task<List<string>> CheckSpecialistsDisclosureConflicts(AssignComplianceVisitSpecialistModel model)
    {
        List<string> conflictedUserErrors = new List<string>();
        var visitSpecialist = await dbContext.ComplianceVisitSpecialist
            .Include(s => s.ComplianceVisitDisclosure)
            .Where(s =>
                    model.AssignedUserId.Contains(s.SpecialistUserId) &&
                    s.ComplianceDetailsId == model.ComplianceDetailsId &&
                    (s.IsDeleted == false || s.IsDeleted == null) &&
                    s.ComplianceVisitDisclosure != null &&
                    s.ComplianceVisitDisclosure.HasConflicts
                  ).ToListAsync();


        if (visitSpecialist != null && visitSpecialist.Count > 0)
            visitSpecialist.ForEach(s => conflictedUserErrors.Add(currentLanguageService.Language == LanguageEnum.En ? $"UserName: {s.SpecialistUserName} has conflict of interest and cannot be assigned to this visit." : $"الاخصائي : {s.SpecialistUserName} يوجد تضارب في المصالح ولا يمكن تعيينه لهذه الزيارة."));

        return conflictedUserErrors;
    }
    private async Task<List<string>> CheckSpecialistsAvailablity(AssignComplianceVisitSpecialistModel model, DateTime? VisitDateFromModel)
    {
        List<string> unavailableUserErrors = [];

        var assignedVisitSpecialist = await dbContext.ComplianceVisitSpecialist
                                                     .Include(s => s.ComplianceDetails)
                                                     .Where(s =>
                                                            model.AssignedUserId.Contains(s.SpecialistUserId) &&
                                                            (s.IsDeleted == false || s.IsDeleted == null) &&
                                                            s.ComplianceDetailsId != model.ComplianceDetailsId &&
                                                            s.ComplianceDetails != null &&
                                                            s.ComplianceDetails.VisitDate != null &&
                                                            s.ComplianceDetails.VisitDate.Value.Date.Equals(VisitDateFromModel.Value.Date)
                                                           ).ToListAsync();

        if (assignedVisitSpecialist != null && assignedVisitSpecialist.Count() > 0)
            assignedVisitSpecialist.ForEach(s => unavailableUserErrors.Add(currentLanguageService.Language == LanguageEnum.En ? $"UserName: {s.SpecialistUserName} is unavailable and cannot be assigned to this visit." : $"الاخصائي : {s.SpecialistUserName} غير متاح لهذه الزيارة"));

        return unavailableUserErrors;
    }
    private async Task<bool> CheckAllTeamMembersAvailablity(AssignComplianceVisitSpecialistModel model, DateTime VisitDateFromModel)
    {
        List<string> unavailableUserErrors = new List<string>();


        var assignedVisitSpecialist = await dbContext.ComplianceVisitSpecialist
                                                     .Include(s => s.ComplianceDetails)
                                                     .Where(s =>
                                                            model.AssignedUserId.Contains(s.SpecialistUserId) &&
                                                            (s.IsDeleted == false || s.IsDeleted == null) &&
                                                            s.ComplianceDetailsId != model.ComplianceDetailsId &&
                                                            s.ComplianceDetails != null &&
                                                            s.ComplianceDetails.VisitDate != null &&
                                                            s.ComplianceDetails.VisitDate.Value.Date.Equals(VisitDateFromModel.Date)
                                                           ).ToListAsync();
        if (assignedVisitSpecialist != null && assignedVisitSpecialist.Count > 0)
            assignedVisitSpecialist.ForEach(s => unavailableUserErrors.Add(currentLanguageService.Language == LanguageEnum.En ? $"UserName: {s.SpecialistUserName} is unavailable and cannot be assigned to this visit." : $"الاخصائي : {s.SpecialistUserName} غير متاح لهذه الزيارة"));

        return unavailableUserErrors.Count() == model.AssignedUserId.Count();
    }
    public async Task<ResponseResult<AssignComplianceVisitSpecialistResponseModel>> AssignComplianceVisitSpecialists(AssignComplianceVisitSpecialistModel model)
    {
        bool isUpdate = false;
        List<string> newlyAssignedUsers = new List<string>();
        List<string> UsersToRemoveDueToConflict = new List<string>();

        var complianceDetail = await dbContext.ComplianceDetails.Include(s => s.ComplianceVisitSpecialists).
            ThenInclude(s => s.ComplianceVisitDisclosure).FirstOrDefaultAsync(s => s.Id == model.ComplianceDetailsId);

        if (complianceDetail != null)
        {
            List<string> unavailableUserErrors = await CheckSpecialistsAvailablity(model, complianceDetail.VisitDate);
            if (unavailableUserErrors != null && unavailableUserErrors.Count > 0)
            {
                return ResponseResult<AssignComplianceVisitSpecialistResponseModel>.Failure(unavailableUserErrors, new AssignComplianceVisitSpecialistResponseModel());
            }

            List<string> conflictedUserErrors = await CheckSpecialistsDisclosureConflicts(model);
            if (conflictedUserErrors != null && conflictedUserErrors.Count > 0)
            {
                return ResponseResult<AssignComplianceVisitSpecialistResponseModel>.Failure(conflictedUserErrors, new AssignComplianceVisitSpecialistResponseModel());
            }

            List<KeyValuePair<string, string>> detailsAr = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> detailsEn = new List<KeyValuePair<string, string>>();

            UserRepository userRepository = new UserRepository();
            var users = await userRepository.GetUsersByIds(model.AssignedUserId);

            if (complianceDetail.ComplianceVisitSpecialists != null && complianceDetail.ComplianceVisitSpecialists.Count() > 0)
            {
                var assignedSpecialistsIds = complianceDetail.ComplianceVisitSpecialists.Select(s => s.SpecialistUserId).ToList();
                newlyAssignedUsers = model.AssignedUserId.Except(assignedSpecialistsIds).ToList();

                List<string> usersToRemove = assignedSpecialistsIds.Except(model.AssignedUserId).ToList();
                List<string> conflictUsers = complianceDetail.ComplianceVisitSpecialists.Where(s => s.ComplianceVisitDisclosure != null && s.ComplianceVisitDisclosure.HasConflicts).Select(s => s.SpecialistUserId).ToList();


                var toBeRemovedComplianceSpecialists = dbContext.ComplianceVisitSpecialist.Where(s => usersToRemove.Contains(s.SpecialistUserId) && s.ComplianceDetailsId == complianceDetail.Id && (s.IsDeleted == false || s.IsDeleted == null)).ToList();

                if (toBeRemovedComplianceSpecialists != null && toBeRemovedComplianceSpecialists.Count() > 0)
                {
                    foreach (var specialist in toBeRemovedComplianceSpecialists)
                    {
                        specialist.IsDeleted = true;
                    }
                }

                detailsAr.Add(new KeyValuePair<string, string>("Seq", $"تم تغيير المتخصصين في زيارة الامتثال"));
                detailsEn.Add(new KeyValuePair<string, string>("Seq", $"Compliance Visit Specialists have been changed"));
                isUpdate = true;

                foreach (var newUserId in newlyAssignedUsers)
                {
                    var user = users.Model.FirstOrDefault(s => s.Id == newUserId);

                    detailsAr.Add(new KeyValuePair<string, string>("ComplianceVisitSpecialist", $"اسم الاخصائي: {user.UserName}"));
                    detailsEn.Add(new KeyValuePair<string, string>("ComplianceVisitSpecialist", $"Compliance Visit Specialist Name: {user.UserName}"));

                    detailsAr.Add(new KeyValuePair<string, string>("ComplianceVisitSpecialist", $"البريد الالكتروني الاخصائي: {user.Email}"));
                    detailsEn.Add(new KeyValuePair<string, string>("ComplianceVisitSpecialist", $"Compliance Visit Specialist Email: {user.Email}"));

                    ComplianceVisitSpecialist record = new ComplianceVisitSpecialist()
                    {
                        Id = Guid.NewGuid(),
                        SpecialistUserId = newUserId,
                        ComplianceDetailsId = model.ComplianceDetailsId,
                        SpecialistUserEmail = user.Email,
                        SpecialistUserName = user.UserName,
                        MobileNumber = user.MobileNumber,
                    };
                    await dbContext.ComplianceVisitSpecialist.AddAsync(record);
                }

            }

            else
            {
                detailsAr.Add(new KeyValuePair<string, string>("Seq", $"لقد تم تعيين قائمة المتخصصين في الزيارة."));
                detailsEn.Add(new KeyValuePair<string, string>("Seq", $"Compliance Visit Specialists have been Assigned"));

                newlyAssignedUsers = model.AssignedUserId;

                foreach (var item in model.AssignedUserId)
                {
                    var user = users.Model.FirstOrDefault(s => s.Id == item);

                    detailsAr.Add(new KeyValuePair<string, string>("ComplianceVisitSpecialist", $"اسم الاخصائي: {user.UserName}"));
                    detailsEn.Add(new KeyValuePair<string, string>("ComplianceVisitSpecialist", $"Compliance Visit Specialist Name: {user.UserName}"));

                    detailsAr.Add(new KeyValuePair<string, string>("ComplianceVisitSpecialist", $"البريد الالكتروني الاخصائي: {user.Email}"));
                    detailsEn.Add(new KeyValuePair<string, string>("ComplianceVisitSpecialist", $"Compliance Visit Specialist Email: {user.Email}"));

                    ComplianceVisitSpecialist record = new ComplianceVisitSpecialist()
                    {
                        Id = Guid.NewGuid(),
                        SpecialistUserId = item,
                        ComplianceDetailsId = model.ComplianceDetailsId,
                        SpecialistUserEmail = user.Email,
                        SpecialistUserName = user.UserName,
                        MobileNumber = user.MobileNumber,
                    };
                    await dbContext.ComplianceVisitSpecialist.AddAsync(record);
                }

            }

            //update visit status to conflict of interest resolved if no active conflicts
            if (complianceDetail.VisitStatusId.Equals((long)VisitStatusEnum.ConflictOfInterestDisclosure))
            {
                var activeConflicts = complianceDetail.ComplianceVisitSpecialists.Where(s => s.IsDeleted == false && s.ComplianceVisitDisclosure.HasConflicts).ToList();
                if (activeConflicts is null || activeConflicts.Count() <= 0)
                {
                    var categoryLookupValue = await dbContext.LookupValue.ToListAsync();

                    detailsAr.Add(new KeyValuePair<string, string>("VisitStatus", $"حالة الزيارة الحالية: {categoryLookupValue.FirstOrDefault(a => a.Id == (long)VisitStatusEnum.ConflictOfInterestResolved)?.ValueAr}, حالة الزيارة السابق: {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetail.VisitStatusId)?.ValueAr}"));
                    detailsEn.Add(new KeyValuePair<string, string>("VisitStatus", $"Current Visit Status: {categoryLookupValue.FirstOrDefault(a => a.Id == (long)VisitStatusEnum.ConflictOfInterestResolved)?.ValueEn}, Old Visit Status: {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetail.VisitStatusId)?.ValueEn}"));

                    complianceDetail.VisitStatusId = (long)VisitStatusEnum.ConflictOfInterestResolved;
                }
            }

            //team availability
            if (complianceDetail.VisitStatusId.Equals((long)VisitStatusEnum.Scheduled)
                || complianceDetail.VisitStatusId.Equals((long)VisitStatusEnum.Rescheduled)
                || complianceDetail.VisitStatusId.Equals((long)VisitStatusEnum.New)
                || complianceDetail.VisitStatusId.Equals((long)VisitStatusEnum.ConflictOfInterestResolved)
                || complianceDetail.VisitStatusId.Equals((long)VisitStatusEnum.NoTeamMemberAvailable))
            {
                var isNoTeamAvailable = await CheckAllTeamMembersAvailablity(model, complianceDetail.VisitDate.Value);
                if (isNoTeamAvailable)
                {
                    var categoryLookupValue = await dbContext.LookupValue.ToListAsync();

                    detailsAr.Add(new KeyValuePair<string, string>("VisitStatus", $"حالة الزيارة الحالية: {categoryLookupValue.FirstOrDefault(a => a.Id == (long)VisitStatusEnum.NoTeamMemberAvailable)?.ValueAr}, حالة الزيارة السابق: {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetail.VisitStatusId)?.ValueAr}"));
                    detailsEn.Add(new KeyValuePair<string, string>("VisitStatus", $"Current Visit Status: {categoryLookupValue.FirstOrDefault(a => a.Id == (long)VisitStatusEnum.NoTeamMemberAvailable)?.ValueEn}, Old Visit Status: {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetail.VisitStatusId)?.ValueEn}"));

                    complianceDetail.VisitStatusId = (long)VisitStatusEnum.NoTeamMemberAvailable;
                }
                else
                {
                    var categoryLookupValue = await dbContext.LookupValue.ToListAsync();

                    detailsAr.Add(new KeyValuePair<string, string>("VisitStatus", $"حالة الزيارة الحالية: {categoryLookupValue.FirstOrDefault(a => a.Id == (long)VisitStatusEnum.Scheduled)?.ValueAr}, حالة الزيارة السابق: {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetail.VisitStatusId)?.ValueAr}"));
                    detailsEn.Add(new KeyValuePair<string, string>("VisitStatus", $"Current Visit Status: {categoryLookupValue.FirstOrDefault(a => a.Id == (long)VisitStatusEnum.Scheduled)?.ValueEn}, Old Visit Status: {categoryLookupValue.FirstOrDefault(a => a.Id == complianceDetail.VisitStatusId)?.ValueEn}"));

                    complianceDetail.VisitStatusId = (long)VisitStatusEnum.Scheduled;
                }
            }


            ComplianceRequestActivity requestActivity = new ComplianceRequestActivity()
            {
                Id = Guid.NewGuid(),
                ComplianceRequestId = model.RequestId,
                CreatedByUserId = currentUserService.User.UserId,
                CreatedByUserEmail = currentUserService.User.UserEmail,
                CreatedByUserName = currentUserService.User.UserName,
                CreatedOn = DateTime.Now,
                ActionAr = isUpdate == false ? "اضافة" : "تعديل",
                ActionEn = isUpdate == false ? "Add" : "Update",
                DetailsAr = JsonConvert.SerializeObject(detailsAr),
                DetailsEn = JsonConvert.SerializeObject(detailsEn),
            };
            await dbContext.ComplianceRequestActivity.AddAsync(requestActivity);

        }
        return ResponseResult<AssignComplianceVisitSpecialistResponseModel>.Success(new AssignComplianceVisitSpecialistResponseModel() { NotifyConflictUsers = UsersToRemoveDueToConflict, NotifyNewUsers = newlyAssignedUsers, IsUpdate = isUpdate });

    }

    #region Part 03
    public async Task<ResponseResult<List<ComplianceDetailsDto>>> GetComplianceVisit()
    {
        var categoryLookupValue = await dbContext.LookupValue.ToListAsync();

        var lookupDictEn = categoryLookupValue.ToDictionary(x => x.Id, x => x.ValueEn);
        var lookupDictAr = categoryLookupValue.ToDictionary(x => x.Id, x => x.ValueAr);

        var visits = await dbContext.ComplianceDetails
            .Include(s => s.ComplianceVisitSpecialists)
            .Where(s => !s.IsDeleted)
            .Select(record => new ComplianceDetailsDto
            {
                Id = record.Id,
                Seq = record.Seq,
                ActivityId = record.ActivityId,
                ComplianceRequestId = record.ComplianceRequestId,
                LicensedEntityId = record.LicensedEntityId,
                LocationId = record.LocationId,
                QuarterPlannedForVisitId = record.QuarterPlannedForVisitId,
                VisitTypeId = record.VisitTypeId,
                PlantNameId = record.PlantNameId,
                ModifiedOn = record.ModifiedOn,

                CreatedOn = record.CreatedOn,
                ScheduledDate = record.ScheduledDate,
                VisitDate = record.VisitDate,
                CancelledAt = record.CancelledAt,
                CancellationReason = record.CancellationReason,
                RescheduleReason = record.RescheduleReason,
                DesignedCapacity = record.DesignedCapacity,
                VisitStatusId = record.VisitStatusId,
                LocationName = record.LocationVisit,

                ComplianceVisitSpecialists = record.ComplianceVisitSpecialists != null ? record.ComplianceVisitSpecialists.Select(s => new ComplianceVisitSpecialistModel()
                {
                    Id = s.Id,
                    ComplianceDetailsId = s.ComplianceDetailsId,
                    SpecialistUserId = s.SpecialistUserId,
                    MobileNumber = s.MobileNumber,
                    SpecialistUserEmail = s.SpecialistUserEmail,
                    SpecialistUserName = s.SpecialistUserName,
                    CreatedOn = s.CreatedOn,
                }).ToList() : null,

                VisitStatusHistory = record.VisitStatusHistory.Select(a => new VisitStatusHistory
                {
                    Id = a.Id,
                    ActionAt = a.ActionAt,
                    ActionByUserId = a.ActionByUserId,
                    ActionReason = a.ActionReason,
                    ComplianceDetailsId = a.ComplianceDetailsId,
                    NewStatus = a.NewStatus,
                    OldStatus = a.OldStatus,
                    RequestedNewDate = a.RequestedNewDate
                }).ToList(),


            }).ToListAsync();


        var visitsIds = visits.Select(s => s.Id).ToList();
        var visitDocuments = await dbContext.Attachments.Where(s => s.EntityName == AttachmentEntityEnum.VisitAttachment && visitsIds.Contains(s.EntityId) && s.AttachmentTypeId == (long)AttachmentTypeEnum.VisitAttachment).Select(a => new AttachmentDto()
        {
            AttachmentId = a.Id,
            EntityId = a.EntityId,
            AttachmentGuid = a.AttachmentGuid,
            AttachmentName = a.AttachmentName,
            EntityName = a.EntityName,
            AttachmentType = (AttachmentTypeEnum)a.AttachmentTypeId,
        }).ToListAsync();

        foreach (var visit in visits)
        {
            visit.VisitDocuments = visitDocuments.Where(s => s.EntityId == visit.Id).ToList();
            if (currentLanguageService.Language == LanguageEnum.En)
            {
                visit.ActivityName = lookupDictEn.TryGetValue(visit.ActivityId, out var an) ? an : "";
                visit.LocationName = lookupDictEn.TryGetValue(visit.LocationId ?? 0, out var ln) ? ln : "";
                visit.LicensedEntityName = lookupDictEn.TryGetValue(visit.LicensedEntityId, out var le) ? le : "";
                visit.QuarterPlannedForVisitName = lookupDictEn.TryGetValue(visit.QuarterPlannedForVisitId ?? 0, out var qn) ? qn : "";
                visit.VisitTypeName = lookupDictEn.TryGetValue(visit.VisitTypeId, out var vt) ? vt : "";
                visit.VisitStatusName = lookupDictEn.TryGetValue(visit.VisitStatusId ?? 0, out var vsn) ? vsn : "";
            }
            else
            {
                visit.ActivityName = lookupDictAr.TryGetValue(visit.ActivityId, out var an) ? an : "";
                visit.LocationName = lookupDictAr.TryGetValue(visit.LocationId ?? 0, out var ln) ? ln : "";
                visit.LicensedEntityName = lookupDictAr.TryGetValue(visit.LicensedEntityId, out var le) ? le : "";
                visit.QuarterPlannedForVisitName = lookupDictAr.TryGetValue(visit.QuarterPlannedForVisitId ?? 0, out var qn) ? qn : "";
                visit.VisitTypeName = lookupDictAr.TryGetValue(visit.VisitTypeId, out var vt) ? vt : "";
                visit.VisitStatusName = lookupDictAr.TryGetValue(visit.VisitStatusId ?? 0, out var vsn) ? vsn : "";
            }
        }
        if (visits == null) throw new NotFoundException("Compliance Visits", "Not found");
        else
            return ResponseResult<List<ComplianceDetailsDto>>.Success(visits);
    }
    public async Task<ResponseResult<DocumentExtensionRequestDto>>? AddExtensionRequest(ExtensionRequestModel request)
    {
        var _Visit = await dbContext.ComplianceDetails.FindAsync(request.ComplianceDetailsID);
        DocumentExtensionRequestDto? requestDto = null;
        if (currentUserService.User.Role.Any(a => a.Contains(RoleEnum.LicensedEntity)))
        {
            if (_Visit != null)
            {
                var _obj = new DocumentExtensionRequest
                {
                    Id = Guid.NewGuid(),
                    LicensedEntityId = _Visit.LicensedEntityId,

                    ComplianceDetailsID = _Visit.Id,
                    RequestedDays = request.RequestedDays,
                    Reason = request.Reason,
                    ExtensionStatus = (int?)ExtensionStatusEnum.Pending,

                    CreatedByEmail = currentUserService.User.UserEmail,
                    CreatedByID = currentUserService.User.UserId,
                    CreatedByUserName = currentUserService.User.UserName,
                    CreatedOn = DateTime.UtcNow,
                };

                await dbContext.DocumentExtensionRequest.AddAsync(_obj);
                await dbContext.SaveChangesAsync();

                requestDto = new DocumentExtensionRequestDto
                {
                    Id = _obj.Id,
                    LicensedEntityId = _obj.LicensedEntityId,
                    ComplianceDetailsID = _obj.ComplianceDetailsID,
                    RequestedDays = _obj.RequestedDays,

                    ExtensionStatus = ExtensionStatusMapper.ToFriendlyString(_obj.ExtensionStatus, currentLanguageService),
                    ReviewedAt = _obj.ReviewedAt,
                    Reason = _obj.Reason,

                    DecisionReason = _obj.DecisionReason,
                    FinalDays = _obj.FinalDays,

                    CreatedByEmail = _obj.CreatedByEmail,
                    CreatedByID = _obj.CreatedByID,
                    CreatedByUserName = _obj.CreatedByUserName,
                    CreatedOn = _obj.CreatedOn.ToShortDateString(),
                };
                var Message = $"لقد تم تقديم طلبك لتمديد {requestDto.RequestedDays} يوما و هو الأن في إنتظار المراجعة. سيتم إخطارك بالقرار قريباً.";
                return ResponseResult<DocumentExtensionRequestDto>.Success(requestDto);
            }
            return ResponseResult<DocumentExtensionRequestDto>.Success(requestDto);
        }
        throw new ValidationException([new KeyValuePair<string, string>("Unauthoried User", "Unauthoried User")]);
    }
    public async Task<ResponseResult<DocumentExtensionRequestDto>> GetExtensionRequest(Guid id)
    {
        var _Request = await dbContext.DocumentExtensionRequest.FindAsync(id);
        var categoryLookupValue = await dbContext.LookupValue.ToListAsync();

        DocumentExtensionRequestDto? RequestDto = null;
        if (_Request != null)
        {
            RequestDto = new DocumentExtensionRequestDto
            {
                Id = _Request.Id,
                LicensedEntityId = _Request.LicensedEntityId,
                LicensedEntityName = (currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == _Request.LicensedEntityId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == _Request.LicensedEntityId)?.ValueAr) ?? null,

                ComplianceDetailsID = _Request.ComplianceDetailsID,
                RequestedDays = _Request.RequestedDays,

                ExtensionStatus = ExtensionStatusMapper.ToFriendlyString(_Request.ExtensionStatus, currentLanguageService),
                ReviewedAt = _Request.ReviewedAt,
                Reason = _Request.Reason,

                DecisionReason = _Request.DecisionReason,
                FinalDays = _Request.FinalDays,

                CreatedByEmail = _Request.CreatedByEmail,
                CreatedByID = _Request.CreatedByID,
                CreatedByUserName = _Request.CreatedByUserName,
                CreatedOn = _Request.CreatedOn.ToShortDateString(),
                Status = _Request.ExtensionStatus,

                ExtensionStatusHistory = _Request?.StatusHistories?.Select(a => new ExtensionStatusHistoryDto
                {
                    Id = a.Id,
                    RequestId = a.RequestId,
                    ActionAt = a.ActionAt,
                    ActionReason = a.ActionReason,
                    ActionByUserName = a.ActionByUserId.ToString(),
                    NewFinalDays = a.NewFinalDays,
                    NewStatus = a.NewStatus,
                    OldStatus = a.OldStatus
                }).ToList(),
            };
            return ResponseResult<DocumentExtensionRequestDto>.Success(RequestDto);
        }
        return ResponseResult<DocumentExtensionRequestDto>.Success(RequestDto);
    }
    public async Task<ResponseResult<List<DocumentExtensionRequestDto>>> ExtensionRequests()
    {
        var categoryLookupValue = await dbContext.LookupValue.ToListAsync();

        var _Request = await dbContext.DocumentExtensionRequest.Where(a => a.ExtensionStatus.Equals(1))
        .Select(item => new DocumentExtensionRequestDto
        {
            Id = item.Id,
            LicensedEntityId = item.LicensedEntityId,
            //LicensedEntityName = (currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.Where(a => a.Id == item.LicensedEntityId).FirstOrDefault().ValueEn : categoryLookupValue.Where(a => a.Id == item.LicensedEntityId).FirstOrDefault().ValueAr),

            ComplianceDetailsID = item.ComplianceDetailsID,
            RequestedDays = item.RequestedDays,

            ExtensionStatus = ExtensionStatusMapper.ToFriendlyString(item.ExtensionStatus, currentLanguageService),
            ReviewedAt = item.ReviewedAt,
            Reason = item.Reason,

            DecisionReason = item.DecisionReason,
            FinalDays = item.FinalDays,

            CreatedByEmail = item.CreatedByEmail,
            CreatedByID = item.CreatedByID,
            CreatedByUserName = item.CreatedByUserName,
            CreatedOn = item.CreatedOn.ToShortDateString(),

            ExtensionStatusHistory = item.StatusHistories.Select(a => new ExtensionStatusHistoryDto
            {
                Id = a.Id,
                RequestId = a.RequestId,
                ActionAt = a.ActionAt,
                ActionReason = a.ActionReason,
                ActionByUserName = a.ActionByUserId.ToString(),
                NewFinalDays = a.NewFinalDays,
                NewStatus = a.NewStatus,
                OldStatus = a.OldStatus
            }).ToList(),
        }).ToListAsync();
        return ResponseResult<List<DocumentExtensionRequestDto>>.Success(_Request);
    }
    public async Task<ResponseResult<List<DocumentExtensionRequestDto>>> GetExtensionRequestByEntityId(long LicensedEntityId)
    {
        var _Request = await dbContext.DocumentExtensionRequest.Where(a => a.LicensedEntityId == LicensedEntityId).ToListAsync();
        List<DocumentExtensionRequestDto> RequestDto = [];

        if (_Request != null)
        {
            foreach (var item in _Request)
            {
                RequestDto.Add(new DocumentExtensionRequestDto
                {
                    Id = item.Id,
                    LicensedEntityId = item.LicensedEntityId,
                    ComplianceDetailsID = item.ComplianceDetailsID,
                    RequestedDays = item.RequestedDays,
                    Reason = item.Reason,
                    
                    ExtensionStatus = ExtensionStatusMapper.ToFriendlyString(item.ExtensionStatus, currentLanguageService),
                    ReviewedAt = item.ReviewedAt,
                    DecisionReason = item.DecisionReason,
                    FinalDays = item.FinalDays,

                    CreatedByEmail = item.CreatedByEmail,
                    CreatedByID = item.CreatedByID,
                    CreatedByUserName = item.CreatedByUserName,
                    CreatedOn = item.CreatedOn.ToShortDateString(),
                });
            }
            return ResponseResult<List<DocumentExtensionRequestDto>>.Success(RequestDto);
        }
        return ResponseResult<List<DocumentExtensionRequestDto>>.Success(RequestDto);
    }
    public async Task<ResponseResult<DocumentExtensionReviewDto>> UpdateExtensionRequest(DocumentExtensionReviewDto dto)
    {
        if (currentUserService.User.Role.Any(a => a.Contains(RoleEnum.ComplianceManager) || a.Contains(RoleEnum.ComplianceSpecialist)))
        {
            if (dto != null)
            {
                var request = await GetExtensionRequest(dto.RequestId);
                var VisitID = request?.Model?.ComplianceDetailsID;

                if (request == null)
                    throw new BadRequestException("Request not found.");

                var oldStatus = request?.Model?.Status;
                var newStatus = dto.NewStatus;

                // Business rules
                if (newStatus == 3 && string.IsNullOrWhiteSpace(dto.ActionReason))
                    throw new Exception("Reason is required for rejection.");

                if (newStatus == 4 && (dto.NewFinalDays == null))
                    throw new Exception("Modified must provide new days.");

                if (newStatus == 2 && dto.NewFinalDays == null)
                {
                    bool isTenDays = await IsTotalFinalDaysForVisitEqualTo(VisitID, 10);
                    if (isTenDays)
                    {
                        throw new Exception("The sum of approved FinalDays for this visit is exactly 10");
                    }
                    dto.NewFinalDays = request?.Model?.RequestedDays;

                    // update visit date 
                    var visit = await dbContext.ComplianceDetails.FindAsync(VisitID);
                    visit.VisitDate = visit?.VisitDate?.AddDays(dto.NewFinalDays.Value);
                }

                // Update main request

                var MainRequest = await dbContext.DocumentExtensionRequest.FindAsync(dto.RequestId);

                if (MainRequest != null)
                {
                    MainRequest.ExtensionStatus = newStatus;
                    MainRequest.ReviewedAt = DateTime.UtcNow;
                    MainRequest.DecisionReason = dto.ActionReason;
                    MainRequest.FinalDays = dto.NewFinalDays;
                    MainRequest.Reason = dto.ActionReason;
                }

                // Track history
                var history = new ExtensionStatusHistory
                {
                    RequestId = request.Model.Id,
                    //ActionByUserId = Guid.Parse(currentUserService.User.UserId),
                    ActionAt = DateTime.UtcNow,
                    OldStatus = oldStatus,
                    NewStatus = newStatus,
                    ActionReason = dto.ActionReason,
                    NewFinalDays = dto.NewFinalDays
                };
                await dbContext.ExtensionStatusHistories.AddAsync(history);
                await dbContext.SaveChangesAsync();

                dto.FinalStatus = MainRequest?.ExtensionStatus;
                dto.RequestId = MainRequest.Id;

                return ResponseResult<DocumentExtensionReviewDto>.Success(dto);
            }
            return ResponseResult<DocumentExtensionReviewDto>.Success(dto);
        }
        throw new ValidationException([new KeyValuePair<string, string>("Unauthoried User", "Unauthoried User")]);
    }
    public async Task<ResponseResult<List<ExtensionStatusHistoryDto>>> GetExtensionRequestHistory(Guid RequestId)
    {
        var _Request = await dbContext.DocumentExtensionRequest.FindAsync(RequestId);
        List<ExtensionStatusHistoryDto>? _Hestories = null;

        if (_Request != null)
        {
            var res = await dbContext.ExtensionStatusHistories.Where(a => a.RequestId == RequestId).ToListAsync();
            _Hestories = res?.Select(a => new ExtensionStatusHistoryDto
            {
                Id = a.Id,
                RequestId = a.RequestId,
                ActionAt = a.ActionAt,
                ActionReason = a.ActionReason,
                ActionByUserName = a.ActionByUserId.ToString(),
                NewFinalDays = a.NewFinalDays,
                NewStatus = a.NewStatus,
                OldStatus = a.OldStatus
            }).ToList();
            return ResponseResult<List<ExtensionStatusHistoryDto>>.Success(_Hestories);
        }
        return ResponseResult<List<ExtensionStatusHistoryDto>>.Success(_Hestories);
    }
    public async Task<ResponseResult<bool>>? CancelVisitByManager(CancelVisitDto Dto)
    {
        if (currentUserService.User.Role.Any(a => a.Contains(RoleEnum.ComplianceManager)))
        {
            var visit = await dbContext.ComplianceDetails.FindAsync(Dto.ComplianceDetailsId) ?? throw new Exception("Visit not found.");

            if (visit.VisitStatusId == (int)VisitStatusEnum.Cancelled)
                return ResponseResult<bool>.Failure(["Visit already cancelled."], false);

            if (string.IsNullOrWhiteSpace(Dto.Reason))
                return ResponseResult<bool>.Failure(["Reason is required for cancellation."], false);

            var oldStatus = visit.VisitStatusId;

            visit.VisitStatusId = (int)VisitStatusEnum.Cancelled;
            visit.CancellationReason = Dto.Reason;
            visit.CancelledAt = DateTime.UtcNow;
            await dbContext.SaveChangesAsync();

            // Tracking
            var history = new VisitStatusHistory
            {
                ComplianceDetailsId = visit.Id,
                ActionByUserId = currentUserService.User.UserId,
                ActionAt = DateTime.UtcNow,
                OldStatus = oldStatus.ToString(),
                NewStatus = VisitStatusEnum.Cancelled.ToString(),
                ActionReason = Dto?.Reason,
            };

            await dbContext.VisitStatusHistories.AddAsync(history);
            await dbContext.SaveChangesAsync();

            string message = $"تم إلغاء الزيارة رقم {visit.Id}. السبب: {Dto.Reason}";
            var _res = GetComplianceVisit()?.Result.Model?.Where(a => a.Id == Dto.ComplianceDetailsId).FirstOrDefault();
            return ResponseResult<bool>.Success(true);
        }
        throw new ValidationException([new KeyValuePair<string, string>("Unauthoried User", "Unauthoried User")]);
    }
    public async Task<ResponseResult<SpecialistRescheduleDto>> SpecialistReschedule(RequestRescheduleDto rescheduleDto)
    {
        try
        {
            SpecialistRescheduleDto? _request = null;
            string message = "";
            if (currentUserService.User.Role.Any(a => a.Contains(RoleEnum.ComplianceManager) || a.Contains(RoleEnum.ComplianceSpecialist)))
            {
                var visit = await dbContext.ComplianceDetails.FindAsync(rescheduleDto.ComplianceDetailsID);

                if (visit == null)
                    return ResponseResult<SpecialistRescheduleDto>.Failure(["Visit not found."], new SpecialistRescheduleDto());

                if (visit.VisitStatusId == (int)VisitStatusEnum.Cancelled || visit.VisitStatusId == (int)VisitStatusEnum.Completed)
                    return ResponseResult<SpecialistRescheduleDto>.Failure(["Visit cannot be rescheduled."], new SpecialistRescheduleDto());

                if (visit.VisitStatusId == (int)VisitStatusEnum.Scheduled || visit.VisitStatusId == (int)VisitStatusEnum.Rescheduled)
                    return ResponseResult<SpecialistRescheduleDto>.Failure(["Cannot request reschedule at this stage."], new SpecialistRescheduleDto());

                var oldStatus = visit.VisitStatusId;

                visit.ScheduledDate = rescheduleDto.ProposedDate;
                visit.RescheduleReason = rescheduleDto.Reason;
                visit.ModifiedByID = currentUserService.User.UserId;
                visit.ModifiedByEmail = currentUserService.User.UserEmail;
                visit.ModifiedByUserName = currentUserService.User.UserName;
                visit.VisitDate = rescheduleDto.ProposedDate;
                visit.VisitStatusId = (int)VisitStatusEnum.Rescheduled;

                // Tracking
                var history = new VisitStatusHistory
                {
                    ComplianceDetailsId = visit.Id,
                    ActionByUserId = currentUserService.User.UserId,
                    ActionAt = DateTime.UtcNow,
                    OldStatus = oldStatus.ToString(),
                    NewStatus = VisitStatusEnum.Rescheduled.ToString(),
                    ActionReason = rescheduleDto?.Reason,
                    RequestedNewDate = rescheduleDto?.ProposedDate
                };

                await dbContext.VisitStatusHistories.AddAsync(history);
                await dbContext.SaveChangesAsync();

                _request.ComplianceDetailsID = visit.Id;
                _request.LicensedEntityId = visit.LicensedEntityId;
                _request.OldStatus = oldStatus.ToString();
                _request.NewStatus = VisitStatusMapper.ToFriendlyString((int?)visit.VisitStatusId, currentLanguageService);
                _request.RescheduleReason = visit?.RescheduleReason;

                message = $"تمت إعادة جدولة الزيارة رقم {visit.VisitReferenceNumber} من قبل إخصائي الإمتثال";
                return ResponseResult<SpecialistRescheduleDto>.Success(_request);
            }
            throw new ValidationException([new KeyValuePair<string, string>("Unauthoried User", "Unauthoried User")]);
        }
        catch
        {
            return ResponseResult<SpecialistRescheduleDto>.Failure(["Cannot request reschedule at this stage."], new SpecialistRescheduleDto());
        }

    }
    public async Task<ResponseResult<RequestRescheduleDto>>? RequestReschedule(RequestRescheduleDto rescheduleDto)
    {
        try
        {

            RequestRescheduleDto? _request = null;
            string message = "";

            if (currentUserService.User.Role.Contains(RoleEnum.LicensedEntity))
            {
                var visit = await dbContext.ComplianceDetails.FindAsync(rescheduleDto.ComplianceDetailsID);
                if (visit == null)
                    return ResponseResult<RequestRescheduleDto>.Failure(["Visit not found."], new RequestRescheduleDto());

                if (visit.VisitStatusId == (int)VisitStatusEnum.Cancelled || visit.VisitStatusId == (int)VisitStatusEnum.Completed)
                    return ResponseResult<RequestRescheduleDto>.Failure(["Visit cannot be rescheduled."], new RequestRescheduleDto());

                //if (visit.VisitStatusId == (int)VisitStatusEnum.Scheduled || visit.VisitStatusId == (int)VisitStatusEnum.Rescheduled)
                //    return ResponseResult<RequestRescheduleDto>.Failure(["Cannot request reschedule at this stage."], new RequestRescheduleDto());

                var oldStatus = visit.VisitStatusId;

                var request = await dbContext.RescheduleRequests.AddAsync(new RescheduleRequest
                {
                    Id = new int(),
                    ComplianceDetailsID = rescheduleDto.ComplianceDetailsID,
                    LicensedEntityId = long.Parse(currentUserService.User.UserId),
                    Reason = rescheduleDto.Reason,
                    RequestedAt = DateTime.UtcNow,
                    RequestedByUserId = currentUserService.User.UserId,
                    ProposedDate = rescheduleDto.ProposedDate,
                    Status = (int)ExtensionStatusEnum.Pending
                });
                visit.VisitStatusId = (int)VisitStatusEnum.RescheduleRequested;
                await dbContext.SaveChangesAsync();

                var REQUESTID = request.Entity.Id;
                message = $"تم تقديم طلب إعادة الجدولة للزيارة رقم {visit.VisitReferenceNumber} بنجاح و هو في إنتظار المراجعة";

                _request = GetRescheduleRequests(rescheduleDto?.LicensedEntityId)?.Result?.Model?.Where(a => a.Id == REQUESTID).FirstOrDefault() ?? new RequestRescheduleDto();

                return ResponseResult<RequestRescheduleDto>.Success(_request);
            }
            throw new ValidationException([new KeyValuePair<string, string>("Unauthoried User", "Unauthoried User")]);
        }
        catch
        {
            return ResponseResult<RequestRescheduleDto>.Failure(["Cannot request reschedule at this stage."], new RequestRescheduleDto());
        }
    }
    public async Task<ResponseResult<List<RequestRescheduleDto>>>? GetRescheduleRequests(long? LicensedID)
    {
        try
        {
            var _Request = await dbContext.RescheduleRequests.Where(a => a.LicensedEntityId == LicensedID)
           .Select(a => new RequestRescheduleDto
           {
               Id = a.Id,
               RequestedAt = a.RequestedAt,
               RequestedByUserId = a.RequestedByUserId ?? "",
               ReviewedAt = a.ReviewedAt,
               ReviewReason = a.ReviewReason,
               ProposedDate = a.ProposedDate,
               Reason = a.Reason,
               LicensedEntityId = a.LicensedEntityId,
               ComplianceDetailsID = a.ComplianceDetailsID,
               StatusID = a.Status,
               Status = ExtensionStatusMapper.ToFriendlyString(a.Status, currentLanguageService)
           }).ToListAsync()

           ?? throw new Exception("No Reschedule Requests Found ..");
            return ResponseResult<List<RequestRescheduleDto>>.Success(_Request);
        }
        catch
        {
            return ResponseResult<List<RequestRescheduleDto>>.Success(new List<RequestRescheduleDto>());
        }
    }
    public async Task<ResponseResult<RequestRescheduleDto>>? ReviewRescheduleAsync(ReviewRescheduleDto reviewRescheduleDto)
    {
        try
        {
            string message = "";
            var _rescheduleRequest = await dbContext.RescheduleRequests.FindAsync(reviewRescheduleDto.RequestId);

            var visit = await dbContext.ComplianceDetails.FindAsync(reviewRescheduleDto.ComplianceDetailsID)
            ??
            throw new Exception("Visit not found.");
            var oldStatus = visit.VisitStatusId;

            if (currentUserService.User.Role.Contains(RoleEnum.ComplianceSpecialist) || currentUserService.User.Role.Contains(RoleEnum.ComplianceManager))
            {
                if (reviewRescheduleDto.Approve)
                {
                    visit.ScheduledDate = _rescheduleRequest.ProposedDate;
                    visit.VisitStatusId = (int)VisitStatusEnum.Rescheduled;
                    visit.VisitDate = _rescheduleRequest.ProposedDate;
                    visit.RescheduleReason = _rescheduleRequest?.Reason;
                    visit.ModifiedByID = currentUserService.User.UserId;
                    visit.ModifiedByEmail = currentUserService.User.UserEmail;
                    visit.ModifiedByUserName = currentUserService.User.UserName;

                    _rescheduleRequest.Status = (int)ExtensionStatusEnum.Approved;
                    _rescheduleRequest.ReviewReason = reviewRescheduleDto?.Reason;
                    _rescheduleRequest.ReviewedAt = DateTime.UtcNow;
                    _rescheduleRequest.ReviewedByUserId = currentUserService.User.UserId;

                    await dbContext.SaveChangesAsync();
                    message = $"تمت الموافقة مع تعديل التاريخ, على إعادة جدولة الزيارة، والتاريخ الجديد هو {reviewRescheduleDto.NewProposedDate:yyyy-MM-dd}.";
                }
                else if (reviewRescheduleDto.ApprovalWithEdit)
                {
                    if (string.IsNullOrWhiteSpace(reviewRescheduleDto.Reason))
                        throw new Exception("Reason is required for Edit Request.");

                    visit.ScheduledDate = reviewRescheduleDto.NewProposedDate;
                    visit.Status = (int)VisitStatusEnum.Rescheduled;
                    visit.VisitDate = reviewRescheduleDto.NewProposedDate;
                    visit.RescheduleReason = reviewRescheduleDto.Reason;
                    visit.ModifiedByID = currentUserService.User.UserId;
                    visit.ModifiedByEmail = currentUserService.User.UserEmail;
                    visit.ModifiedByUserName = currentUserService.User.UserName;

                    _rescheduleRequest.Status = (int)ExtensionStatusEnum.Approved;
                    _rescheduleRequest.ReviewReason = reviewRescheduleDto?.Reason;
                    _rescheduleRequest.ReviewedAt = DateTime.UtcNow;
                    _rescheduleRequest.ReviewedByUserId = currentUserService.User.UserId;

                    await dbContext.SaveChangesAsync();
                    message = $"تمت الموافقة على إعادة جدولة الزيارة، والتاريخ الجديد هو {reviewRescheduleDto.NewProposedDate:yyyy-MM-dd}.";
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(reviewRescheduleDto.Reason))
                        throw new Exception("Reason is required for rejection.");

                    visit.VisitStatusId = (int)VisitStatusEnum.Scheduled;
                    visit.ModifiedByID = currentUserService.User.UserId;
                    visit.ModifiedByEmail = currentUserService.User.UserEmail;
                    visit.ModifiedByUserName = currentUserService.User.UserName;

                    _rescheduleRequest.Status = (int)ExtensionStatusEnum.Rejected;
                    _rescheduleRequest.ReviewReason = reviewRescheduleDto?.Reason;
                    _rescheduleRequest.ReviewedAt = DateTime.UtcNow;
                    _rescheduleRequest.ReviewedByUserId = currentUserService.User.UserId;

                    await dbContext.SaveChangesAsync();
                    message = $"تم رفض طلب إعادة جدولة الزيارة. السبب : {reviewRescheduleDto?.Reason}";
                }

                // Tracking
                var history = new VisitStatusHistory
                {
                    ComplianceDetailsId = visit.Id,
                    ActionByUserId = currentUserService.User.UserId,
                    ActionAt = DateTime.UtcNow,
                    OldStatus = oldStatus.ToString(),
                    NewStatus = VisitStatusEnum.Rescheduled.ToString(),
                    ActionReason = reviewRescheduleDto.Approve ? "تمت الموافقة على إعادة الجدولة" : reviewRescheduleDto?.Reason,
                    RequestedNewDate = reviewRescheduleDto.Approve ? visit.ScheduledDate : null
                };

                await dbContext.VisitStatusHistories.AddAsync(history);
                await dbContext.SaveChangesAsync();

                var res = GetRescheduleRequests(_rescheduleRequest.LicensedEntityId)?.Result.Model?.Where(a => a.Id == _rescheduleRequest.Id).FirstOrDefault();
                return ResponseResult<RequestRescheduleDto>.Success(res);
            }
            throw new ValidationException(new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Unauthoried User", "Unauthoried User") });
        }
        catch
        {
            return ResponseResult<RequestRescheduleDto>.Success(new RequestRescheduleDto());
        }
    }
    public async Task<ResponseResult<ComplianceDetailsDto>>? UpdateVisitStatus(UpdateVisitStatusDto statusDto)
    {
        try
        {
            if (currentUserService.User.Role.Any(a => a.Contains(RoleEnum.ComplianceSpecialist)))
            {
                var visit = await dbContext.ComplianceDetails.FindAsync(statusDto.ComplianceDetailsID);

                if (visit == null)
                    return ResponseResult<ComplianceDetailsDto>.Failure(["Visit not found."], new ComplianceDetailsDto());
                var oldStatus = visit?.VisitStatusId;

                if (oldStatus == (int)VisitStatusEnum.Completed || oldStatus == (int)VisitStatusEnum.Cancelled)
                    return ResponseResult<ComplianceDetailsDto>.Failure(["Visit cannot be updated."], new ComplianceDetailsDto());

                visit.VisitStatusId = statusDto.NewStatus;
                visit.UpdatedReason = statusDto.Note;
                visit.ModifiedByID = currentUserService.User.UserId;
                visit.ModifiedByEmail = currentUserService.User.UserEmail;
                visit.ModifiedByUserName = currentUserService.User.UserName;
                visit.ModifiedOn = DateTime.UtcNow;

                // Tracking
                var history = new VisitStatusHistory
                {
                    ComplianceDetailsId = visit.Id,
                    ActionByUserId = currentUserService.User.UserId,
                    ActionAt = DateTime.UtcNow,
                    OldStatus = oldStatus.ToString(),
                    NewStatus = visit.VisitStatusId.ToString(),
                    ActionReason = statusDto.Note
                };

                await dbContext.VisitStatusHistories.AddAsync(history);
                await dbContext.SaveChangesAsync();

                var res = GetComplianceVisit()?.Result.Model?.Where(a => a.Id == statusDto.ComplianceDetailsID).FirstOrDefault();
                return ResponseResult<ComplianceDetailsDto>.Success(res);
            }
            throw new ValidationException([new KeyValuePair<string, string>("Unauthoried User", "Unauthoried User")]);
        }
        catch
        {
            return ResponseResult<ComplianceDetailsDto>.Success(new ComplianceDetailsDto());
        }
    }
    public async Task<bool> IsTotalFinalDaysForVisitEqualTo(Guid? complianceDetailsId, int expectedTotal)
    {
        var totalFinalDays = await dbContext.DocumentExtensionRequest
            .Where(r => r.ComplianceDetailsID == complianceDetailsId && r.ExtensionStatus == 2 && r.FinalDays.HasValue)
            .SumAsync(r => r.FinalDays.Value);

        return totalFinalDays == expectedTotal;
    }
    #endregion

    #region Figma part 2 unmerged
    public async Task<ResponseResult<ComplianceDisclosureReportDto>> GetVisitDisclosureReportForComplianceManager(Guid visitId)
    {
        var visit = await dbContext.ComplianceDetails.FirstOrDefaultAsync(v => v.Id == visitId);
        var visitSpecialists = await dbContext.ComplianceVisitSpecialist.Include(s => s.ComplianceVisitDisclosure).Where(s => s.ComplianceDetailsId.Equals(visitId) && (s.IsDeleted == false || s.IsDeleted == null)).ToListAsync();
        var categoryLookupValue = await dbContext.LookupValue.ToListAsync();

        if (visit != null && visitSpecialists != null && visitSpecialists?.Count() > 0)
        {
            ComplianceDisclosureReportDto result = new ComplianceDisclosureReportDto();
            result.ComplianceDetailId = visit.Id;
            result.LocationId = visit.LocationId;
            result.VisitTypeId = visit.VisitTypeId;
            result.ActivityId = visit.ActivityId;

            result.LocationName = (currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == visit.LocationId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == visit.LocationId)?.ValueAr) ?? null;
            result.VisitTypeName = (currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == visit.VisitTypeId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == visit.VisitTypeId)?.ValueAr) ?? null;
            result.ActivityName = (currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == visit.ActivityId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == visit.ActivityId)?.ValueAr) ?? null;
            result.ComplianceVisitSpecialists = [];

            foreach (var specialist in visitSpecialists)
            {
                ComplianceVisitSpecialistModel specialistModel = new()
                {
                    Id = specialist.Id,
                    SpecialistUserName = specialist.SpecialistUserName,
                    SpecialistUserId = specialist.SpecialistUserId,
                    MobileNumber = specialist.MobileNumber,
                    ComplianceDetailsId = specialist.ComplianceDetailsId,
                    CreatedOn = specialist.CreatedOn,
                    SpecialistUserEmail = specialist.SpecialistUserEmail,

                    ComplianceVisitDisclosure = specialist.ComplianceVisitDisclosure != null ? new ComplianceVisitDisclosureModel()
                    {
                        Id = specialist.ComplianceVisitDisclosure.Id,
                        HasConflicts = specialist.ComplianceVisitDisclosure.HasConflicts,
                        SubmissionStatus = specialist.ComplianceVisitDisclosure != null ? "Submitted" : "Pending",
                    } :
                    new ComplianceVisitDisclosureModel()
                    {
                        SubmissionStatus = specialist.ComplianceVisitDisclosure != null ? "Submitted" : "Pending"
                    },
                    IsSubmitted = specialist.ComplianceVisitDisclosure != null ? true : false
                };

                result.ComplianceVisitSpecialists.Add(specialistModel);
            }

            return ResponseResult<ComplianceDisclosureReportDto>.Success(result);
        }
        return null;
    }
    public async Task<ResponseResult<ComplianceVisitDisclosureDto>> GetVisitDisclosureFormForComplianceManager(Guid visitId, string visitSpecialistId)
    {
        var visit = await dbContext.ComplianceDetails.FirstOrDefaultAsync(v => v.Id.Equals(visitId));
        var questions = await dbContext.VisitSurveyQuestion.ToListAsync();
        var visitSpecialist = await dbContext.ComplianceVisitSpecialist
            .FirstOrDefaultAsync(s => s.ComplianceDetailsId.Equals(visitId)
        && s.SpecialistUserId.Equals(visitSpecialistId) && s.IsDeleted == false || s.IsDeleted == null);


        // Parse visitSpecialistId 
        var Spec = Guid.Parse(visitSpecialistId);

        var submittedDisclosure = await dbContext.ComplianceVisitDisclosure.Where(d => d.ComplianceVisitSpecialistId == Spec).FirstOrDefaultAsync();
        var submittedAnswers = await dbContext.VisitSurveyAnswer.Where(a => a.ComplianceVisitSpecialistId.Equals(Spec)).ToListAsync();
        var categoryLookupValue = await dbContext.LookupValue.ToListAsync();

        if (visit != null && visitSpecialist != null && submittedDisclosure != null
            && questions != null && questions?.Count > 0
            && submittedAnswers != null && submittedAnswers?.Count > 0)
        {
            ComplianceVisitDisclosureDto result = new();
            result.ComplianceDetailId = visit.Id;
            result.LocationId = visit.LocationId;
            result.LocationName = (currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == visit.LocationId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == visit.LocationId)?.ValueAr) ?? null;
            result.LicensedEntityId = visit.LicensedEntityId;
            result.LicenseEntityName = (currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == visit.LicensedEntityId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == visit.LicensedEntityId)?.ValueAr) ?? null;
            result.ComplianceVisitSpecialistId = visitSpecialist.Id;
            result.SurveyNotes = submittedDisclosure.SurveyNotes;
            result.HasConflicts = submittedDisclosure.HasConflicts;

            result.VisitSurveyQuestions = new List<VisitSurveryQuestionModel>();
            foreach (var question in questions)
            {
                VisitSurveryQuestionModel questionModel = new VisitSurveryQuestionModel()
                {
                    Id = question.Id,
                    QuestionAr = question.QuestionAr,
                    QuestionEn = question.QuestionEn,
                };

                result.VisitSurveyQuestions.Add(questionModel);
            }

            result.VisitSurveyAnswers = new List<VisitSurveyAnswerModel>();
            foreach (var answer in submittedAnswers)
            {
                VisitSurveyAnswerModel answerModel = new VisitSurveyAnswerModel()
                {
                    Id = answer.Id,
                    ComplianceVisitSpecialistId = answer.ComplianceVisitSpecialistId,
                    VisitSurveyQuestionId = answer.VisitSurveyQuestionId,
                    Answer = answer.Answer,
                    Reason = answer.Reason
                };

                result.VisitSurveyAnswers.Add(answerModel);
            }

            return ResponseResult<ComplianceVisitDisclosureDto>.Success(result);
        }
        return null;
    }
    public async Task<ResponseResult<ComplianceVisitDisclosureDto>> GetVisitDisclosureFormForLoggedInSpecialist(Guid visitId)
    {
        var visit = await dbContext.ComplianceDetails.FirstOrDefaultAsync(v => v.Id.Equals(visitId));
        var questions = await dbContext.VisitSurveyQuestion.ToListAsync();

        var loggedInVisitSpecialist = await dbContext.ComplianceVisitSpecialist
            .FirstOrDefaultAsync(s => s.ComplianceDetailsId.Equals(visitId)
            && s.SpecialistUserId.Equals(currentUserService.User.UserId)
            && (s.IsDeleted == false || s.IsDeleted == null));

        if (loggedInVisitSpecialist != null)
        {

            var submittedDisclosure = await dbContext.ComplianceVisitDisclosure.FirstOrDefaultAsync(d => d.ComplianceVisitSpecialistId.Equals(loggedInVisitSpecialist.Id));
            var submittedAnswers = await dbContext.VisitSurveyAnswer.Where(a => a.ComplianceVisitSpecialistId.Equals(loggedInVisitSpecialist.Id)).ToListAsync();
            var categoryLookupValue = await dbContext.LookupValue.ToListAsync();

            if (visit != null && loggedInVisitSpecialist != null && questions != null && questions?.Count > 0)
            {
                ComplianceVisitDisclosureDto result = new ComplianceVisitDisclosureDto();
                result.ComplianceDetailId = visit.Id;
                result.LocationId = visit.LocationId;
                result.LocationName = (currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == visit.LocationId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == visit.LocationId)?.ValueAr) ?? null;
                result.LicensedEntityId = visit.LicensedEntityId;
                result.LicenseEntityName = (currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == visit.LicensedEntityId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == visit.LicensedEntityId)?.ValueAr) ?? null;
                result.ComplianceVisitSpecialistId = loggedInVisitSpecialist.Id;
                result.SurveyNotes = submittedDisclosure != null ? submittedDisclosure.SurveyNotes : null;
                result.HasConflicts = submittedDisclosure != null ? submittedDisclosure.HasConflicts : null;
                result.VisitSurveyQuestions = new List<VisitSurveryQuestionModel>();
                foreach (var question in questions)
                {
                    VisitSurveryQuestionModel questionModel = new VisitSurveryQuestionModel()
                    {
                        Id = question.Id,
                        QuestionAr = question.QuestionAr,
                        QuestionEn = question.QuestionEn,
                    };

                    result.VisitSurveyQuestions.Add(questionModel);
                }
                if (submittedAnswers != null && submittedAnswers.Count() > 0)
                {
                    result.VisitSurveyAnswers = new List<VisitSurveyAnswerModel>();
                    foreach (var answer in submittedAnswers)
                    {
                        VisitSurveyAnswerModel answerModel = new VisitSurveyAnswerModel()
                        {
                            Id = answer.Id,
                            ComplianceVisitSpecialistId = answer.ComplianceVisitSpecialistId,
                            VisitSurveyQuestionId = answer.VisitSurveyQuestionId,
                            Answer = answer.Answer,
                            Reason = answer.Reason
                        };

                        result.VisitSurveyAnswers.Add(answerModel);
                    }
                }
                return ResponseResult<ComplianceVisitDisclosureDto>.Success(result);
            }
        }
        throw new ValidationException(new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Unauthoried User", "Unauthoried User") });
    }
    public async Task<ResponseResult<bool>> SaveVisitDisclosureForm(ComplianceVisitDisclosureDto model)
    {
        ComplianceVisitDisclosure? newDisclosure = null;
        List<VisitSurveyAnswer>? newAnswers = null;

        var visit = await dbContext.ComplianceDetails.FirstOrDefaultAsync(d => d.Id.Equals(model.ComplianceDetailId));

        var existingDisclosure = await dbContext.ComplianceVisitDisclosure.FirstOrDefaultAsync(d => d.ComplianceVisitSpecialistId.Equals(model.ComplianceVisitSpecialistId));
        var existingAnswers = await dbContext.VisitSurveyAnswer.Where(a => a.ComplianceVisitSpecialistId.Equals(model.ComplianceVisitSpecialistId)).ToListAsync();


        if (currentUserService.User.Role.Any(role => role.Equals(RoleEnum.ComplianceSpecialist)))
        {
            bool? IsConfilt = false;
            List<KeyValuePair<string, string>> detailsAr = [];
            List<KeyValuePair<string, string>> detailsEn = [];


            if (existingDisclosure != null && existingAnswers != null && existingAnswers.Count > 0)
            {
                if (existingDisclosure.SurveyNotes != model.SurveyNotes)
                {
                    detailsAr.Add(new KeyValuePair<string, string>("SurveyNotes", $"ملاحظات المسح الحالية: {model.SurveyNotes} , ملاحظات المسح السابق : {existingDisclosure.SurveyNotes}"));
                    detailsEn.Add(new KeyValuePair<string, string>("SurveyNotes", $"Current Survey Notes: {model.SurveyNotes} , Old Survey Notes : {existingDisclosure.SurveyNotes}"));
                }

                if (existingDisclosure.HasConflicts != model.HasConflicts)
                {
                    detailsAr.Add(new KeyValuePair<string, string>("HasConflicts", $"هل يوجد صراعات؟: {model.HasConflicts} , هل كان لديك صراعات؟ : {existingDisclosure.HasConflicts}"));
                    detailsEn.Add(new KeyValuePair<string, string>("HasConflicts", $"Has Conflicts? : {model.HasConflicts} , Had Conflicts? : {existingDisclosure.HasConflicts}"));
                }

                existingDisclosure.SurveyNotes = model.SurveyNotes ?? "";
                IsConfilt = (model?.VisitSurveyAnswers?.Any(a => a.Answer == true || !string.IsNullOrEmpty(a.Reason)));
                existingDisclosure.HasConflicts = (bool)IsConfilt;

                if (existingDisclosure.HasConflicts)
                {
                    detailsAr.Add(new KeyValuePair<string, string>("VisitReferenceNumber", $"رقم مرجع الزيارة: {visit.VisitReferenceNumber}"));
                    detailsEn.Add(new KeyValuePair<string, string>("VisitReferenceNumber", $"Visit Reference Number: {visit.VisitReferenceNumber}"));

                    detailsAr.Add(new KeyValuePair<string, string>("VisitStatus", $"حالة الزيارة الحالية: {(long)VisitStatusEnum.ConflictOfInterestDisclosure}, حالة الزيارة القديمة: {visit.VisitStatusId}"));
                    detailsEn.Add(new KeyValuePair<string, string>("VisitStatus", $"Current Visit Status: {(long)VisitStatusEnum.ConflictOfInterestDisclosure}, Old Visit Status: {visit.VisitStatusId}"));

                    visit.VisitStatusId = (long)VisitStatusEnum.ConflictOfInterestDisclosure;
                }
                else
                {
                    visit.VisitStatusId = (long)VisitStatusEnum.Scheduled;
                }
                if (existingAnswers != null && existingAnswers.Count > 0)
                {
                    foreach (var answer in existingAnswers)
                    {
                        var modelAnswerValue = model.VisitSurveyAnswers?.FirstOrDefault(ma => ma.VisitSurveyQuestionId.Equals(answer.VisitSurveyQuestionId))?.Answer ?? false;
                        var modelReasonValue = model.VisitSurveyAnswers?.FirstOrDefault(ma => ma.VisitSurveyQuestionId.Equals(answer.VisitSurveyQuestionId))?.Reason;


                        detailsAr.Add(new KeyValuePair<string, string>("ComplianceVisitSpecialistId", $"زيارة معرف المتخصص: {answer.ComplianceVisitSpecialistId}"));
                        detailsEn.Add(new KeyValuePair<string, string>("ComplianceVisitSpecialistId", $"Visit Specialist Id: {answer.ComplianceVisitSpecialistId}"));

                        detailsAr.Add(new KeyValuePair<string, string>("VisitSurveyQuestionId", $"معرف السؤال: {answer.VisitSurveyQuestionId}"));
                        detailsEn.Add(new KeyValuePair<string, string>("VisitSurveyQuestionId", $"Question Id: {answer.VisitSurveyQuestionId}"));

                        detailsAr.Add(new KeyValuePair<string, string>("Answer", $"الإجابة الحالي: {modelAnswerValue}, الإجابة السابق: {answer.Answer}"));
                        detailsEn.Add(new KeyValuePair<string, string>("Answer", $"Current Answer: {modelAnswerValue}, Old Answer: {answer.Answer}"));

                        detailsAr.Add(new KeyValuePair<string, string>("Reason", $"السبب الحالي: {modelReasonValue}, : السبب السابق {answer.Reason}"));
                        detailsEn.Add(new KeyValuePair<string, string>("Reason", $"Current Reason : {modelReasonValue}, Old Reason : {answer.Reason}"));


                        answer.Answer = modelAnswerValue;
                        answer.Reason = modelReasonValue;

                    }
                }
            }
            else
            {
                if (existingDisclosure == null)
                {
                    newDisclosure = new ComplianceVisitDisclosure()
                    {
                        Id = Guid.NewGuid(),
                        ComplianceVisitSpecialistId = model.ComplianceVisitSpecialistId,
                        SurveyNotes = model.SurveyNotes,
                    };

                    IsConfilt = model?.VisitSurveyAnswers?.Any(a => a.Answer == true || !string.IsNullOrEmpty(a.Reason) || a.Reason != "");
                    newDisclosure.HasConflicts = (bool)IsConfilt;

                    detailsAr.Add(new KeyValuePair<string, string>("ComplianceVisitSpecialistId", $"زيارة معرف المتخصص: {model.ComplianceVisitSpecialistId}"));
                    detailsEn.Add(new KeyValuePair<string, string>("ComplianceVisitSpecialistId", $"Visit Specialist Id: {model.ComplianceVisitSpecialistId}"));

                    detailsAr.Add(new KeyValuePair<string, string>("SurveyNotes", $"ملاحظات المسح الحالية: {model.SurveyNotes}"));
                    detailsEn.Add(new KeyValuePair<string, string>("SurveyNotes", $"Current Survey Notes: {model.SurveyNotes}"));

                    detailsAr.Add(new KeyValuePair<string, string>("HasConflicts", $"هل يوجد صراعات؟: {newDisclosure.HasConflicts}"));
                    detailsEn.Add(new KeyValuePair<string, string>("HasConflicts", $"Has Conflicts? : {newDisclosure.HasConflicts}"));

                    if (newDisclosure.HasConflicts)
                    {
                        detailsAr.Add(new KeyValuePair<string, string>("VisitReferenceNumber", $"رقم مرجع الزيارة: {visit.VisitReferenceNumber}"));
                        detailsEn.Add(new KeyValuePair<string, string>("VisitReferenceNumber", $"Visit Reference Number: {visit.VisitReferenceNumber}"));

                        detailsAr.Add(new KeyValuePair<string, string>("VisitStatus", $"حالة الزيارة الحالية: {(long)VisitStatusEnum.ConflictOfInterestDisclosure}, حالة الزيارة القديمة: {visit.VisitStatusId}"));
                        detailsEn.Add(new KeyValuePair<string, string>("VisitStatus", $"Current Visit Status: {(long)VisitStatusEnum.ConflictOfInterestDisclosure}, Old Visit Status: {visit.VisitStatusId}"));

                        visit.VisitStatusId = (long)VisitStatusEnum.ConflictOfInterestDisclosure;
                    }
                    else
                    {
                        visit.VisitStatusId = (long)VisitStatusEnum.Scheduled;
                    }

                    newAnswers = [];
                    foreach (var modelAnswer in model.VisitSurveyAnswers)
                    {
                        var newAnswer = new VisitSurveyAnswer()
                        {
                            Id = Guid.NewGuid(),
                            ComplianceVisitSpecialistId = model.ComplianceVisitSpecialistId,
                            VisitSurveyQuestionId = modelAnswer.VisitSurveyQuestionId,
                            Answer = modelAnswer.Answer,
                            Reason = modelAnswer.Reason,
                        };
                        newAnswers.Add(newAnswer);

                        detailsAr.Add(new KeyValuePair<string, string>("ComplianceVisitSpecialistId", $"زيارة معرف المتخصص: {model.ComplianceVisitSpecialistId}"));
                        detailsEn.Add(new KeyValuePair<string, string>("ComplianceVisitSpecialistId", $"Visit Specialist Id: {model.ComplianceVisitSpecialistId}"));

                        detailsAr.Add(new KeyValuePair<string, string>("VisitSurveyQuestionId", $"معرف السؤال: {modelAnswer.VisitSurveyQuestionId}"));
                        detailsEn.Add(new KeyValuePair<string, string>("VisitSurveyQuestionId", $"Question Id: {modelAnswer.VisitSurveyQuestionId}"));

                        detailsAr.Add(new KeyValuePair<string, string>("Answer", $"الإجابة الحالية: {modelAnswer.Answer}"));
                        detailsEn.Add(new KeyValuePair<string, string>("Answer", $"Current Answer: {modelAnswer.Answer}"));

                        detailsAr.Add(new KeyValuePair<string, string>("Reason", $"السبب الحالي: {modelAnswer.Reason}"));
                        detailsEn.Add(new KeyValuePair<string, string>("Reason", $"Current Reason : {modelAnswer.Reason}"));

                    }

                    await dbContext.ComplianceVisitDisclosure.AddAsync(newDisclosure);
                    await dbContext.VisitSurveyAnswer.AddRangeAsync(newAnswers);
                }
                //newAnswers = [];
                //foreach (var modelAnswer in model.VisitSurveyAnswers)
                //{
                //    var newAnswer = new VisitSurveyAnswer()
                //    {
                //        Id = Guid.NewGuid(),
                //        ComplianceVisitSpecialistId = model.ComplianceVisitSpecialistId,
                //        VisitSurveyQuestionId = modelAnswer.VisitSurveyQuestionId,
                //        Answer = modelAnswer.Answer,
                //        Reason = modelAnswer.Reason,
                //    };
                //    newAnswers.Add(newAnswer);

                //    detailsAr.Add(new KeyValuePair<string, string>("ComplianceVisitSpecialistId", $"زيارة معرف المتخصص: {model.ComplianceVisitSpecialistId}"));
                //    detailsEn.Add(new KeyValuePair<string, string>("ComplianceVisitSpecialistId", $"Visit Specialist Id: {model.ComplianceVisitSpecialistId}"));

                //    detailsAr.Add(new KeyValuePair<string, string>("VisitSurveyQuestionId", $"معرف السؤال: {modelAnswer.VisitSurveyQuestionId}"));
                //    detailsEn.Add(new KeyValuePair<string, string>("VisitSurveyQuestionId", $"Question Id: {modelAnswer.VisitSurveyQuestionId}"));

                //    detailsAr.Add(new KeyValuePair<string, string>("Answer", $"الإجابة الحالية: {modelAnswer.Answer}"));
                //    detailsEn.Add(new KeyValuePair<string, string>("Answer", $"Current Answer: {modelAnswer.Answer}"));

                //    detailsAr.Add(new KeyValuePair<string, string>("Reason", $"السبب الحالي: {modelAnswer.Reason}"));
                //    detailsEn.Add(new KeyValuePair<string, string>("Reason", $"Current Reason : {modelAnswer.Reason}"));
                //}
                //await dbContext.VisitSurveyAnswer.AddRangeAsync(newAnswers);
            }

            ComplianceRequestActivity requestActivity = new ComplianceRequestActivity()
            {
                Id = Guid.NewGuid(),
                ComplianceRequestId = visit.ComplianceRequestId,
                CreatedByUserId = currentUserService.User.UserId,
                CreatedByUserEmail = currentUserService.User.UserEmail,
                CreatedByUserName = currentUserService.User.UserName,
                CreatedOn = DateTime.Now,
                ActionAr = existingDisclosure is null ? "اضافة" : "تعديل",
                ActionEn = existingDisclosure is null ? "Add" : "Update",
                DetailsAr = JsonConvert.SerializeObject(detailsAr),
                DetailsEn = JsonConvert.SerializeObject(detailsEn),
            };

            await dbContext.ComplianceRequestActivity.AddAsync(requestActivity);
            return ResponseResult<bool>.Success(true);
        }
        throw new ValidationException([new("Unauthoried User", "Unauthoried User")]);
    }
    public async Task<ResponseResult<ComplianceVisitDisclosure>> GetComplianceVisitDisclosureBySpecialistId(Guid specialistId)
    {
        var disclosure = await dbContext.ComplianceVisitDisclosure?.FirstOrDefaultAsync(s => s.ComplianceVisitSpecialistId == specialistId);

        if (disclosure != null)
        {
            ComplianceVisitDisclosure result = new ComplianceVisitDisclosure()
            {
                Id = disclosure.Id,
                ComplianceVisitSpecialistId = disclosure.ComplianceVisitSpecialistId,
                SurveyNotes = disclosure.SurveyNotes,
                HasConflicts = disclosure.HasConflicts,

            };
            return ResponseResult<ComplianceVisitDisclosure>.Success(result);
        }
        return null;
    }
    public async Task<ResponseResult<List<CompliancePlanDto>>> GetVisitsByStatus(long visitStatusId)
    {
        var visits = await dbContext.ComplianceDetails.Include(c => c.ComplianceVisitSpecialists)
                            .ThenInclude(c => c.ComplianceVisitDisclosure)
                        .Where(c => c.VisitStatusId.Equals(visitStatusId)).ToListAsync();

        if (visits != null && visits.Count() > 0)
        {
            var categoryLookupValue = await dbContext.LookupValue.ToListAsync();

            List<CompliancePlanDto>? userVisits = visits.Select(v => new CompliancePlanDto()
            {
                Id = v.Id,
                Seq = v.Seq,
                ActivityId = v.ActivityId,
                ComplianceRequestId = v.ComplianceRequestId,

                ActivityName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == v.ActivityId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == v.ActivityId)?.ValueAr,

                LicensedEntityId = v.LicensedEntityId,
                LicensedEntityName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == v.LicensedEntityId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == v.LicensedEntityId)?.ValueAr,


                LocationId = v.LocationId,
                LocationName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == v.LocationId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == v.LocationId)?.ValueAr,

                PlantNameId = v.PlantNameId,
                PlantName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == v.PlantNameId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == v.PlantNameId)?.ValueAr,

                QuarterPlannedForVisitId = v.QuarterPlannedForVisitId,
                QuarterPlannedForVisitName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == v.QuarterPlannedForVisitId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == v.QuarterPlannedForVisitId)?.ValueAr,

                VisitTypeId = v.VisitTypeId,
                VisitTypeName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == v.VisitTypeId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == v.VisitTypeId)?.ValueAr,

                ModifiedOn = v.ModifiedOn,
                CreatedOn = v.CreatedOn,

                DesignedCapacity = v.DesignedCapacity,
                VisitDate = v.VisitDate,
                VisitReferenceNumber = v.VisitReferenceNumber,

                VisitStatusId = v.VisitStatusId,
                VisitStatusName = (v.VisitStatusId != null)
                        ? (currentLanguageService.Language == LanguageEnum.En
                            ? categoryLookupValue.FirstOrDefault(a => a.Id == v.VisitStatusId)?.ValueEn
                            : categoryLookupValue.FirstOrDefault(a => a.Id == v.VisitStatusId)?.ValueAr
                        ) : null,


                UnscheduledVisitsForCurrentQuarter = GetUnscheduledVisitsForCurrentQuarter().Result.Count(),

                ComplianceVisitSpecialists = v.ComplianceVisitSpecialists?.Where(s => s.IsDeleted == false)
                        .Select(s => new ComplianceVisitSpecialistModel()
                        {
                            Id = s.Id,
                            ComplianceDetailsId = s.ComplianceDetailsId,
                            SpecialistUserId = s.SpecialistUserId,
                            SpecialistUserName = s.SpecialistUserName,
                            SpecialistUserEmail = s.SpecialistUserEmail,
                            MobileNumber = s.MobileNumber,
                            CreatedOn = s.CreatedOn,
                            ComplianceVisitDisclosure = s.ComplianceVisitDisclosure != null
                            ? new ComplianceVisitDisclosureModel()
                            {
                                Id = s.ComplianceVisitDisclosure.Id,
                                ComplianceVisitSpecialistId = s.ComplianceVisitDisclosure.ComplianceVisitSpecialistId,
                                SurveyNotes = s.ComplianceVisitDisclosure.SurveyNotes,
                                HasConflicts = s.ComplianceVisitDisclosure.HasConflicts,
                            }
                            : null,

                        }).ToList(),

            }).ToList();

            return ResponseResult<List<CompliancePlanDto>>.Success(userVisits);
        }

        return null;
    }

    #endregion Figma part 2 unmerged
    #endregion

    #region Complaince Report
    public async Task<List<ReportCategoryDto>> GetReportStructureDto()
    {
        if (currentUserService.User.Role.Any(a => a.Contains(RoleEnum.ComplianceSpecialist)))
        {
            var categories = await dbContext.ReportCategories
            .Where(c => !c.IsDeleted)
            .Include(c => c.SubCategories.Where(sc => !sc.IsDeleted))
            .ThenInclude(sc => sc.Entries.Where(e => !e.IsDeleted))
            .ToListAsync();

            var result = categories.Select(category => new ReportCategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                NameAr = category.NameAr,
                SubCategories = category.SubCategories.Select(sub => new ReportSubCategoryDto
                {
                    Id = sub.Id,
                    Name = sub.Name,
                    NameAr = sub.NameAr,
                    Entries = sub.Entries.Select(entry => new ReportEntryDto
                    {
                        Id = entry.Id,
                        Name = entry.Name,
                        NameAr = entry.NameAr
                    }).ToList()
                }).ToList()
            }).ToList();
            return result;
        }
        throw new ValidationException([new KeyValuePair<string, string>("Unauthoried User", "Unauthoried User")]);
    }

    public async Task<List<ReportCategory>> GetCategory()
    {
        var res = await dbContext.ReportCategories.Where(a => a.IsDeleted != true).ToListAsync();
        return res;
    }
    public async Task<List<ReportSubCategory>> GetSubCategory(int? CategoryID)
    {
        var res = await dbContext.ReportSubCategories.Where(a => a.CategoryID == CategoryID && a.IsDeleted != true).ToListAsync();
        return res;
    }
    public async Task<List<ReportEntries>> GetEntries(int? SubCategoryID)
    {
        var res = await dbContext.ReportEntries.Where(a => a.SupCategoryID == SubCategoryID && a.IsDeleted != true).ToListAsync();
        return res;
    }

    public async Task<ResponseResult<ComplianceReportDto>> AddComplianceReport(ComplianceReportDto reportDto)
    {

        if (currentUserService.User.Role.Any(a => a.Contains(RoleEnum.ComplianceSpecialist)))
        {
            var VisitObject = GetComplianceVisitDetail(reportDto.ComplianceDetailId).Result.Model ?? throw new Exception("Visit Not Found !");

            // Map DTO to Entity 
            var _report = new ComplianceReport
            {
                Id = Guid.NewGuid(),
                ReportTypeID = reportDto.ReportTypeID,
                ReportNumber = reportDto.ReportNumber ?? "",
                VisitTypeID = VisitObject.VisitTypeId,
                LicenseID = VisitObject.LicensedEntityId,

                FacilityOrLine = reportDto.FacilityOrLine ?? "",
                Activity = reportDto.Activity ?? "",
                SiteName = reportDto.SiteName ?? "",
                InspectionScope = reportDto.InspectionScope ?? "",
                LocationID = reportDto.LocationID,

                LicenseNumber = ReturnLicenseNumber(reportDto.LicenseID).Result.Model ?? "",
                CommercialOperationDate = reportDto.CommercialOperationDate,
                LicenseIssueDate = reportDto.LicenseIssueDate,
                VisitDate = VisitObject.VisitDate,
                Recommendation = reportDto.Recommendation,

                Notes = reportDto.Notes,
                CreatedByID = currentUserService.User.UserId,
                CreatedOn = DateTime.UtcNow,

                ComplianceDetailId = VisitObject.Id,
                IsDeleted = false,
                ReportStatusID = (int?)(reportDto.IsDraft == true ? ReportStatusEnum.Draft : ReportStatusEnum.Shared),
            };
            await dbContext.ComplianceReports.AddAsync(_report);

            // Add nested entities
            if (reportDto?.Auditors != null || reportDto?.Auditors?.Count > 0)
            {
                foreach (var audit in reportDto.Auditors)
                {
                    await dbContext.Auditors.AddAsync(new Auditors
                    {
                        Name = audit.Name,
                        ReportID = _report.Id
                    });
                }
            }
            if (reportDto?.Participants != null || reportDto?.Participants?.Count > 0)
            {
                foreach (var participant in reportDto.Participants)
                {
                    await dbContext.LicenseParticipants.AddAsync(new LicenseParticipant
                    {
                        Name = participant.Name,
                        Department = participant.Department ?? "",
                        Position = participant.Position ?? "",
                        Phone = participant.Phone,
                        Email = participant.Email,
                        ReportID = _report.Id
                    });
                }
            }
            if (reportDto?.PreviousRecommendations != null)
            {
                await dbContext.PreviousRecommendations.AddAsync(new PreviousRecommendations
                {
                    VisitDate = reportDto.PreviousRecommendations.VisitDate,
                    CompletionStatusID = reportDto.PreviousRecommendations.CompletionStatusID,
                    Comments = reportDto.PreviousRecommendations.Comments,
                    Action = reportDto.PreviousRecommendations.Action,
                    ReportID = _report.Id
                });
            }
            if (reportDto?.Questaions != null || reportDto?.Questaions?.Count > 0)
            {
                foreach (var questaion in reportDto.Questaions)
                {
                    await dbContext.Questaions.AddAsync(new Questaion
                    {
                        CategoryID = questaion.CategoryID,
                        CategoryName = questaion.CategoryName,
                        SubCategoryID = questaion.SubCategoryID,
                        SubCategoryName = questaion.SubCategoryName,
                        EntryID = questaion.EntryID,
                        EntryName = questaion.EntryName,

                        Grade = questaion.Grade,
                        Evidence = questaion.Evidence ?? "",
                        EvidencePath = questaion.EvidencePath,
                        ReportID = _report.Id,
                    });
                }
            }

            // Handle file attachments here
            await dbContext.SaveChangesAsync();
            reportDto.Id = _report.Id;
            return ResponseResult<ComplianceReportDto>.Success(reportDto);
        }
        throw new ValidationException([new KeyValuePair<string, string>("Unauthoried User", "Unauthoried User")]);
    }
    public async Task<ResponseResult<ComplianceReportDto>> GetComplianceReport(Guid? id)
    {
        var categoryLookupValue = await dbContext.LookupValue.ToListAsync();

        var lookupDictEn = categoryLookupValue.ToDictionary(x => x.Id, x => x.ValueEn);
        var lookupDictAr = categoryLookupValue.ToDictionary(x => x.Id, x => x.ValueAr);

        var reports = await dbContext.ComplianceReports
            .Include(r => r.Auditors)
            .Include(r => r.Participants)
            .Include(r => r.Questaions)
            .Include(r => r.PreviousRecommendations)
            .Where(r=> r.Id == id)
            .ToListAsync();

        var reportIds = reports.Select(r => r.Id).ToList();

        var attachments = await dbContext.Attachments
            .Where(s =>
                reportIds.Contains(s.EntityId) &&
                s.AttachmentTypeId == (long)AttachmentTypeEnum.ReportAttachment &&
                (s.IsDeleted == false || s.IsDeleted == null))
            .ToListAsync();

        // Group attachments by EntityId (which is the Report.Id)
        var attachmentsByReportId = attachments
            .GroupBy(a => a.EntityId)
            .ToDictionary(g => g.Key, g => g.ToList());

        var reportDtos = new List<ComplianceReportDto>();

        foreach (var report in reports)
        {
            var complianceReportDto = new ComplianceReportDto
            {
                Id = report.Id,
                ReportTypeID = report.ReportTypeID,
                ReportNumber = report.ReportNumber,
                VisitTypeID = report.VisitTypeID,
                LicenseID = report.LicenseID,
                FacilityOrLine = report.FacilityOrLine,
                Activity = report.Activity,

                SiteName = report.SiteName,
                InspectionScope = report.InspectionScope,
                LocationID = report.LocationID,
                LicenseNumber = report.LicenseNumber,
                CommercialOperationDate = report.CommercialOperationDate,
                LicenseIssueDate = report.LicenseIssueDate,
                VisitReferenceNumber = GetComplianceVisitDetail(report.ComplianceDetailId)?.Result?.Model?.VisitReferenceNumber,

                VisitDate = report.VisitDate,
                Recommendation = report.Recommendation,
                Notes = report.Notes,
                CreatedByID = report.CreatedByID,
                CreatedOn = report.CreatedOn,
                ComplianceDetailId = report.ComplianceDetailId,

                ReportStatusID = report.ReportStatusID,
                ReportStatusName = Enum.GetName(typeof(ReportStatusEnum), report.ReportStatusID).ToString(),

                Auditors = report.Auditors?.Select(a => new AuditorsDto
                {
                    Id = a.ID,
                    Name = a.Name ?? ""
                }).ToList(),
                Participants = report.Participants?.Select(p => new LicenseParticipantDto
                {
                    Name = p.Name,
                    Department = p.Department,
                    Position = p.Position,
                    Phone = p.Phone,
                    Email = p.Email,
                }).ToList(),
                Questaions = report.Questaions?.Select(q => new QuestaionDto
                {
                    CategoryID = q.CategoryID,
                    CategoryName = q.CategoryName,
                    SubCategoryID = q.SubCategoryID,
                    SubCategoryName = q.SubCategoryName,
                    EntryID = q.EntryID,
                    EntryName = q.EntryName,
                    Grade = q.Grade,
                    Evidence = q.Evidence,
                    EvidencePath = q.EvidencePath,
                    ReportID = q.ReportID
                }).ToList(),
                PreviousRecommendations = report.PreviousRecommendations == null ? null : new PreviousRecommendationsDto
                {
                    VisitDate = report.PreviousRecommendations.VisitDate,
                    CompletionStatusID = report.PreviousRecommendations.CompletionStatusID,
                    Comments = report.PreviousRecommendations.Comments,
                    Action = report.PreviousRecommendations.Action,
                    ReportID = report.Id
                }
            };
            if (currentLanguageService.Language == LanguageEnum.En)
            {
                complianceReportDto.LocationName = lookupDictEn.TryGetValue(complianceReportDto.LocationID, out var an) ? an : "";
                complianceReportDto.VisitTypeName = lookupDictEn.TryGetValue(complianceReportDto.VisitTypeID, out var ln) ? ln : "";
                complianceReportDto.ReportTypeName = lookupDictEn.TryGetValue(complianceReportDto.ReportTypeID, out var le) ? le : "";
                complianceReportDto.LicenseEntityName = lookupDictEn.TryGetValue(complianceReportDto.LicenseID, out var li) ? li : "";
            }
            else
            {
                complianceReportDto.LocationName = lookupDictAr.TryGetValue(complianceReportDto.LocationID, out var an) ? an : "";
                complianceReportDto.VisitTypeName = lookupDictAr.TryGetValue(complianceReportDto.VisitTypeID, out var ln) ? ln : "";
                complianceReportDto.ReportTypeName = lookupDictAr.TryGetValue(complianceReportDto.ReportTypeID, out var le) ? le : "";
                complianceReportDto.LicenseEntityName = lookupDictAr.TryGetValue(complianceReportDto.LicenseID, out var li) ? li : "";
            }
            // Assign attachments if found
            if (attachmentsByReportId.TryGetValue(report.Id, out var reportAttachments))
            {
                complianceReportDto.AttachmentsList = reportAttachments.Select(s => new AttachmentDto
                {
                    AttachmentGuid = s.AttachmentGuid,
                    AttachmentId = s.Id,
                    AttachmentName = s.AttachmentName,
                    AttachmentType = (AttachmentTypeEnum)s.AttachmentTypeId,
                    EntityId = s.EntityId,
                    EntityName = s.EntityName
                }).ToList();
            }

            reportDtos.Add(complianceReportDto);
        }
        var res = reportDtos != null ? reportDtos.FirstOrDefault() : new ComplianceReportDto() { };

        return ResponseResult<ComplianceReportDto>.Success(res);
    }
    public async Task<ResponseResult<List<ComplianceReportDto>>> GetAllComplianceReports()
    {
        var categoryLookupValue = await dbContext.LookupValue.ToListAsync();

        var lookupDictEn = categoryLookupValue.ToDictionary(x => x.Id, x => x.ValueEn);
        var lookupDictAr = categoryLookupValue.ToDictionary(x => x.Id, x => x.ValueAr);

        var reports = await dbContext.ComplianceReports
            .Include(r => r.Auditors)
            .Include(r => r.Participants)
            .Include(r => r.Questaions)
            .Include(r => r.PreviousRecommendations)
            .ToListAsync();

        var reportIds = reports.Select(r => r.Id).ToList();

        var attachments = await dbContext.Attachments
            .Where(s =>
                reportIds.Contains(s.EntityId) &&
                s.AttachmentTypeId == (long)AttachmentTypeEnum.ReportAttachment &&
                (s.IsDeleted == false || s.IsDeleted == null))
            .ToListAsync();

        // Group attachments by EntityId (which is the Report.Id)
        var attachmentsByReportId = attachments
            .GroupBy(a => a.EntityId)
            .ToDictionary(g => g.Key, g => g.ToList());

        var reportDtos = new List<ComplianceReportDto>();

        foreach (var report in reports)
        {
            var complianceReportDto = new ComplianceReportDto
            {
                Id = report.Id,
                ReportTypeID = report.ReportTypeID,
                ReportNumber = report.ReportNumber,
                VisitTypeID = report.VisitTypeID,
                LicenseID = report.LicenseID,
                FacilityOrLine = report.FacilityOrLine,
                Activity = report.Activity,
                VisitReferenceNumber = GetComplianceVisitDetail(report.ComplianceDetailId)?.Result?.Model?.VisitReferenceNumber,
                SiteName = report.SiteName,
                InspectionScope = report.InspectionScope,
                LocationID = report.LocationID,
                LicenseNumber = report.LicenseNumber,
                CommercialOperationDate = report.CommercialOperationDate,
                LicenseIssueDate = report.LicenseIssueDate,

                VisitDate = report.VisitDate,
                Recommendation = report.Recommendation,
                Notes = report.Notes,
                CreatedByID = report.CreatedByID,
                CreatedOn = report.CreatedOn,
                ComplianceDetailId = report.ComplianceDetailId,

                ReportStatusID = report.ReportStatusID,
                ReportStatusName = Enum.GetName(typeof(ReportStatusEnum), report.ReportStatusID).ToString(),

                Auditors = report.Auditors?.Select(a => new AuditorsDto
                {
                    Id = a.ID,
                    Name = a.Name ?? ""
                }).ToList(),
                Participants = report.Participants?.Select(p => new LicenseParticipantDto
                {
                    Name = p.Name,
                    Department = p.Department,
                    Position = p.Position,
                    Phone = p.Phone,
                    Email = p.Email,
                }).ToList(),
                Questaions = report.Questaions?.Select(q => new QuestaionDto
                {
                    CategoryID = q.CategoryID,
                    CategoryName = q.CategoryName,
                    SubCategoryID = q.SubCategoryID,
                    SubCategoryName = q.SubCategoryName,
                    EntryID = q.EntryID,
                    EntryName = q.EntryName,
                    Grade = q.Grade,
                    Evidence = q.Evidence,
                    EvidencePath = q.EvidencePath,
                    ReportID = q.ReportID
                }).ToList(),
                PreviousRecommendations = report.PreviousRecommendations == null ? null : new PreviousRecommendationsDto
                {
                    VisitDate = report.PreviousRecommendations.VisitDate,
                    CompletionStatusID = report.PreviousRecommendations.CompletionStatusID,
                    Comments = report.PreviousRecommendations.Comments,
                    Action = report.PreviousRecommendations.Action,
                    ReportID = report.Id
                }
            };
            if (currentLanguageService.Language == LanguageEnum.En)
            {
                complianceReportDto.LocationName = lookupDictEn.TryGetValue(complianceReportDto.LocationID, out var an) ? an : "";
                complianceReportDto.VisitTypeName = lookupDictEn.TryGetValue(complianceReportDto.VisitTypeID, out var ln) ? ln : "";
                complianceReportDto.ReportTypeName = lookupDictEn.TryGetValue(complianceReportDto.ReportTypeID, out var le) ? le : "";
                complianceReportDto.LicenseEntityName = lookupDictEn.TryGetValue(complianceReportDto.LicenseID, out var li) ? li : "";
            }
            else
            {
                complianceReportDto.LocationName = lookupDictAr.TryGetValue(complianceReportDto.LocationID, out var an) ? an : "";
                complianceReportDto.VisitTypeName = lookupDictAr.TryGetValue(complianceReportDto.VisitTypeID, out var ln) ? ln : "";
                complianceReportDto.ReportTypeName = lookupDictAr.TryGetValue(complianceReportDto.ReportTypeID, out var le) ? le : "";
                complianceReportDto.LicenseEntityName = lookupDictAr.TryGetValue(complianceReportDto.LicenseID, out var li) ? li : "";
            }
            // Assign attachments if found
            if (attachmentsByReportId.TryGetValue(report.Id, out var reportAttachments))
            {
                complianceReportDto.AttachmentsList = reportAttachments.Select(s => new AttachmentDto
                {
                    AttachmentGuid = s.AttachmentGuid,
                    AttachmentId = s.Id,
                    AttachmentName = s.AttachmentName,
                    AttachmentType = (AttachmentTypeEnum)s.AttachmentTypeId,
                    EntityId = s.EntityId,
                    EntityName = s.EntityName
                }).ToList();
            }

            reportDtos.Add(complianceReportDto);
        }

        return ResponseResult<List<ComplianceReportDto>>.Success(reportDtos);
    }

    public async Task<CorrectiveActionPlan> AddCorrectPlan(CorrectiveActionPlanDto dto)
    {
        var plan = new CorrectiveActionPlan
        {
            Id = Guid.NewGuid(),
            ReportId = dto.ReportId,
            Description = dto.PlanDetails,
            ComplianceDeatilsID = dto.ComplianceDeatilsID,
            Deadline = dto.Deadline,
            LicenseEntityID = (currentUserService.User.UserId),
            Status = (int)CorrectiveActionPlanStatus.SentToLicensee
        };
        await dbContext.CorrectiveActionPlans.AddAsync(plan);
        await dbContext.SaveChangesAsync();

        return plan;
    }

    public async Task<CorrectiveActionPlanDto?> GetPlanWithAttachments(Guid VisitId)
    {
        var plan = await dbContext.CorrectiveActionPlans
            .Include(p => p.Report)
            .FirstOrDefaultAsync(p => p.ComplianceDeatilsID == VisitId);

        if (plan == null) return null;

        return new CorrectiveActionPlanDto
        {
            Id = plan.Id,
            ReportId = plan.ReportId,
            PlanDetails = plan.Description,
            Deadline = plan.Deadline,
            LicenseEntityID = plan.LicenseEntityID,
            ComplianceDeatilsID = plan.ComplianceDeatilsID,
            FileList = dbContext.Attachments?.Where(a => a.EntityId == plan.Id)
            .Select(attachment => new AttachmentDto
            {
                AttachmentId = attachment.Id,
                AttachmentName = attachment.AttachmentName,
                AttachmentType = (AttachmentTypeEnum)attachment.AttachmentTypeId,
                EntityId = attachment.EntityId,
                EntityName = attachment.EntityName
            }).ToList()
        };
    }
    public async Task<CorrectiveEvidence> UploadEvidence(EvidenceUploadDto dto)
    {
        var plan = await dbContext.CorrectiveActionPlans.FindAsync(dto.Id)
        ??
        throw new Exception("Plan not found");

        var evidence = new CorrectiveEvidence
        {
            Id = Guid.NewGuid(),
            PlanId = dto.planId,
            Comments = dto.Comments,
            EvidenceStatus = (int?)EvidenceStatus.Pending
        };
        await dbContext.CorrectiveEvidences.AddAsync(evidence);
        await dbContext.SaveChangesAsync();

        return evidence;
    }
    public async Task ReviewEvidence(EvidenceReviewDto dto)
    {
        var evidence = await dbContext.CorrectiveEvidences.FindAsync(dto.EvidenceId) ?? throw new Exception("Evidence not found");

        evidence.EvidenceStatus = (int?)(dto.IsApproved ? EvidenceStatus.Accepted : EvidenceStatus.Returned);
        evidence.Comments += $"\nReview by {currentUserService.User.UserName}: {dto.ReviewerComments}";

        await dbContext.SaveChangesAsync();
    }
    public async Task ReviewReport(ComplianceReportReviewDto dto)
    {
        var review = new ComplianceReportReview
        {
            Id = Guid.NewGuid(),
            ComplianceReportId = dto.reportId,
            ReviewerRole = currentUserService.User.Role.FirstOrDefault() ?? "",
            IsApproved = dto.IsApproved,
            ReasonForReturn = dto.ReasonForReturn,
            ReviewedOn = DateTime.UtcNow,
            ReviewedById = currentUserService.User.UserId ?? ""
        };

        dbContext.ComplianceReportReviews.Add(review);
        await dbContext.SaveChangesAsync();
    }

    public async Task<ResponseResult<Guid>> SaveComplianceReportActivity(ReportRequestActivityModel model)
    {
        var record = await dbContext.ReportRequestActivities.FirstOrDefaultAsync(s => s.Id == model.Id);
        if (record == null)
        {
            record = new ReportRequestActivity()
            {
                Id = Guid.NewGuid()
            };
            await dbContext.ReportRequestActivities.AddAsync(record);
        };

        record.ReportId = model.ReportId;
        record.IsReply = (bool)model.IsReply;
        record.ReplyComment = model.ReplyComment;

        await dbContext.SaveChangesAsync();
        return ResponseResult<Guid>.Success(record.Id);
    }
    public async Task<ResponseResult<ReportRequestActivityDto>> GetComplianceReportActivity(Guid id)
    {
        var attachments = await dbContext.Attachments.Where(s => (s.IsDeleted == false || s.IsDeleted == null) && s.EntityId == id && (s.AttachmentTypeId == (long)AttachmentTypeEnum.ReportSendAttachment || s.AttachmentTypeId == (long)AttachmentTypeEnum.ReportReplyAttachment)).ToListAsync();
        var reportActivity = await dbContext.ReportRequestActivities.Include(s => s.Report).FirstOrDefaultAsync(s => s.Id == id);
        if (reportActivity != null)
        {
            var result = new ReportRequestActivityDto()
            {
                Id = reportActivity.Id,
                ReportId = reportActivity.ReportId,
                IsReply = (bool)reportActivity.IsReply,
                ReplyComment = reportActivity.ReplyComment,
                RequestComment = reportActivity.RequestComment,
                CreatedDate = reportActivity.CreatedOn,
                RequestAttachments = attachments.Where(a => a.EntityId == id && a.AttachmentTypeId == (long)AttachmentTypeEnum.ReportSendAttachment).Select(a => new AttachmentDto()
                {
                    AttachmentGuid = a.AttachmentGuid,
                    AttachmentId = a.Id,
                    AttachmentName = a.AttachmentName,
                    AttachmentType = (AttachmentTypeEnum)a.AttachmentTypeId,
                    EntityId = a.EntityId,
                    EntityName = a.EntityName
                }).ToList(),
                ReplyAttachments = attachments.Where(a => a.EntityId == id && a.AttachmentTypeId == (long)AttachmentTypeEnum.ReportReplyAttachment).Select(a => new AttachmentDto()
                {
                    AttachmentGuid = a.AttachmentGuid,
                    AttachmentId = a.Id,
                    AttachmentName = a.AttachmentName,
                    AttachmentType = (AttachmentTypeEnum)a.AttachmentTypeId,
                    EntityId = a.EntityId,
                    EntityName = a.EntityName
                }).ToList(),
                ComplianceReport = new ComplianceReportDto()
                {
                    LicenseID = reportActivity.Report.LicenseID,
                }
            };
            return ResponseResult<ReportRequestActivityDto>.Success(result);
        }

        throw new BadRequestException(id + "Not Found");
    }
    public async Task<ResponseResult<List<ReportRequestActivityDto>>> GetComplianceReportActivities(bool isReply)
    {
        var attachments = await dbContext.Attachments.Where(s => (s.IsDeleted == false || s.IsDeleted == null) && s.AttachmentTypeId == (long)AttachmentTypeEnum.ReportSendAttachment || s.AttachmentTypeId == (long)AttachmentTypeEnum.ReportReplyAttachment).ToListAsync();
        var reportActivities = await dbContext.ReportRequestActivities.Include(s => s.Report).Where(s => s.IsReply == isReply).OrderBy(s => s.CreatedOn).Select(s => new ReportRequestActivityDto()
        {
            Id = s.Id,
            ReportId = s.ReportId,
            IsReply = (bool)s.IsReply,
            ReplyComment = s.ReplyComment,
            RequestComment = s.RequestComment,
            CreatedDate = s.CreatedOn,
            RequestAttachments = attachments.Where(a => a.EntityId == s.Id && a.AttachmentTypeId == (long)AttachmentTypeEnum.ReportSendAttachment).Select(a => new AttachmentDto()
            {
                AttachmentGuid = a.AttachmentGuid,
                AttachmentId = a.Id,
                AttachmentName = a.AttachmentName,
                AttachmentType = (AttachmentTypeEnum)a.AttachmentTypeId,
                EntityId = a.EntityId,
                EntityName = a.EntityName
            }).ToList(),
            ReplyAttachments = attachments.Where(a => a.EntityId == s.Id && a.AttachmentTypeId == (long)AttachmentTypeEnum.ReportReplyAttachment).Select(a => new AttachmentDto()
            {
                AttachmentGuid = a.AttachmentGuid,
                AttachmentId = a.Id,
                AttachmentName = a.AttachmentName,
                AttachmentType = (AttachmentTypeEnum)a.AttachmentTypeId,
                EntityId = a.EntityId,
                EntityName = a.EntityName
            }).ToList(),
            ComplianceReport = new ComplianceReportDto()
            {
                LicenseID = s.Report.LicenseID,
            }
        }).ToListAsync();
        return ResponseResult<List<ReportRequestActivityDto>>.Success(reportActivities);
    }
    public async Task<ResponseResult<List<RequestRescheduleDto>>> GetRescheduleRequestsForManager()
    {
        if (!currentUserService.User.Role.Contains(RoleEnum.LicensedEntity))
        {
            var _Request = await dbContext.RescheduleRequests
            .Where(a => a.Status.Equals(1))
           .Select(a => new RequestRescheduleDto
           {
               Id = a.Id,
               RequestedAt = a.RequestedAt,
               RequestedByUserId = a.RequestedByUserId ?? "",
               ReviewedAt = a.ReviewedAt,
               ReviewReason = a.ReviewReason,
               ProposedDate = a.ProposedDate,
               Reason = a.Reason,
               LicensedEntityId = a.LicensedEntityId,
               ComplianceDetailsID = a.ComplianceDetailsID,
               StatusID = a.Status,
               Status = ExtensionStatusMapper.ToFriendlyString(a.Status, currentLanguageService)
           }).ToListAsync()

             ?? throw new Exception("No Reschedule Requests Found ..");
            return ResponseResult<List<RequestRescheduleDto>>.Success(_Request);
        }
        throw new ValidationException([new KeyValuePair<string, string>("Unauthoried User", "Unauthoried User")]);
    }

    public async Task<TeamShortage> AddTeamShortage(TeamShortage request)
    {
        if (currentUserService.User.Role.Any(role => role.Equals(RoleEnum.ComplianceManager)))
        {
            dbContext.TeamShortages.Add(request);
            await dbContext.SaveChangesAsync();
            return request;
        }
        throw new ValidationException([new("Unauthoried User", "Unauthoried User")]);
    }
    public async Task<List<TeamShortage>> GetTeamShortageByVisitId(List<Guid> ComplianceDetailsIds)
    {
        return await dbContext.TeamShortages
            .Where(t => ComplianceDetailsIds.Contains(t.ComplianceDetailsId))
            .ToListAsync();
    }
    public bool GetComplianceVisitDisclosure(Guid ComplianceVisitSpecialistId)
    {
        var res = dbContext.ComplianceVisitDisclosure.FirstOrDefault(a => a.ComplianceVisitSpecialistId == ComplianceVisitSpecialistId);
        if (res != null)
        {
            return true;
        }
        return false;
    }

    public async Task<ResponseResult<string>> ReturnLicenseNumber(long LicenseEntityID)
    {
        var categoryLookupValue = await dbContext.LookupValue.ToListAsync();
        var LicenseNumber = categoryLookupValue.ToDictionary(x => x.Id, x => x.LicenseNumber);
        var license = ""; 

        license = LicenseNumber.TryGetValue(LicenseEntityID, out var le) ? le : "";

        return ResponseResult<string>.Success(license);
    }

    #endregion
}