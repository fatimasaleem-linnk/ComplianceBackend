using ComplianceAndPeformanceSystem.Contract.Common.Exceptions;
using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Dtos.Compliance;
using ComplianceAndPeformanceSystem.Contract.Dtos.ComplianceVisit;
using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.IRepositories;
using ComplianceAndPeformanceSystem.Contract.IServices;
using ComplianceAndPeformanceSystem.Contract.Models;
using ComplianceAndPeformanceSystem.Core.Entities;
using ComplianceAndPeformanceSystem.Core.Entities.ComplainceVisit;
using Hangfire;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.IO.Pipelines;

namespace ComplianceAndPeformanceSystem.BLL.Services;

public class ComplianceRequestService(IUnitOfWork unitOfWork, ICurrentUserService currentUserService, ICurrentLanguageService currentLanguageService, IAttachmentService attachmentService,
Func<NotificationTypeEnum, INotificationService> notificationService) : IComplianceRequestService
{
    public async Task<ResponseResult<ComplianceRequestDto>> GetComplianceforSpecilest(ComplianceRequestFilterDto? filter)
    {
        // Get latest compliance request
        var record = await unitOfWork.ComplianceRequestRepository.GetLatestComplianceRequest() ?? throw new NotFoundException("ComplianceRequest", "Not found");

        if (DateTime.Now.Subtract(record.CreatedOn).Days > 365)
            throw new NotFoundException("ComplianceRequest", "Yearly Compliance Request not found \r\n لم يتم العثور على طلب الامتثال السنوي");

        //  Security check
        if (!(currentUserService != null &&
            (record.ComplianceSpecialists.Any(s => s.SpecialistUserName == currentUserService.User.UserName) ||
             currentUserService.User.Role.Contains(RoleEnum.PerformanceMonitoringManager) ||
             currentUserService.User.Role.Contains(RoleEnum.ComplianceManager) ||
             currentUserService.User.Role.Contains(RoleEnum.ComplianceSpecialist) 
             )))
        {
            return null;
        }

        // Filter ComplianceDetails
        var complianceDetailsQuery = record.ComplianceDetails
            .Where(s => s.IsDeleted == false)
            .AsQueryable();

        if (filter != null)
        {
            if (filter.VisitTypeID.HasValue)
                complianceDetailsQuery = complianceDetailsQuery.Where(s => s.VisitTypeId == filter.VisitTypeID.Value);

            if (filter.VisitStatusID.HasValue)
                complianceDetailsQuery = complianceDetailsQuery.Where(s => s.VisitStatusId == filter.VisitStatusID.Value);

            if (filter.LicenseeEntityID.HasValue)
                complianceDetailsQuery = complianceDetailsQuery.Where(s => s.LicensedEntityId == filter.LicenseeEntityID.Value);

            if (!string.IsNullOrWhiteSpace(filter.VisitReferanceNumber))
                complianceDetailsQuery = complianceDetailsQuery.Where(s => s.VisitReferenceNumber == filter.VisitReferanceNumber);

            if (filter.VisitDate.HasValue)
                complianceDetailsQuery = complianceDetailsQuery.Where(s => s.VisitDate.HasValue &&
                                                                             s.VisitDate.Value.Date == filter.VisitDate.Value.Date);
        }

        var complianceDetails = complianceDetailsQuery.OrderByDescending(s => s.Seq).ToList();
        var visitIds = complianceDetails.Select(s => s.Id).ToList();

        // Fetch Attachments & Lookup Values
        var visitDocuments = await unitOfWork.ComplianceRequestRepository.GetVisitAttachments(visitIds);
        var categoryLookupValue = (await unitOfWork.ComplianceRequestRepository.GetLookupValues()).ToDictionary(k => k.Id, v => v);

        // Build DTO
        var complianceRequestDto = BuildComplianceRequestDto(record, complianceDetails, visitDocuments, categoryLookupValue);

        return ResponseResult<ComplianceRequestDto>.Success(complianceRequestDto);
    }
    private ComplianceRequestDto BuildComplianceRequestDto(ComplianceRequest record, List<ComplianceDetails> complianceDetails, List<AttachmentDto> visitDocuments, Dictionary<long, LookupValue> lookupValues)
    {
        return new ComplianceRequestDto
        {
            Id = record.Id,
            Seq = record.Seq,
            LastSendDate = record.LastSendDate,
            AssignTaskName = currentLanguageService.Language == LanguageEnum.En
                ? record.AssignTaskNameEn
                : record.AssignTaskNameAr,
            CreatedOn = record.CreatedOn,
            AssignedOn = record.AssignedOn,
            StatusId = record.StatusId,
            StatusName = currentLanguageService.Language == LanguageEnum.En
                ? record.Status.ValueEn
                : record.Status.ValueAr,
            PassedDays = record.PassedDays,
            RemainingDays = record.RemainingDays,
            AssignedSpecialists = record.ComplianceSpecialists?.Select(a => new ComplianceSpecialistDto
            {
                SpecialistUserEmail = a.SpecialistUserEmail,
                SpecialistUserId = a.SpecialistUserId,
                SpecialistUserName = a.SpecialistUserName
            }).ToList(),

            CompliancePlans = complianceDetails.Select(s => new CompliancePlanDto
            {
                Id = s.Id,
                Seq = s.Seq,
                ActivityId = s.ActivityId,
                ComplianceRequestId = s.ComplianceRequestId,

                ActivityName = GetLookupValueName(lookupValues, s.ActivityId),
                LicensedEntityId = s.LicensedEntityId,
                LicensedEntityName = GetLookupValueName(lookupValues, s.LicensedEntityId),

                LocationId = s.LocationId,
                LocationName = GetLookupValueName(lookupValues, s.LocationId),
                PlantNameId = s.PlantNameId,
                PlantName = GetLookupValueName(lookupValues, s.PlantNameId),

                QuarterPlannedForVisitId = s.QuarterPlannedForVisitId,
                QuarterPlannedForVisitName = GetLookupValueName(lookupValues, s.QuarterPlannedForVisitId),
                QuarterPlannedForVisitNameEn = lookupValues.ContainsKey(s.QuarterPlannedForVisitId ?? 0)
                    ? lookupValues[s.QuarterPlannedForVisitId.Value].ValueEn
                    : null,

                VisitTypeId = s.VisitTypeId,
                VisitTypeName = GetLookupValueName(lookupValues, s.VisitTypeId),

                VisitDate = s.VisitDate,
                VisitReferenceNumber = s.VisitReferenceNumber,
                DesignedCapacity = s.DesignedCapacity,

                VisitStatusId = s.VisitStatusId,
                VisitStatusName = GetLookupValueName(lookupValues, s.VisitStatusId),

                ModifiedOn = s.ModifiedOn,
                CreatedOn = s.CreatedOn,
                LocationVisit = s.LocationVisit,
                ScheduledDate = s.ScheduledDate,
                CancelledAt = s.CancelledAt,
                CancellationReason = s.CancellationReason,
                RescheduleReason = s.RescheduleReason,

                ComplianceVisitSpecialists = s.ComplianceVisitSpecialists?.Select(a => new ComplianceVisitSpecialistModel()
                {
                    ComplianceDetailsId = a.ComplianceDetailsId,
                    Id = a.Id,
                    MobileNumber = a.MobileNumber,
                    CreatedOn = a.CreatedOn,
                    SpecialistUserEmail = a.SpecialistUserEmail,
                    SpecialistUserId = a.SpecialistUserId,
                    SpecialistUserName = a.SpecialistUserName,
                    IsSubmitted = unitOfWork.ComplianceRequestRepository.GetComplianceVisitDisclosure(a.Id) == true,
                }).ToList(),

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

                VisitDocuments = visitDocuments.Where(a => a.EntityId == s.Id).ToList()
            }).ToList()
        };
    }
    private string GetLookupValueName(Dictionary<long, LookupValue> lookupValues, long? id)
    {
        if (!id.HasValue || !lookupValues.ContainsKey(id.Value))
            return null;

        return currentLanguageService.Language == LanguageEnum.En ? lookupValues[id.Value].ValueEn : lookupValues[id.Value].ValueAr;
    }
    
    public async Task CreateComplianceRequest()
    {
        await unitOfWork.ComplianceRequestRepository.CreateComplianceRequest();
        await unitOfWork.CommitAsync();

        BackgroundJob.Enqueue(() =>
            SendCreateComplanceRequest()
        );

    }
    public async Task SendCreateComplanceRequest()
    {
        var complianceManager = await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.ComplianceManager });
        if (complianceManager != null && complianceManager.Model != null)
        {
            var template = (await unitOfWork.TemplateRepository.GetTemplates(TemplateTypeEnum.Email)).Model?.FirstOrDefault(s => s.Id == (long)TemplateEnum.StartPreparingPlan10thSeptember);
            if (template != null)
            {

                template.Content = template.Content.Replace("{{EmployeeName}}", "مدير الادارة");
                template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Subject = template.Subject,
                    Body = template.Content,
                    To = complianceManager.Model.Select(s => s.Email).ToList()
                });
            }
        }

       
    }


    public async Task<ResponseResult<bool>> AssignComplianceSpecialist(AssignComplianceSpecialistModel model)
    {
        var result = await unitOfWork.ComplianceRequestRepository.AssignComplianceSpecialist(model);
        await unitOfWork.CommitAsync();
        BackgroundJob.Enqueue(() =>
            SendAssignComplianceSpecialist(result.Model)
        );

        return ResponseResult<bool>.Success(true);
    }

    public async Task SendAssignComplianceSpecialist(KeyValuePair<List<string>, List<string>> result)
    {
        var allUsers = (await unitOfWork.UserRepository.GetUsers(new List<string>())).Model;
        if (allUsers != null && allUsers != null)
        {
            var templates = (await unitOfWork.TemplateRepository.GetTemplates(TemplateTypeEnum.Email)).Model;
            var newlyAssignedSpecialistForPreparingPlanTemplate = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.NewlyAssignedSpecialistForPreparingPlan);
            var cancelTheAssignmentSpecialistForPrepareThePlanTemplate = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.CancelTheAssignmentSpecialistForPrepareThePlan);
            if (newlyAssignedSpecialistForPreparingPlanTemplate != null)
            {
                newlyAssignedSpecialistForPreparingPlanTemplate.Content = newlyAssignedSpecialistForPreparingPlanTemplate.Content.Replace("{{EmployeeName}}", "اخصائي الالتزام");
                newlyAssignedSpecialistForPreparingPlanTemplate.Content = newlyAssignedSpecialistForPreparingPlanTemplate.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");
                
                var users = allUsers.Where(s => result.Key.Contains(s.Id)).ToList();
                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Body = newlyAssignedSpecialistForPreparingPlanTemplate.Content,
                    Subject = newlyAssignedSpecialistForPreparingPlanTemplate.Subject,
                    To = users.Where(s => s.Roles.Contains(RoleEnum.ComplianceSpecialist)).Select(s => s.Email).ToList(),
                    CC = allUsers.Where(s => s.Roles.Contains(RoleEnum.PerformanceMonitoringManager) || s.Roles.Contains(RoleEnum.ComplianceManager)).Select(s => s.Email).ToList(),
                });
            }


            if (cancelTheAssignmentSpecialistForPrepareThePlanTemplate != null)
            {
                cancelTheAssignmentSpecialistForPrepareThePlanTemplate.Content = cancelTheAssignmentSpecialistForPrepareThePlanTemplate.Content.Replace("{{EmployeeName}}", "اخصائي الالتزام");
                cancelTheAssignmentSpecialistForPrepareThePlanTemplate.Content = cancelTheAssignmentSpecialistForPrepareThePlanTemplate.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                var users = allUsers.Where(s => result.Value.Contains(s.Id)).ToList();
                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Body = cancelTheAssignmentSpecialistForPrepareThePlanTemplate.Content,
                    Subject = cancelTheAssignmentSpecialistForPrepareThePlanTemplate.Subject,
                    To = users.Where(s => s.Roles.Contains(RoleEnum.ComplianceSpecialist)).Select(s => s.Email).ToList(),
                    CC = allUsers.Where(s => s.Roles.Contains(RoleEnum.PerformanceMonitoringManager) || s.Roles.Contains(RoleEnum.ComplianceManager)).Select(s => s.Email).ToList(),
                });
            }
        }
    }

    public async Task UpdateRemainingDays()
    {
        await unitOfWork.ComplianceRequestRepository.UpdateRemainingDays();
        await unitOfWork.CommitAsync();
    }



    public async Task<ResponseResult<List<ComplianceNotificationMessageDto>>> GetNotifications()
    {
        List<ComplianceNotificationMessageDto> notificationsResult = new List<ComplianceNotificationMessageDto>();
        var notifications = (await unitOfWork.ComplianceRequestRepository.GetComplianceNotifications(null)).Model;
        var complianceRequest = (await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(null))?.Model;
        if (notifications != null && complianceRequest != null && notificationsResult != null)
        {
            if (currentUserService.User.Role.Contains(RoleEnum.ComplianceSpecialist))
            {
                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.New && (complianceRequest.CompliancePlans == null || complianceRequest.CompliancePlans.Count() == 0) && (complianceRequest.AssignedSpecialists != null && complianceRequest.AssignedSpecialists.Any(s => s.SpecialistUserId == currentUserService.User.UserId)))
                {
                    if (complianceRequest.PassedDays < 3)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 13);
                        if (notification != null)
                            notificationsResult.Add(notification);

                    }

                    if (complianceRequest.PassedDays >= 5)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 14);
                        if (notification != null)
                            notificationsResult.Add(notification);

                    }
                }

                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.ComplianceSpecialistPreparingDelayed)
                {
                    var notification = notifications.FirstOrDefault(s => s.Id == 39);
                    if (notification != null)
                        notificationsResult.Add(notification);
                }

                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.ComplianceManagerOverdue)
                {
                    var notification = notifications.FirstOrDefault(s => s.Id == 41);
                    if (notification != null)
                        notificationsResult.Add(notification);
                }

                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.PeformanceMonitoringManagerOverdue)
                {
                    var notification = notifications.FirstOrDefault(s => s.Id == 40);
                    if (notification != null)
                        notificationsResult.Add(notification);
                }

                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.New && (complianceRequest.CompliancePlans != null && complianceRequest.CompliancePlans.Count() > 0) && (complianceRequest.AssignedSpecialists != null && complianceRequest.AssignedSpecialists.Any(s => s.SpecialistUserId == currentUserService.User.UserId)))
                {
                    if (complianceRequest.PassedDays % 5 == 0 && complianceRequest.RemainingDays > 5)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 15);
                        if (notification != null)
                            notificationsResult.Add(notification);
                    }

                    if (complianceRequest.RemainingDays <= 5 && complianceRequest.RemainingDays > 3)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 16);
                        if (notification != null)
                            notificationsResult.Add(notification);
                    }

                    if (complianceRequest.RemainingDays <= 3 && complianceRequest.RemainingDays > 0)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 17);
                        if (notification != null)
                            notificationsResult.Add(notification);
                    }

                    if (complianceRequest.RemainingDays <= 0)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 18);
                        if (notification != null)
                            notificationsResult.Add(notification);
                    }
                }

                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.PendingReviewOfComplianceManager)
                {
                    var notification = notifications.FirstOrDefault(s => s.Id == 19);
                    if (notification != null)
                        notificationsResult.Add(notification);
                }

                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.PendingReviewOfPerformanceMonitoringManager)
                {
                    var notification = notifications.FirstOrDefault(s => s.Id == 22);
                    if (notification != null)
                        notificationsResult.Add(notification);
                }

                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.ApprovalOfTheComplianceManager)
                {
                    var notification = notifications.FirstOrDefault(s => s.Id == 20);
                    if (notification != null)
                        notificationsResult.Add(notification);
                }

                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.ApprovalOfPerformanceMonitoringManager)
                {
                    //plan approved noptification
                    var notification = notifications.FirstOrDefault(s => s.Id == 21);
                    if (notification != null)
                        notificationsResult.Add(notification);

                    //quarter visit scheduling notification
                    var today = DateTime.UtcNow.Date;
                    var notificationDates = new List<DateTime>
                    {
                        //today,
                        new DateTime(today.Year, 1, 1).AddDays(-7),
                        new DateTime(today.Year, 4, 1).AddDays(-7),
                        new DateTime(today.Year, 7, 1).AddDays(-7),
                        new DateTime(today.Year, 10, 1).AddDays(-7),
                    };

                    if (notificationDates.Contains(today))
                    {
                        var secondNotification = notifications.FirstOrDefault(s => s.Id == 31);

                        string currentMonthName = DateTime.Now.ToString("MMMM");
                        var quarterName = complianceRequest?.CompliancePlans?.Where(p => p.QuarterPlannedForVisitNameEn.Contains(currentMonthName)).FirstOrDefault()?.QuarterPlannedForVisitName;

                        secondNotification.MessageBody = secondNotification?.MessageBody.Replace("{QuarterName}", quarterName.ToString());

                        if (secondNotification != null)
                            notificationsResult.Add(secondNotification);
                    }

                    //submit disclosure form notification
                    var scheduledVisits = (await unitOfWork.ComplianceRequestRepository.GetVisitsByStatusForLoggedInUser(currentUserService.User.UserId, (long)VisitStatusEnum.Scheduled));

                    if (scheduledVisits != null && scheduledVisits.Model != null && scheduledVisits.Model.Count() > 0)
                    {
                        foreach (var visit in scheduledVisits.Model)
                        {
                            if (visit.ComplianceVisitSpecialists?.FirstOrDefault(vs => vs.SpecialistUserId.Equals(currentUserService.User.UserId))?.ComplianceVisitDisclosure == null)
                            {
                                var visitnotification = notifications.FirstOrDefault(s => s.Id == 30);

                                notification.MessageBody = visitnotification?.MessageBody
                                    .Replace("{VisitDate}", visit.VisitDate.Value.ToString("dd-MMMM-yyyy"));

                                if (notification != null)
                                    notificationsResult.Add(visitnotification);
                            }
                        }
                    }

                    //notification for specialist removed from team due to conflict
                    var conflictedVisits = (await unitOfWork.ComplianceRequestRepository.GetVisitsByStatusForLoggedInUser(currentUserService.User.UserId, (long)VisitStatusEnum.ConflictOfInterestDisclosure));

                    var loggedInUserConflicts = conflictedVisits?.Model?.Where(v => v.ComplianceVisitSpecialists.FirstOrDefault(s => s.SpecialistUserId.Equals(currentUserService.User.UserId)).ComplianceVisitDisclosure.HasConflicts);

                    if (loggedInUserConflicts != null && loggedInUserConflicts.Count() > 0)
                    {
                        foreach (var visit in loggedInUserConflicts)
                        {
                            var removalnotification = notifications.FirstOrDefault(s => s.Id == 29);

                            removalnotification.MessageBody = removalnotification?.MessageBody
                                .Replace("{Reason}", "Conflict of Interest");

                            if (notification != null)
                                notificationsResult.Add(removalnotification);
                        }
                    }

                }

                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.ReturnPlanOfComplianceManager)
                {
                    var notification = notifications.FirstOrDefault(s => s.Id == 23);
                    if (notification != null)
                    {
                        var note = await unitOfWork.ComplianceRequestRepository.GetComplianceApproval(complianceRequest.Id);
                        notification.MessageBody = notification.MessageBody.Replace("{{ReturnReason}}", note.Model);
                        notificationsResult.Add(notification);

                    }

                }

                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.ReturnPlanOfPerformanceMonitoringManager)
                {
                    var notification = notifications.FirstOrDefault(s => s.Id == 24);
                    if (notification != null)
                    {
                        var note = await unitOfWork.ComplianceRequestRepository.GetComplianceApproval(complianceRequest.Id);
                        notification.MessageBody = notification.MessageBody.Replace("{{ReturnReason}}", note.Model);
                        notificationsResult.Add(notification);
                    }
                }
            }

            if (currentUserService.User.Role.Contains(RoleEnum.ComplianceManager))
            {
                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.New && (complianceRequest.CompliancePlans == null || complianceRequest.CompliancePlans.Count() == 0))
                {
                    if (complianceRequest.PassedDays < 3)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 1);
                        if (notification != null)
                            notificationsResult.Add(notification);

                    }

                    if (complianceRequest.PassedDays >= 3)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 2);
                        if (notification != null)
                            notificationsResult.Add(notification);

                    }
                }

                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.ComplianceSpecialistPreparingDelayed)
                {
                    var notification = notifications.FirstOrDefault(s => s.Id == 39);
                    if (notification != null)
                        notificationsResult.Add(notification);
                }

                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.ComplianceManagerOverdue)
                {
                    var notification = notifications.FirstOrDefault(s => s.Id == 41);
                    if (notification != null)
                        notificationsResult.Add(notification);
                }

                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.ReturnPlanOfComplianceManager)
                {
                    var notification = notifications.FirstOrDefault(s => s.Id == 23);
                    if (notification != null)
                    {
                        var note = await unitOfWork.ComplianceRequestRepository.GetComplianceApproval(complianceRequest.Id);
                        notification.MessageBody = notification.MessageBody.Replace("{{ReturnReason}}", note.Model);
                        notificationsResult.Add(notification);

                    }

                }

                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.ReturnPlanOfPerformanceMonitoringManager)
                {
                    var notification = notifications.FirstOrDefault(s => s.Id == 24);
                    if (notification != null)
                    {
                        var note = await unitOfWork.ComplianceRequestRepository.GetComplianceApproval(complianceRequest.Id);
                        notification.MessageBody = notification.MessageBody.Replace("{{ReturnReason}}", note.Model);
                        notificationsResult.Add(notification);
                    }
                }

                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.PeformanceMonitoringManagerOverdue)
                {
                    var notification = notifications.FirstOrDefault(s => s.Id == 40);
                    if (notification != null)
                        notificationsResult.Add(notification);
                }

                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.PendingReviewOfComplianceManager)
                {
                    if (complianceRequest.RemainingDays > 5)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 3);
                        if (notification != null)
                            notificationsResult.Add(notification);
                    }


                    if (complianceRequest.RemainingDays == 5)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 4);
                        if (notification != null)
                            notificationsResult.Add(notification);
                    }

                    if (complianceRequest.RemainingDays == 2)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 5);
                        if (notification != null)
                            notificationsResult.Add(notification);
                    }

                    if (complianceRequest.RemainingDays <= 0)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 6);
                        if (notification != null)
                            notificationsResult.Add(notification);
                    }


                    if (complianceRequest.RemainingDays <= 0)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 18);
                        if (notification != null)
                            notificationsResult.Add(notification);
                    }
                }

                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.ReturnPlanOfPerformanceMonitoringManager)
                {
                    var notification = notifications.FirstOrDefault(s => s.Id == 7);
                    if (notification != null)
                        notificationsResult.Add(notification);
                }

                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.PendingReviewOfPerformanceMonitoringManager)
                {
                    var notification = notifications.FirstOrDefault(s => s.Id == 8);
                    if (notification != null)
                        notificationsResult.Add(notification);
                }

                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.ApprovalOfPerformanceMonitoringManager)
                {
                    //quarter notification to schedule visits
                    var today = DateTime.UtcNow.Date;
                    var notificationDates = new List<DateTime>
                    {
                        new DateTime(today.Year, 1, 1).AddDays(-7),
                        new DateTime(today.Year, 4, 1).AddDays(-7),
                        new DateTime(today.Year, 7, 1).AddDays(-7),
                        new DateTime(today.Year, 10, 1).AddDays(-7),
                    };

                    if (notificationDates.Contains(today))
                    {
                        var quarterNotification = notifications.FirstOrDefault(s => s.Id == 25);

                        string currentMonthName = DateTime.Now.ToString("MMMM");
                        var quarterName = complianceRequest?.CompliancePlans?.Where(p => p.QuarterPlannedForVisitNameEn.Contains(currentMonthName)).FirstOrDefault()?.QuarterPlannedForVisitName;

                        quarterNotification.MessageBody = quarterNotification?.MessageBody.Replace("{QuarterName}", quarterName.ToString());

                        if (quarterNotification != null)
                            notificationsResult.Add(quarterNotification);

                    }

                    //notification to assign team to new visits 
                    var scheduledVisits = (await unitOfWork.ComplianceRequestRepository.GetNewVisitsForCurrentQuarter());

                    if (scheduledVisits != null && scheduledVisits?.Count() > 0)
                    {
                        foreach (var visit in scheduledVisits)
                        {
                            if (visit.VisitStatusId.Equals((long)VisitStatusEnum.New))
                            {
                                var assignTeamNotification = notifications.FirstOrDefault(s => s.Id == 26);

                                assignTeamNotification.MessageBody = assignTeamNotification?.MessageBody
                                    .Replace("{LicenseeName}", visit.LicensedEntityName.ToString())
                                    .Replace("{VisitDate}", visit.VisitDate.Value.ToString("dd-MMMM-yyyy"));

                                if (assignTeamNotification != null)
                                    notificationsResult.Add(assignTeamNotification);
                            }
                        }
                    }

                    //conflict of disclosure notifications
                    var disclosureConflictVisits = (await unitOfWork.ComplianceRequestRepository.GetVisitsByStatus((long)VisitStatusEnum.ConflictOfInterestDisclosure));

                    if (disclosureConflictVisits != null && disclosureConflictVisits.Model != null && disclosureConflictVisits.Model.Count() > 0)
                    {
                        foreach (var conflictedVisit in disclosureConflictVisits.Model)
                        {
                            var conflictSpecialists = conflictedVisit.ComplianceVisitSpecialists?.Where(vs => vs.ComplianceVisitDisclosure.HasConflicts).ToList();
                            foreach (var specialist in conflictSpecialists)
                            {
                                var conflictNotification = notifications.FirstOrDefault(s => s.Id == 27);

                                conflictNotification.MessageBody = conflictNotification?.MessageBody
                                    .Replace("{SpecialistName}", specialist.SpecialistUserName)
                                    .Replace("{LicenseeName}", conflictedVisit.LicensedEntityName)
                                    .Replace("[visit date]", conflictedVisit.VisitDate.Value.ToString("dd-MMMM-yyyy"));

                                if (conflictNotification != null)
                                    notificationsResult.Add(conflictNotification);
                            }
                        }
                    }

                    //no team member available for visit notifications
                    var noTeamVisits = (await unitOfWork.ComplianceRequestRepository.GetVisitsByStatus((long)VisitStatusEnum.NoTeamMemberAvailable));

                    if (noTeamVisits != null && noTeamVisits.Model != null && noTeamVisits.Model.Count() > 0)
                    {
                        foreach (var visit in noTeamVisits.Model)
                        {
                            var noTeamNotification = notifications.FirstOrDefault(s => s.Id == 28);

                            noTeamNotification.MessageBody = noTeamNotification?.MessageBody
                                .Replace("{VisitDate}", visit.VisitDate.Value.ToString("dd-MMMM-yyyy"))
                                .Replace("{LicenseeName}", visit.LicensedEntityName)
                                .Replace("{Reason}", "All specialists are busy");

                            if (noTeamNotification != null)
                                notificationsResult.Add(noTeamNotification);
                        }
                    }

                }

            }

            if (currentUserService.User.Role.Contains(RoleEnum.PerformanceMonitoringManager))
            {
                if (complianceRequest != null)
                {

                    if (complianceRequest.StatusId == (int)ComplianceStatusEnum.ReturnPlanOfComplianceManager)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 23);
                        if (notification != null)
                        {
                            var note = await unitOfWork.ComplianceRequestRepository.GetComplianceApproval(complianceRequest.Id);
                            notification.MessageBody = notification.MessageBody.Replace("{{ReturnReason}}", note.Model);
                            notificationsResult.Add(notification);

                        }

                    }

                    if (complianceRequest.StatusId == (int)ComplianceStatusEnum.ReturnPlanOfPerformanceMonitoringManager)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 24);
                        if (notification != null)
                        {
                            var note = await unitOfWork.ComplianceRequestRepository.GetComplianceApproval(complianceRequest.Id);
                            notification.MessageBody = notification.MessageBody.Replace("{{ReturnReason}}", note.Model);
                            notificationsResult.Add(notification);
                        }
                    }

                    if (complianceRequest.StatusId == (int)ComplianceStatusEnum.PendingReviewOfComplianceManager)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 43);
                        if (notification != null)
                            notificationsResult.Add(notification);
                    }

                    if (complianceRequest.StatusId == (int)ComplianceStatusEnum.PendingReviewOfPerformanceMonitoringManager)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 42);
                        if (notification != null)
                            notificationsResult.Add(notification);

                        if (complianceRequest.RemainingDays > 5)
                        {
                            notification = notifications.FirstOrDefault(s => s.Id == 10);
                            if (notification != null)
                                notificationsResult.Add(notification);

                        }


                        if (complianceRequest.RemainingDays == 2)
                        {
                            notification = notifications.FirstOrDefault(s => s.Id == 11);
                            if (notification != null)
                                notificationsResult.Add(notification);
                        }


                        if (complianceRequest.RemainingDays <= 0)
                        {
                            notification = notifications.FirstOrDefault(s => s.Id == 12);
                            if (notification != null)
                                notificationsResult.Add(notification);
                        }


                    }

                    if (complianceRequest.StatusId == (int)ComplianceStatusEnum.ComplianceSpecialistPreparingDelayed)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 39);
                        if (notification != null)
                            notificationsResult.Add(notification);
                    }

                    if (complianceRequest.StatusId == (int)ComplianceStatusEnum.ComplianceManagerOverdue)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 41);
                        if (notification != null)
                            notificationsResult.Add(notification);
                    }

                    if (complianceRequest.StatusId == (int)ComplianceStatusEnum.PeformanceMonitoringManagerOverdue)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 40);
                        if (notification != null)
                            notificationsResult.Add(notification);
                    }

                }

            }

            

        }


        return ResponseResult<List<ComplianceNotificationMessageDto>>.Success(notificationsResult);

    }
    public async Task<ResponseResult<ComplianceRequestDto>> GetComplianceRequest(ComplianceRequestFilterDto filter)
    {
        var result = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(filter);
        //if (result != null && result.Model != null)
        //{
        //    result.Model.ComplianceNotificationMessages = GetNotifications()?.Result?.Model;
        //}
        result.Model.ComplianceNotificationMessages = [];
        return result;
    }


    public async Task<ResponseResult<GetComplianceRequestStatusDto>> GetComplianceRequestStatus()
    {
        var compliance = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(null);
        return ResponseResult<GetComplianceRequestStatusDto>.Success(new GetComplianceRequestStatusDto()
        {
            LastSendDate = compliance?.Model?.LastSendDate,
            PlanName = compliance?.Model?.AssignTaskName,
            Status = compliance?.Model?.StatusId == (int)ComplianceStatusEnum.New ? new List<StateDto>()
            {
                new StateDto()
                {
                    IsApproved = true,
                    StatusName = compliance?.Model?.StatusName,
                }
            } :
            compliance?.Model?.StatusId == (int)ComplianceStatusEnum.ComplianceSpecialistPreparingDelayed ? new List<StateDto>()
            {
                new StateDto()
                {
                    IsApproved = false,
                    StatusName = compliance?.Model?.StatusName,
                }
            }:
            compliance?.Model?.StatusId == (int)ComplianceStatusEnum.PeformanceMonitoringManagerOverdue ? new List<StateDto>()
            {
                new StateDto()
                {
                    IsApproved = false,
                    StatusName = compliance?.Model?.StatusName,
                }
            } :
            compliance?.Model?.StatusId == (int)ComplianceStatusEnum.ComplianceManagerOverdue ? new List<StateDto>()
            {
                new StateDto()
                {
                    IsApproved = false,
                    StatusName = compliance?.Model?.StatusName,
                }
            } :
            compliance?.Model?.StatusId == (int)ComplianceStatusEnum.PendingReviewOfComplianceManager ? new List<StateDto>()
            {
                new StateDto()
                {
                    IsApproved = null,
                    StatusName = compliance?.Model?.StatusName,
                }
            } :
            compliance?.Model?.StatusId == (int)ComplianceStatusEnum.ApprovalOfTheComplianceManager ? new List<StateDto>()
            {
                new StateDto()
                {
                    IsApproved = true,
                    StatusName = compliance?.Model?.StatusName,
                }
            } :
            compliance?.Model?.StatusId == (int)ComplianceStatusEnum.ReturnPlanOfComplianceManager ? new List<StateDto>()
            {
                new StateDto()
                {
                    IsApproved = false,
                    StatusName = compliance?.Model?.StatusName,
                }
            } :

            compliance?.Model?.StatusId == (int)ComplianceStatusEnum.PendingReviewOfPerformanceMonitoringManager ? new List<StateDto>()
            {
                new StateDto()
                {
                    IsApproved = true,
                    StatusName = currentLanguageService.Language == LanguageEnum.En ? "Approved by Compliance Manager" :  "قبول مدير الادارة",
                },
                new StateDto()
                {
                    IsApproved = null,
                    StatusName = compliance?.Model?.StatusName,
                }
            } :
            compliance?.Model?.StatusId == (int)ComplianceStatusEnum.ApprovalOfPerformanceMonitoringManager ? new List<StateDto>()
            {
                new StateDto()
                {
                    IsApproved = true,
                    StatusName = currentLanguageService.Language == LanguageEnum.En ?  "Approved by Compliance Manager" : "قبول مدير الادارة",
                },
                new StateDto()
                {
                    IsApproved = true,
                    StatusName = compliance?.Model?.StatusName,
                }
            } :
            compliance?.Model?.StatusId == (int)ComplianceStatusEnum.ReturnPlanOfPerformanceMonitoringManager ? new List<StateDto>()
            {
                new StateDto()
                {
                    IsApproved = true,
                    StatusName = currentLanguageService.Language == LanguageEnum.En ? "Approved by Compliance Manager": "قبول مدير الادارة",
                },
                new StateDto()
                {
                    IsApproved = false,
                    StatusName = compliance?.Model?.StatusName,
                }
            } : new List<StateDto>()

        });
    }
    public async Task<ResponseResult<List<UserDto>>> GetComplianceSpecialist()
    {
        return await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.ComplianceSpecialist });
    }

    

  

    public async Task<ResponseResult<bool>> SaveCompliancePlan(CompliancePlanModel model)
    {
        var result = await unitOfWork.ComplianceRequestRepository.SaveCompliancePlan(model);
        await unitOfWork.CommitAsync();
        return result;
    }
    public async Task<ResponseResult<bool>> DeleteCompliancePlan(Guid planId)
    {
        var result = await unitOfWork.ComplianceRequestRepository.DeleteCompliancePlan(planId);
        await unitOfWork.CommitAsync();
        return result;
    }
    public async Task<ResponseResult<List<ComplianceActivityDto>>> GetComplianceActivities(Guid requestId)
    {
        return await unitOfWork.ComplianceRequestRepository.GetComplianceActivities(requestId);
    }
    public async Task<ResponseResult<bool>> SendComplianceRequest(Guid requestId)
    {
        var result = await unitOfWork.ComplianceRequestRepository.SendComplianceRequest(requestId);
        await unitOfWork.CommitAsync();

        await UpdateRemainingDays();
        if (result.Succeeded && !string.IsNullOrWhiteSpace(result.Model))
        {

            if (result.Model == RoleEnum.PerformanceMonitoringManager)
            {
                BackgroundJob.Enqueue(() => SendComplianceRequestForPerformanceMonitoringManager(currentUserService.User.UserName));
            }

            if (result.Model == RoleEnum.ComplianceManager)
            {
                BackgroundJob.Enqueue(() => SendComplianceRequestForPerformanceComplianceManager(currentUserService.User.UserName));
            }

        }
        return ResponseResult<bool>.Success(true);
    }
    public async Task SendComplianceRequestForPerformanceMonitoringManager(string senderName)
    {

        var request = (await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(null, isEmail: true)).Model;
        if (request != null)
        {
            var users = await unitOfWork.UserRepository.GetUsers(new List<string>());
            if (users != null && users.Model != null)
            {
                var templates = (await unitOfWork.TemplateRepository.GetTemplates(TemplateTypeEnum.Email)).Model;
                var template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.NewAnnualCompliancePlanSubmittedForReviewForComplianceManager);
                if (template != null)
                {

                    template.Content = template.Content.Replace("{{EmployeeName}}", "مدير عام مراقبة الاداء");
                    template.Content = template.Content.Replace("{{SenderName}}", senderName);
                    template.Content = template.Content.Replace("{{PlanTitle}}", request.AssignTaskName);
                    template.Content = template.Content.Replace("{{RequestNumber}}", request.Seq.ToString());
                    template.Content = template.Content.Replace("{{SubmissionDate}}", DateTime.Now.ToString("dd-MM-yyyy hh:mm tt"));
                    template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                    await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                    {
                        Subject = template.Subject,
                        Body = template.Content,
                        To = users.Model.Where(s => s.Roles.Contains(RoleEnum.PerformanceMonitoringManager)).Select(s => s.Email).ToList(),
                        CC = users.Model.Where(s => s.Roles.Contains(RoleEnum.ComplianceManager)).Select(s => s.Email).ToList(),
                    });
                }


                template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.SubmissionConfirmationForAnnualCompliancePlanForSpecialist);
                if (template != null)
                {

                    template.Content = template.Content.Replace("{{EmployeeName}}", "اخصائي الامتثال");
                    template.Content = template.Content.Replace("{{SenderName}}", senderName);
                    template.Content = template.Content.Replace("{{PlanTitle}}", request.AssignTaskName);
                    template.Content = template.Content.Replace("{{RequestNumber}}", request.Seq.ToString());
                    template.Content = template.Content.Replace("{{SubmissionDate}}", DateTime.Now.ToString("dd-MM-yyyy hh:mm tt"));
                    template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                    await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                    {
                        Subject = template.Subject,
                        Body = template.Content,
                        To = request.AssignedSpecialists.Select(s => s.SpecialistUserEmail).ToList(),
                    });
                }
            }

        }
    }

    public async Task SendComplianceRequestForPerformanceComplianceManager(string senderName)
    {
        var request = (await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(null, isEmail: true)).Model;
        if (request != null)
        {
            var complianceManagers = await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.ComplianceManager });
            if (complianceManagers != null && complianceManagers.Model != null)
            {
                var templates = (await unitOfWork.TemplateRepository.GetTemplates(TemplateTypeEnum.Email)).Model;
                var template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.NewAnnualCompliancePlanSubmittedForReviewForComplianceManager);
                if (template != null)
                {

                    template.Content = template.Content.Replace("{{EmployeeName}}", "مدير الادارة");
                    template.Content = template.Content.Replace("{{SenderName}}", senderName);
                    template.Content = template.Content.Replace("{{PlanTitle}}", request.AssignTaskName);
                    template.Content = template.Content.Replace("{{RequestNumber}}", request.Seq.ToString());
                    template.Content = template.Content.Replace("{{SubmissionDate}}", DateTime.Now.ToString("dd-MM-yyyy hh:mm tt"));
                    template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                    await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                    {
                        Subject = template.Subject,
                        Body = template.Content,
                        To = complianceManagers.Model.Select(s => s.Email).ToList(),
                    });
                }


                template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.SubmissionConfirmationForAnnualCompliancePlanForSpecialist);
                if (template != null)
                {

                    template.Content = template.Content.Replace("{{EmployeeName}}", "اخصائي الامتثال");
                    template.Content = template.Content.Replace("{{SenderName}}", senderName);
                    template.Content = template.Content.Replace("{{PlanTitle}}", request.AssignTaskName);
                    template.Content = template.Content.Replace("{{RequestNumber}}", request.Seq.ToString());
                    template.Content = template.Content.Replace("{{SubmissionDate}}", DateTime.Now.ToString("dd-MM-yyyy hh:mm tt"));
                    template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                    await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                    {
                        Subject = template.Subject,
                        Body = template.Content,
                        To = request.AssignedSpecialists.Select(s => s.SpecialistUserEmail).ToList(),
                    });
                }
            }

        }
    }
    public async Task<ResponseResult<bool>> ApproveComplianceRequestByComplianceManager(ApproveOrRejectComplianceRequestModel model)
    {
        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(null);
        if (request?.Model?.StatusId != (int)ComplianceStatusEnum.PendingReviewOfComplianceManager && request?.Model?.StatusId != (int)ComplianceStatusEnum.ComplianceManagerOverdue)
            throw new ValidationException(new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("Status", currentLanguageService.Language == LanguageEnum.En ? "Compliance Manager role only can be Approve" : "لا يمكن الموافقة الا من قبل مدير الاداره اولا") });

        model.Role = RoleEnum.ComplianceManager;
        model.IsApproved = true;
        var result = await unitOfWork.ComplianceRequestRepository.ApproveOrRejectComplianceRequest(model, ComplianceStatusEnum.PendingReviewOfPerformanceMonitoringManager);
        var sendResult = await unitOfWork.ComplianceRequestRepository.SendComplianceApprovalToPerformanceMonitoringManager(model.RequestId);
        await unitOfWork.CommitAsync();
        await UpdateRemainingDays();

        if (sendResult.Succeeded && !string.IsNullOrWhiteSpace(sendResult.Model))
        {
            BackgroundJob.Enqueue(() => ApproveComplianceRequestByComplianceManager(currentUserService.User.UserName));
        }
        return result;
    }

    public async Task ApproveComplianceRequestByComplianceManager(string senderName)
    {
        var request = (await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(null,isEmail: true)).Model;
        var users = await unitOfWork.UserRepository.GetUsers(new List<string>());
        if (users != null && users.Model != null)
        {
            var templates = (await unitOfWork.TemplateRepository.GetTemplates(TemplateTypeEnum.Email)).Model;
            var template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.AnnualCompliancePlanApprovedForComplianceSpecialist);
            if (template != null)
            {

                template.Content = template.Content.Replace("{{EmployeeName}}", "اخصائي الامتثال");
                template.Content = template.Content.Replace("{{SenderName}}", senderName);
                template.Content = template.Content.Replace("{{PlanTitle}}", request.AssignTaskName);
                template.Content = template.Content.Replace("{{RequestNumber}}", request.Seq.ToString());
                template.Content = template.Content.Replace("{{SubmissionDate}}", DateTime.Now.ToString("dd-MM-yyyy hh:mm tt"));
                template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Subject = template.Subject,
                    Body = template.Content,
                    To = request.AssignedSpecialists.Select(s => s.SpecialistUserEmail).ToList(),
                });
            }


            template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.AnnualCompliancePlanApprovedForComplianceManager);
            if (template != null)
            {

                template.Content = template.Content.Replace("{{EmployeeName}}", "مدير الادارة");
                template.Content = template.Content.Replace("{{SenderName}}", senderName);
                template.Content = template.Content.Replace("{{PlanTitle}}", request.AssignTaskName);
                template.Content = template.Content.Replace("{{RequestNumber}}", request.Seq.ToString());
                template.Content = template.Content.Replace("{{SubmissionDate}}", DateTime.Now.ToString("dd-MM-yyyy hh:mm tt"));
                template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Subject = template.Subject,
                    Body = template.Content,
                    To = users.Model.Where(s => s.Roles.Contains(RoleEnum.ComplianceManager)).Select(s => s.Email).ToList(),
                });
            }



            template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.NotificationOfPlanReceivedAfterDirectManagerApprovalForPerformanceMonitoringManager);
            if (template != null)
            {

                template.Content = template.Content.Replace("{{EmployeeName}}", "مدير عام مراقبة الاداء");
                template.Content = template.Content.Replace("{{SenderName}}", senderName);
                template.Content = template.Content.Replace("{{PlanTitle}}", request.AssignTaskName);
                template.Content = template.Content.Replace("{{RequestNumber}}", request.Seq.ToString());
                template.Content = template.Content.Replace("{{SubmissionDate}}", DateTime.Now.ToString("dd-MM-yyyy hh:mm tt"));
                template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Subject = template.Subject,
                    Body = template.Content,
                    To = users.Model.Where(s => s.Roles.Contains(RoleEnum.PerformanceMonitoringManager)).Select(s => s.Email).ToList(),
                });
            }

           
        }
    }

    public async Task<ResponseResult<bool>> ReturnComplianceRequestByComplianceManager(ApproveOrRejectComplianceRequestModel model)
    {
        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(null);
        if (request?.Model?.StatusId != (int)ComplianceStatusEnum.PendingReviewOfComplianceManager && request?.Model?.StatusId != (int)ComplianceStatusEnum.ComplianceManagerOverdue)
            throw new ValidationException(new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("Status", currentLanguageService.Language == LanguageEnum.En ? "Compliance Manager role only can be Return" : "لا يمكن الارجاع الا من قبل مدير الاداره اولا") });


        model.IsApproved = false;
        model.Role = RoleEnum.ComplianceManager;
        var result = await unitOfWork.ComplianceRequestRepository.ApproveOrRejectComplianceRequest(model, ComplianceStatusEnum.ReturnPlanOfComplianceManager);
        await unitOfWork.CommitAsync();
        await UpdateRemainingDays();

        if (result.Succeeded)
            BackgroundJob.Enqueue(() => ReturnComplianceRequestByComplianceManager(currentUserService.User.UserName));

        return result;

    }

    public async Task ReturnComplianceRequestByComplianceManager(string senderName)
    {
        var request = (await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(null,isEmail: true))?.Model;
        var complianceManager = await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.ComplianceManager });
        if (complianceManager != null && complianceManager.Model != null)
        {
            var templates = (await unitOfWork.TemplateRepository.GetTemplates(TemplateTypeEnum.Email)).Model;
            var template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.AnnualCompliancePlanReturnedForModificationsForComplianceSpecialist);
            if (template != null)
            {

                template.Content = template.Content.Replace("{{EmployeeName}}", "اخصائي الامتثال");
                template.Content = template.Content.Replace("{{SenderName}}", senderName);
                template.Content = template.Content.Replace("{{PlanTitle}}", request.AssignTaskName);
                template.Content = template.Content.Replace("{{RequestNumber}}", request.Seq.ToString());
                template.Content = template.Content.Replace("{{SubmissionDate}}", DateTime.Now.ToString("dd-MM-yyyy hh:mm tt"));
                template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Subject = template.Subject,
                    Body = template.Content,
                    To = request.AssignedSpecialists.Select(s => s.SpecialistUserEmail).ToList(),
                    CC = complianceManager.Model.Select(s => s.Email).ToList()
                });
            }

   
        }
    }

    public async Task<ResponseResult<bool>> ApproveComplianceRequestByPerformanceMonitoringManager(ApproveOrRejectComplianceRequestModel model)
    {
        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(null);
        if (request?.Model?.StatusId != (int)ComplianceStatusEnum.PendingReviewOfPerformanceMonitoringManager && request?.Model?.StatusId != (int)ComplianceStatusEnum.PeformanceMonitoringManagerOverdue)
            throw new ValidationException(new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("Status", currentLanguageService.Language == LanguageEnum.En ? "Performance Monitoring Manager role only can be Approve" : "لا يمكن الموافقة الا من قبل مدير مراقبة الاداء اولا") });


        model.Role = RoleEnum.PerformanceMonitoringManager;
        model.IsApproved = true;
        var result = await unitOfWork.ComplianceRequestRepository.ApproveOrRejectComplianceRequest(model, ComplianceStatusEnum.ApprovalOfPerformanceMonitoringManager);
        await unitOfWork.CommitAsync();
        await UpdateRemainingDays();


        BackgroundJob.Enqueue(() => ApproveComplianceRequestByPeformanceMonitoringManager(currentUserService.User.UserName));

        return result;

    }

    public async Task ApproveComplianceRequestByPeformanceMonitoringManager(string senderName)
    {
        var request = (await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(null, isEmail: true)).Model;
        var users = await unitOfWork.UserRepository.GetUsers(new List<string>());
        if (users != null && users.Model != null)
        {
            var templates = (await unitOfWork.TemplateRepository.GetTemplates(TemplateTypeEnum.Email)).Model;
            var template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.AnnualCompliancePlanApprovedByPerformanceMonitoringManagerForComplianceSpecialist);
            if (template != null)
            {

                template.Content = template.Content.Replace("{{EmployeeName}}", "اخصائي الامتثال");
                template.Content = template.Content.Replace("{{SenderName}}", senderName);
                template.Content = template.Content.Replace("{{PlanTitle}}", request.AssignTaskName);
                template.Content = template.Content.Replace("{{RequestNumber}}", request.Seq.ToString());
                template.Content = template.Content.Replace("{{SubmissionDate}}", DateTime.Now.ToString("dd-MM-yyyy hh:mm tt"));
                template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Subject = template.Subject,
                    Body = template.Content,
                    To = request.AssignedSpecialists.Select(s => s.SpecialistUserEmail).ToList(),
                });
            }


            template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.AnnualCompliancePlanApprovedByPerformanceMonitoringManagerForComplianceManager);
            if (template != null)
            {

                template.Content = template.Content.Replace("{{EmployeeName}}", "مدير الادارة");
                template.Content = template.Content.Replace("{{SenderName}}", senderName);
                template.Content = template.Content.Replace("{{PlanTitle}}", request.AssignTaskName);
                template.Content = template.Content.Replace("{{RequestNumber}}", request.Seq.ToString());
                template.Content = template.Content.Replace("{{SubmissionDate}}", DateTime.Now.ToString("dd-MM-yyyy hh:mm tt"));
                template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Subject = template.Subject,
                    Body = template.Content,
                    To = users.Model.Where(s => s.Roles.Contains(RoleEnum.ComplianceManager)).Select(s => s.Email).ToList(),
                });
            }



            template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.AnnualCompliancePlanApprovedByPerformanceMonitoringManagerForComplianceManager);
            if (template != null)
            {

                template.Content = template.Content.Replace("{{EmployeeName}}", "مدير عام مراقبة الاداء");
                template.Content = template.Content.Replace("{{SenderName}}", senderName);
                template.Content = template.Content.Replace("{{PlanTitle}}", request.AssignTaskName);
                template.Content = template.Content.Replace("{{RequestNumber}}", request.Seq.ToString());
                template.Content = template.Content.Replace("{{SubmissionDate}}", DateTime.Now.ToString("dd-MM-yyyy hh:mm tt"));
                template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Subject = template.Subject,
                    Body = template.Content,
                    To = users.Model.Where(s => s.Roles.Contains(RoleEnum.PerformanceMonitoringManager)).Select(s => s.Email).ToList(),
                });
            }



            template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.AnnualScheduledVisitsNoticeForLicensedEntity);
            if (template != null)
            {

                template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Subject = template.Subject,
                    Body = template.Content,
                    To = users.Model.Where(s => s.Roles.Contains(RoleEnum.LicensedEntity)).Select(s => s.Email).ToList(),
                });
            }
        }
    }

    public async Task<ResponseResult<bool>> ReturnComplianceRequestByPerformanceMonitoringManager(ApproveOrRejectComplianceRequestModel model)
    {
        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(null);
        if (request?.Model?.StatusId != (int)ComplianceStatusEnum.PendingReviewOfPerformanceMonitoringManager && request?.Model?.StatusId != (int)ComplianceStatusEnum.PeformanceMonitoringManagerOverdue)
            throw new ValidationException(new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("Status", currentLanguageService.Language == LanguageEnum.En ? "Performance Monitoring Manager role only can be Returned" : "لا يمكن الارجاع الا من قبل مدير مراقبة الاداء اولا") });


        model.IsApproved = false;
        model.Role = RoleEnum.PerformanceMonitoringManager;
        var result = await unitOfWork.ComplianceRequestRepository.ApproveOrRejectComplianceRequest(model, ComplianceStatusEnum.ReturnPlanOfPerformanceMonitoringManager);
        await unitOfWork.CommitAsync();
        await UpdateRemainingDays();

        if (result.Succeeded)
            BackgroundJob.Enqueue(() => ReturnComplianceRequestByPerformanceMonitoringManager(currentUserService.User.UserName));
        return result;

    }

    public async Task ReturnComplianceRequestByPerformanceMonitoringManager(string senderName)
    {
        var request = (await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(null,isEmail: true)).Model;
        var users = await unitOfWork.UserRepository.GetUsers(new List<string>());
        if (users != null && users.Model != null)
        {
            var templates = (await unitOfWork.TemplateRepository.GetTemplates(TemplateTypeEnum.Email)).Model;
            var template = templates?.FirstOrDefault(s => s.Id == (long)TemplateEnum.AnnualCompliancePlanReturnedForModificationsByPeformanceMentoringManagerForComplianceSpecialistAndComplianceManager);
            if (template != null)
            {

                template.Content = template.Content.Replace("{{EmployeeName}}", "اخصائي الامتثال");
                template.Content = template.Content.Replace("{{SenderName}}", senderName);
                template.Content = template.Content.Replace("{{PlanTitle}}", request.AssignTaskName);
                template.Content = template.Content.Replace("{{RequestNumber}}", request.Seq.ToString());
                template.Content = template.Content.Replace("{{SubmissionDate}}", DateTime.Now.ToString("dd-MM-yyyy hh:mm tt"));
                template.Content = template.Content.Replace("{{ActionUrl}}", "https://apptest.swcc.gov.sa/compliance/tasks");

                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Subject = template.Subject,
                    Body = template.Content,
                    To = request.AssignedSpecialists.Select(s => s.SpecialistUserEmail).ToList(),
                    CC = users.Model.Where(s => s.Roles.Contains(RoleEnum.ComplianceManager) || s.Roles.Contains(RoleEnum.PerformanceMonitoringManager)).Select(s => s.Email).ToList()
                });
            }
        }
    }


    #region phase 2

    public async Task SendQuarterlyNotificationsToScheduleComplianceVisitsAsync()
    {
        var today = DateTime.UtcNow.Date;
        var notificationDates = new List<DateTime>
        {
            //today,
            new DateTime(today.Year, 1, 1).AddDays(-7),
            new DateTime(today.Year, 4, 1).AddDays(-7),
            new DateTime(today.Year, 7, 1).AddDays(-7),
            new DateTime(today.Year, 10, 1).AddDays(-7),
        };

        if (!notificationDates.Contains(today)) return;

        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(null,isEmail: true);
        var complianceManagers = await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.ComplianceManager });

        string currentMonthName = DateTime.Now.ToString("MMMM");

        var quarterName = request.Model?.CompliancePlans?.Where(p => p.QuarterPlannedForVisitNameEn.Contains(currentMonthName)).FirstOrDefault()?.QuarterPlannedForVisitName;

        var quarterNameEnForPendingVisits = request.Model?.CompliancePlans?.Where(p => p.QuarterPlannedForVisitNameEn.Contains(currentMonthName)).FirstOrDefault()?.QuarterPlannedForVisitNameEn;
        quarterNameEnForPendingVisits = string.Join(" ", quarterNameEnForPendingVisits.Split(' ', StringSplitOptions.RemoveEmptyEntries).Take(2));


        int? pendingVists = request.Model?.CompliancePlans?.Where(p =>
            p.QuarterPlannedForVisitNameEn.StartsWith(quarterNameEnForPendingVisits)
        ).Count();

        if (complianceManagers != null && complianceManagers.Model != null && pendingVists != null && pendingVists > 0)
        {
            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
            {
                Content = new Dictionary<string, object>() { { "EmployeeName", "مدير الادارة" }, { "QuarterName", quarterName }, { "RequestNumber", request.Model.Seq }, { "PendingVisits", pendingVists }, { "ActionUrl", "#" } },
                ViewName = "QuarterlyVisitSchedule.cshtml",
                Subject = "مطلوب جدولة الزيارة ربع السنوية",
                To = complianceManagers.Model.Select(s => s.Email).ToList(),
                CC = request.Model.AssignedSpecialists.Select(s => s.SpecialistUserEmail).ToList()
            });
        }
    }

    public async Task<ResponseResult<CompliancePlanDto>> GetComplianceVisitDetail(Guid id)
    {
        var result = await unitOfWork.ComplianceRequestRepository.GetComplianceVisitDetail(id);
        return result;
    }

    public async Task<ResponseResult<List<ComplianceSpecialistDto>>> GetComplianceRequestSpecialists(Guid visitId)
    {
        var result = await unitOfWork.ComplianceRequestRepository.GetComplianceRequestSpecialists(visitId);
        return result;
    }

    public async Task<ResponseResult<bool>> SaveComplianceVisit(ComplianceVisitModel model, long? VisitStatusId = null)
    {
        var result = await unitOfWork.ComplianceRequestRepository.SaveComplianceVisit(model, VisitStatusId);
        await unitOfWork.CommitAsync();

        if (result.Succeeded)
            BackgroundJob.Enqueue(() => NotifyComplianceManagerOnSaveVisitSchedule(model.Id));

        return result;
    }

    public async Task NotifyComplianceManagerOnSaveVisitSchedule(Guid complianceDetailId)
    {
        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(null,isEmail: true);
        var complianceManagers = await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.ComplianceManager });
        var visit = request?.Model?.CompliancePlans?.FirstOrDefault(cp => cp.Id.Equals(complianceDetailId));

        if (visit.VisitStatusId.Equals((long)VisitStatusEnum.New) && complianceManagers != null && complianceManagers.Model != null)
        {
            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
            {
                Content = new Dictionary<string, object>() {
                    { "EmployeeName", "مدير الادارة" },
                    { "VisitId", visit.VisitReferenceNumber },
                    { "VisitDate", visit.VisitDate },
                    { "LicenseeName", visit.LicensedEntityName },
                    { "VisitType", visit.VisitTypeName },
                    { "VisitLocation", visit.LocationName },
                    { "DesignedCapacity", visit.DesignedCapacity },
                    { "ActionUrl", "#" }
                },
                ViewName = "VisitTeamAssignment.cshtml",
                Subject = $"إشعار الزيارة القادمة – {visit.LicensedEntityName}",
                To = complianceManagers.Model.Select(s => s.Email).ToList(),
            });
        }
    }

    public async Task SendUpcomingVisitNotificationsEmailAsync()
    {
        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(null,isEmail: true);
        var complianceManagers = await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.ComplianceManager });
        var complianceVisits = request?.Model?.CompliancePlans?.Where(cp => !string.IsNullOrEmpty(cp.VisitReferenceNumber));

        foreach (var visit in complianceVisits)
        {
            if (visit == null || visit.VisitDate == null)
                return; // No visit

            // Check if today is exactly 10 days before the visit date
            var daysUntilVisit = (visit.VisitDate?.Date - DateTime.Today)?.TotalDays;

            if (daysUntilVisit != 10)
                return;

            if (complianceManagers != null && complianceManagers.Model != null)
            {
                var visitSpecialists = (await unitOfWork.ComplianceRequestRepository.GetComplianceVisitSpecialists(visit.Id));
                List<string> listCC = visitSpecialists != null && visitSpecialists.Model != null ? visitSpecialists.Model.Select(s => s.SpecialistUserEmail).ToList() : new List<string>();

                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Content = new Dictionary<string, object>() {
                    { "EmployeeName", "مدير الادارة" },
                    { "VisitId", visit.VisitReferenceNumber },
                    { "VisitDate", visit.VisitDate },
                    { "LicenseeName", visit.LicensedEntityName },
                    { "VisitType", visit.VisitTypeName },
                    { "VisitLocation", visit.LocationName },
                    { "DesignedCapacity", visit.DesignedCapacity },
                    { "ActionUrl", "#" }
                },
                    ViewName = "VisitSchedule.cshtml",
                    Subject = "إشعار الزيارة القادمة",
                    To = complianceManagers.Model.Select(s => s.Email).ToList(),
                    CC = listCC
                });
            }
        }
    }
     
    public async Task SendUpcomingVisitNotificationsSMSAsync()
    {
        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(null,isEmail: true);
        var complianceManagers = await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.ComplianceManager });
        var complianceVisits = request?.Model?.CompliancePlans?.Where(cp => !string.IsNullOrEmpty(cp.VisitReferenceNumber));

        foreach (var visit in complianceVisits)
        {
            if (visit == null || visit.VisitDate == null)
                return; // No visit

            // Check if today is exactly 10 days before the visit date
            var daysUntilVisit = (visit.VisitDate?.Date - DateTime.Today)?.TotalDays;

            if (daysUntilVisit != 10)
                return;

            List<string> listSendTo = complianceManagers?.Model?
                            .Where(c => !string.IsNullOrEmpty(c.MobileNumber))
                            .Select(s => s.MobileNumber).ToList() ?? new List<string>();

            var visitSpecialists = (await unitOfWork.ComplianceRequestRepository.GetComplianceVisitSpecialists(visit.Id));

            if (visitSpecialists != null && visitSpecialists.Model != null)
                listSendTo = listSendTo.Concat(visitSpecialists.Model.Select(s => s.MobileNumber).ToList()).ToList();

            if (listSendTo != null && listSendTo.Count() > 0)
            {
                string messageBody = "Upcoming Visit Notification\r\n\r\nDear {EmployeeName},\r\n\r\nA visit has been scheduled as part of the Annual Compliance Plan. Please ensure all preparations are completed.\r\nVisit Details:\r\n\r\nVisit ID: {VisitID}\r\nVisit Date: {VisitDate}\r\nLicensee Name: {LicenseeName}\r\nVisit Type: {VisitType}\r\nVisit Location: {VisitLocation}\r\nDesigned Capacity: {DesignedCapacity} (m3/day)\r\n[Link to manage the visit]: {ActionUrl}.\r\n\r\nBest regards,\r\n[The Saudi Water Authority]\r\n";

                var content = new Dictionary<string, string>() {
                     { "{EmployeeName}", "مدير الادارة" },
                     { "{VisitID}", visit.VisitReferenceNumber.ToString() },
                     { "{VisitDate}", visit.VisitDate.ToString() },
                     { "{LicenseeName}", visit.LicensedEntityName.ToString() },
                     { "{VisitType}", visit.VisitTypeName.ToString() },
                     { "{VisitLocation}", visit.LocationName.ToString() },
                     { "{DesignedCapacity}", visit.DesignedCapacity.ToString() },
                     { "{ActionUrl}", "#" }
                };

                foreach (var pair in content)
                {
                    messageBody = messageBody.Replace(pair.Key, pair.Value ?? string.Empty);
                }

                await notificationService(NotificationTypeEnum.SMS).SendAsync(
                    new NotificationMessageModel()
                    {
                        To = listSendTo,
                        Body = messageBody,
                    }
                );
            }
        }
    }

    public async Task<ResponseResult<bool>> AssignComplianceVisitSpecialists(AssignComplianceVisitSpecialistModel model)
    {
        var result = await unitOfWork.ComplianceRequestRepository.AssignComplianceVisitSpecialists(model);
        if (result.Succeeded)
        {
            await unitOfWork.CommitAsync();
            BackgroundJob.Enqueue(() =>
                NotifyAssignedAndConflictedComplianceVisitSpecialist(result.Model, model.ComplianceDetailsId));
            return ResponseResult<bool>.Success(true);
        }
        else
            return ResponseResult<bool>.Failure(result.Errors, false);
    }

    public async Task NotifyAssignedAndConflictedComplianceVisitSpecialist(AssignComplianceVisitSpecialistResponseModel result, Guid visitId)
    {
         var visit = (await unitOfWork.ComplianceRequestRepository.GetComplianceVisitDetail(visitId)).Model;

        var allUsers = (await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.ComplianceSpecialist })).Model;
        if (allUsers != null && allUsers != null)
        {
            var newlyAssignedUsers = allUsers.Where(s => result.NotifyNewUsers.Contains(s.Id)).ToList();

            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
            {
                Content = new Dictionary<string, object>() {
                    { "EmployeeName", "اخصائي الالتزام" },
                    { "VisitId", visit.VisitReferenceNumber },
                    { "VisitDate", visit.VisitDate },
                    { "LicenseeName", visit.LicensedEntityName },
                    { "VisitType", visit.VisitTypeName },
                    { "VisitLocation", visit.LocationName },
                    { "DesignedCapacity", visit.DesignedCapacity },
                    { "ActionUrl", "#" }
                },
                ViewName = "AssignVisitSpecialists.cshtml",
                Subject = "إشعار تعيين الفريق",
                To = newlyAssignedUsers.Where(s => s.Roles.Contains(RoleEnum.ComplianceSpecialist)).Select(s => s.Email).ToList(),
            });

            if (result.IsUpdate && result.NotifyConflictUsers != null && result.NotifyConflictUsers.Count() > 0)
            {
                var removedDueToConflictUsers = allUsers.Where(s => result.NotifyConflictUsers.Contains(s.Id)).ToList();

                foreach (var conflictedUser in removedDueToConflictUsers)
                {
                    await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                    {
                        Content = new Dictionary<string, object>() {
                            { "EmployeeName", $"اخصائي الالتزام" },
                            { "SpecialistUserName", conflictedUser.UserName},
                            { "Reason", "Conflict of Interest"},
                            { "VisitId", visit.VisitReferenceNumber },
                            { "VisitDate", visit.VisitDate },
                            { "LicenseeName", visit.LicensedEntityName },
                            { "VisitType", visit.VisitTypeName },
                            { "VisitLocation", visit.LocationName },
                            { "DesignedCapacity", visit.DesignedCapacity },
                            { "ActionUrl", "#" }
                        },
                        ViewName = "DisclosureConflictVisitSpecialists.cshtml",
                        Subject = "تم فصل أخصائي الامتثال بسبب تضارب المصالح.",
                        To = new List<string> { conflictedUser.Email },
                    });
                }
            }
        }
    }

    #region Part03-05
    private void ValidateVisitAttachments(List<IFormFile> visitAttachments)
    {
        List<KeyValuePair<string, string>> businessRules = [];

        if (visitAttachments != null)
        {
            if (visitAttachments.Count > 8)
                businessRules.Add(new KeyValuePair<string, string>("visitsAttachments", "عدد الملفات يجب ان تكون اقل من او تساوي 8 ملفات"));
            else
            {
                foreach (var item in visitAttachments)
                {
                    string[] splittedString = item.FileName.Split('.');
                    var extension = splittedString[splittedString.Length - 1];

                    if (!(extension.Equals("pdf", StringComparison.CurrentCultureIgnoreCase) || extension.ToLower() == "png" || extension.ToLower() == "jpg" || extension.ToLower() == "jpeg"))
                        businessRules.Add(new KeyValuePair<string, string>("visitsAttachments", "برجاء رفع الملف المرفق  بامتداد  png او jpg"));

                    if (item.Length > 5 * 1024 * 1024)
                        businessRules.Add(new KeyValuePair<string, string>("RequestAttachments", " MBالملف المرفق  يجب ان تكون مساحتها اقل من 5 "));

                }
            }
        }
        if (businessRules.Count > 0) throw new ValidationException(businessRules);
    }
    public async Task<ResponseResult<bool>> AddVisitAttachment(List<IFormFile> visitAttachments, Guid complianceDetailsId)
    {
        ValidateVisitAttachments(visitAttachments);
        if (currentUserService.User.Role.Any(s => s.Contains(RoleEnum.LicensedEntity)))
        {
            if (visitAttachments.Count > 0)
            {
                foreach (var file in visitAttachments)
                {
                    var attachmentGuid = Guid.NewGuid().ToString();
                    var attachment = new Attachment
                    {
                        AttachmentGuid = attachmentGuid,
                        AttachmentName = $"{file.FileName}",
                        EntityId = complianceDetailsId,
                        EntityName = AttachmentEntityEnum.VisitAttachment,
                        AttachmentTypeId = (long)AttachmentTypeEnum.VisitAttachment
                    };

                    List<KeyValuePair<Stream, string>> attachemnts = new List<KeyValuePair<Stream, string>>();
                    var fileSplitted = attachment.AttachmentName.Split('.');
                    string fileExtension = fileSplitted[fileSplitted.Length - 1];

                    string dir = attachmentService.GetMappedDirectory(AttachmentEntityEnum.VisitAttachment, new Dictionary<string, string>() { { "ComplianceDetailsID", complianceDetailsId.ToString() } });
                    dir += $"/{attachmentGuid}.{fileExtension}";
                    attachemnts.Add(new KeyValuePair<Stream, string>(file.OpenReadStream(), dir));

                    attachmentService.UploadAttachment(attachemnts);
                    await unitOfWork.AttachmentRepository.AddAttachment(attachment);
                    await unitOfWork.CommitAsync();


                    await SendNotificationToLicensedEntityforUploadDocument(complianceDetailsId, currentUserService.User.UserName);
                    await SendSMSUploadAttachmentSecsessed(complianceDetailsId);
                }
            }
        }

        
        return ResponseResult<bool>.Success(true);
    }
    public async Task<AttachmentDto> DownloadAttachmentForAttachmentId(Guid attachmentId)
    {
        var record = await unitOfWork.AttachmentRepository.GetAttachmentById(attachmentId);
        if (record != null)
        {
            var fileSplitted = record.AttachmentName.Split('.');
            string fileExtension = fileSplitted[fileSplitted.Length - 1];
            string dir = attachmentService.GetMappedDirectory(record.EntityName, new Dictionary<string, string>() { { "ComplianceDetailsID", record.EntityId.ToString() } });
            dir += $"/{record.AttachmentGuid}.{fileExtension}";
            record.Content = attachmentService.DownloadAttachment(dir);

            return record;

        }
        throw new ValidationException(new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("message", "لم يتم العثور علي هذا الملف ") });

    }
    public async Task SendSMSUploadAttachmentSecsessed(Guid ComplianceDetailsID)
    {
        var complianceVisits = unitOfWork.ComplianceRequestRepository.GetComplianceVisit()?.Result?.Model?.Where(s => s.Id == ComplianceDetailsID).FirstOrDefault();
        var LicensedEntity = unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.LicensedEntity }).Result.Model?.ToList();

        if (LicensedEntity != null)
        {
            var _LicensedEntityId = complianceVisits?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !string.IsNullOrEmpty(c.MobileNumber) & c.Id == _LicensedEntityId).FirstOrDefault();
            var mobileNumbers = new List<string> { SendTo?.MobileNumber ?? "" };

            if (SendTo != null)
            {
                string messageBody = $"Your documents for the compliance visit on {complianceVisits?.VisitDate?.ToShortDateString()} have been successfully uploaded.Thank you.Best regards,[The Saudi Water Authority]";

                var content = new Dictionary<string, string>() {
                     { "{VisitDate}", complianceVisits?.VisitDate?.ToShortDateString() ?? ""},
                };

                foreach (var pair in content)
                {
                    messageBody = messageBody.Replace(pair.Key, pair.Value ?? string.Empty);
                }

                await notificationService(NotificationTypeEnum.SMS).SendAsync(
                    new NotificationMessageModel()
                    {
                        To = mobileNumbers,
                        Body = messageBody,
                    }
                );
            }
        }
    }
    public async Task<ResponseResult<bool>> SendNotificationToLicensedEntityforUploadDocument(Guid ComplianceDetailsID, string senderName)
    {
        var request = unitOfWork.ComplianceRequestRepository.GetComplianceVisit()?.Result?.Model?.Where(s => s.Id == ComplianceDetailsID).FirstOrDefault();
        var LicensedEntity = unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.LicensedEntity }).Result.Model?.ToList();

        
            var _LicensedEntityId = request?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !string.IsNullOrEmpty(c.Email) & c.Id == _LicensedEntityId).FirstOrDefault();
            var LicensedEmail = new List<string> { SendTo?.Email ?? "" };

        if (SendTo != null)
        {
            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
            {
                Content = new Dictionary<string, object>() {
                    { "EmployeeName", request?.LicensedEntityName ?? ""},
                    { "VisitNumber", request?.VisitReferenceNumber ?? ""},
                    { "LicensedEntityName", request?.LicensedEntityName ?? ""},
                    { "SubmissionDate", DateTime.Now.ToShortDateString() },
                    { "ActionUrl", "#" }
                },
                Body = $" تم تحميل المستندات الخاصة بزيارةالإمتثال بتاريخ {request?.VisitDate?.ToShortDateString()} بنجاح شكراً لك.",
                ViewName = "SubmitDocumentForm.cshtml",
                Subject = "تحميل المستندات الخاصة بزيارة الإمتثال",
                To = LicensedEmail
            });
            return ResponseResult<bool>.Success(true);
        }
        return ResponseResult<bool>.Success(false);
    }
    
    
    // no doc upload 
    public async Task SendNotificationToComplianceManagerforNoDocumentsSubmitted()
    {
        var request = unitOfWork.ComplianceRequestRepository.GetComplianceVisit()?.Result?.Model?.ToList();
        var complianceManagers = await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.ComplianceManager });
        var complianceVisits = request?.Where(cp => !string.IsNullOrEmpty(cp.VisitReferenceNumber) & cp.IsDeleted != true);

        if (complianceVisits?.Count() > 0)
        {
            foreach (var visit in complianceVisits)
            {
                if (visit == null || visit.VisitDate == null)
                    continue;

                DateTime visitDate = visit.VisitDate.Value.Date;
                DateTime escalationDate = BusinessDays(visitDate, 3);

                if (DateTime.Today < escalationDate)
                    continue;

                // GetVisitDocuments for visit
                var Doc = visit?.VisitDocuments?.ToList();
                bool hasDocuments = Doc != null && Doc.Any();
                if (hasDocuments)
                    continue; // Documents already submitted

                // Build recipients (compliance managers)
                List<string> listSendTo = complianceManagers?.Model?
                            .Where(c => !string.IsNullOrEmpty(c.MobileNumber))
                            .Select(s => s.MobileNumber)
                            .Distinct()
                            .ToList() ?? new List<string?>();

                if (listSendTo.Count != 0)
                {
                    await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                    {
                        Content = new Dictionary<string, object>()
                        {
                    { "EmployeeName", "مدير الإإمتثال"},
                    { "VisitNumber", visit?.VisitReferenceNumber ?? ""},
                    { "LicensedEntityName", visit?.LicensedEntityName ?? ""},
                    { "ActionUrl", "#" }
                        },

                        Body = $"بتسليم المستندات المطلوبة لزيارة الالتزام المجدولة بتاريخ {visit?.VisitDate?.ToShortDateString()}.\r\nيرجى متابعة الجهة المرخصة فورًا بهذا الشأن.\"; عزيزي مدير الإمتثال،لم تقم الجهة المرخصة {visit?.LicensedEntityName}",
                        ViewName = "SubmitDocumentForm.cshtml",
                        Subject = "عدم تقديم مستندات الزيارة",
                        To = complianceManagers?.Model?.Select(s => s.Email).ToList() ?? new List<string>()
                    });
                    await SendSMSToComplianceManagerforNoDocumentsSubmitted(visit?.Id ?? new Guid());
                }
            }
        }
    }
    public async Task SendSMSToComplianceManagerforNoDocumentsSubmitted(Guid ComplianceDetailsID)
    {
        var complianceVisits = unitOfWork.ComplianceRequestRepository.GetComplianceVisit().Result.Model?.Where(a => a.Id == ComplianceDetailsID);
        var ComplianceManager = unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.ComplianceManager }).Result.Model;

        if (complianceVisits != null & complianceVisits?.Count() > 0)
        {
            foreach (var visit in complianceVisits)
            {
                string messageBody = $"Entity {visit.LicensedEntityName} failed to upload required documents for visit on {visit.VisitDate}. Please follow up\r\n Best regards,\r\n";
                var content = new Dictionary<string, string>() {

                     { "{VisitDate}", visit?.VisitDate?.ToShortDateString() ?? ""},
                     { "{LicenseeName}", visit?.LicensedEntityName ?? ""},
                };

                foreach (var pair in content)
                {
                    messageBody = messageBody.Replace(pair.Key, pair.Value ?? string.Empty);
                }

                await notificationService(NotificationTypeEnum.SMS).SendAsync(
                new NotificationMessageModel()
                {
                    To = ComplianceManager?.Select(s => s.Email).ToList() ?? [],
                    Body = messageBody,
                }
                );
            }
        }
    }
    public async Task<ResponseResult<ComplianceDetailsDto>>? GetComplianceVisitByComplianceDetailsID(Guid ComplianceDetailsID)
    {
        var result = await unitOfWork.ComplianceRequestRepository.GetComplianceVisit();

        if (result != null && result.Model != null)
        {
            var res = result.Model.Where(a => a.Id == ComplianceDetailsID).FirstOrDefault();
            return ResponseResult<ComplianceDetailsDto>.Success(res);
        }
        else
            return null;
    }
    public async Task<ResponseResult<List<ComplianceDetailsDto>>> GetComplianceVisit()
        => await unitOfWork.ComplianceRequestRepository.GetComplianceVisit();
    public async Task<ResponseResult<DocumentExtensionRequestDto>> AddExtensionRequest(ExtensionRequestModel request)
    {
        var res = unitOfWork.ComplianceRequestRepository.AddExtensionRequest(request)?.Result;
        if (!res.Succeeded)
            throw new Exception("Can't Add Extension Request");
        else
            await SendNotifycationToEntityforExtensionRequestSubmitted(res.Model.Id);
        await SendNotifycationToManagerRequestSubmitted(res.Model.Id);
        return res;

    }
    public async Task SendNotificationToEntityforExtensionRequestApproved(Guid RequestID)
    {
        var request = unitOfWork.ComplianceRequestRepository.GetExtensionRequest(RequestID)?.Result?.Model;
        var LicensedEntity = unitOfWork.UserRepository.GetUsers([RoleEnum.LicensedEntity]).Result.Model?.ToList();
        var visit = GetComplianceVisit().Result?.Model?.FirstOrDefault(x => x.Id == request.ComplianceDetailsID);

        if (LicensedEntity != null)
        {
            var _LicensedEntityId = request?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !string.IsNullOrEmpty(c.Email) & c.Id == _LicensedEntityId).FirstOrDefault();
            var LicensedEmail = new List<string> { SendTo?.Email ?? "" };

            if (SendTo != null)
            {
                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Content = new Dictionary<string, object>() {
                    { "EmployeeName", currentUserService.User.UserName ?? ""},
                    { "VisitNumber", request?.ComplianceDetails?.VisitReferenceNumber ?? ""},
                    { "LicensedEntityName", currentUserService.User.UserName ?? ""},
                    { "SubmissionDate", DateTime.Now.ToShortDateString() },
                    { "ActionUrl", "#" }
                },
                    Body = $"Dear {currentUserService.User.UserName}, Your request for an extension of {request?.RequestedDays} days has been approved. The new deadline for submission is {visit?.VisitDate?.ToShortDateString()}.",
                    ViewName = "SubmitExtensionRequestForm.cshtml",
                    Subject = "تم قبول طلب التمديد",
                    To = LicensedEmail
                });
            }
        }
    }
    public async Task SendNotifycationToEntityforExtensionRequestSubmitted(Guid RequestID)
    {
        var request = unitOfWork.ComplianceRequestRepository.GetExtensionRequest(RequestID)?.Result?.Model;
        var LicensedEntity = unitOfWork.UserRepository.GetUsers([RoleEnum.LicensedEntity]).Result.Model?.ToList();
        var visit = GetComplianceVisit().Result?.Model?.FirstOrDefault(x => x.Id == request.ComplianceDetailsID);

        if (LicensedEntity != null)
        {
            var _LicensedEntityId = request?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !string.IsNullOrEmpty(c.Email) & c.Id == _LicensedEntityId).FirstOrDefault();
            var LicensedEmail = new List<string> { SendTo?.Email ?? "" };

            if (SendTo != null)
            {
                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Content = new Dictionary<string, object>() {
                    { "EmployeeName", currentUserService.User.UserName ?? ""},
                    { "VisitNumber", request?.ComplianceDetails?.VisitReferenceNumber ?? ""},
                    { "LicensedEntityName", visit?.LicensedEntityName ?? ""},
                    { "SubmissionDate", DateTime.Now.ToShortDateString() },
                    { "ActionUrl", "#" }
                },
                    Body = $"Dear {visit?.LicensedEntityName}, Your request for an extension of {request?.RequestedDays} days has been submitted and is awaiting review. You will be notified of the decision soon.",
                    ViewName = "SubmitExtensionRequestForm.cshtml",
                    Subject = "تم تقديم طلب التمديد",
                    To = LicensedEmail
                });
            }
        }
    }
    public async Task SendNotifycationToEntityforExtensionRequestRejection(Guid RequestID)
    {
        var request = unitOfWork.ComplianceRequestRepository.GetExtensionRequest(RequestID)?.Result?.Model;
        var LicensedEntity = unitOfWork.UserRepository.GetUsers([RoleEnum.LicensedEntity]).Result.Model?.ToList();
        var visit = GetComplianceVisit().Result?.Model?.FirstOrDefault(x => x.Id == request.ComplianceDetailsID);

        if (LicensedEntity != null)
        {
            var _LicensedEntityId = request?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !string.IsNullOrEmpty(c.Email) & c.Id == _LicensedEntityId).FirstOrDefault();
            var LicensedEmail = new List<string> { SendTo?.Email ?? "" };

            if (SendTo != null)
            {
                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Content = new Dictionary<string, object>() {
                    { "EmployeeName", currentUserService.User.UserName ?? ""},
                    { "VisitNumber", request?.ComplianceDetails?.VisitReferenceNumber ?? ""},
                    { "LicensedEntityName", visit?.LicensedEntityName ?? ""},
                    { "SubmissionDate", DateTime.Now.ToShortDateString() },
                    { "ActionUrl", "#" }
                },
                    Body = $"Dear {visit?.LicensedEntityName},Your extension request has been rejected. Reason: {request?.Reason ?? ""}.",
                    ViewName = "SubmitExtensionRequestForm.cshtml",
                    Subject = "تم رفض طلب التمديد",
                    To = LicensedEmail
                });
            }
        }
    }
    public async Task<ResponseResult<DocumentExtensionRequestDto>> GetExtensionRequest(Guid id)
        => await unitOfWork.ComplianceRequestRepository.GetExtensionRequest(id);
    public async Task<ResponseResult<List<DocumentExtensionRequestDto>>> ExtensionRequests()
    => await unitOfWork.ComplianceRequestRepository.ExtensionRequests();
    public async Task<ResponseResult<List<DocumentExtensionRequestDto>>> GetExtensionRequestByEntityId(long licensedEntityId)
        => await unitOfWork.ComplianceRequestRepository.GetExtensionRequestByEntityId(licensedEntityId);
    public async Task<ResponseResult<DocumentExtensionReviewDto>> UpdateExtensionRequest(DocumentExtensionReviewDto dto)
    {
        var res = await unitOfWork.ComplianceRequestRepository.UpdateExtensionRequest(dto);
        if (!res.Succeeded)
            throw new Exception("Can't Update Extension Request");

        if (res.Model?.FinalStatus == 1)
        {
            await SendNotifycationToEntityforManagerRequestPinding(res.Model.RequestId);
        }
        else if (res.Model?.FinalStatus == 2 || res.Model?.FinalStatus == 4)
        {
            await SendNotificationToManagerRequestApproved(res.Model.RequestId);
            await SendNotificationToEntityforExtensionRequestApproved(res.Model.RequestId);
        }
        else
        {
            await SendNotifycationToEntityforExtensionRequestRejection(res.Model.RequestId);
        }
        return res;
    }
    public async Task<ResponseResult<List<ExtensionStatusHistoryDto>>> GetExtensionRequestHistory(Guid requestId)
        => await unitOfWork.ComplianceRequestRepository.GetExtensionRequestHistory(requestId);
    public async Task<ResponseResult<bool>> CancelVisitByManager(CancelVisitDto dto)
    {
        var res = unitOfWork.ComplianceRequestRepository.CancelVisitByManager(dto)?.Result;
        if (res.Model == true)
        {
            await SendSMSToEntityForCancelVisit(dto.ComplianceDetailsId);
            await SendNotificationToEntityForCancelVisit(dto.ComplianceDetailsId);
        }
        return res;
    }
    public async Task<ResponseResult<RequestRescheduleDto>> RequestReschedule(RequestRescheduleDto dto)
    {
        var res = unitOfWork.ComplianceRequestRepository.RequestReschedule(dto)?.Result;
        var visit = unitOfWork.ComplianceRequestRepository.GetComplianceVisit()?.Result?.Model?.Where(a => a.Id == res?.Model?.ComplianceDetailsID).FirstOrDefault();
        if (!res.Succeeded)
        {
            throw new Exception("Can't Reschedule a Visit");
        }
        else
        {
            await SendSMSToEntityForRequestRescheduleVisit(res.Model.Id, res.Model.LicensedEntityId);
            await SendNotificationToEntityForRequestRescheduleVisit(res.Model.Id, res.Model.LicensedEntityId);
        }
        return res;
    }
    public async Task<ResponseResult<SpecialistRescheduleDto>> SpecialistReschedule(RequestRescheduleDto dto)
    {
        var res = unitOfWork.ComplianceRequestRepository.SpecialistReschedule(dto)?.Result;
        var visit = unitOfWork.ComplianceRequestRepository.GetComplianceVisit()?.Result?.Model?.Where(a => a.Id == res?.Model?.ComplianceDetailsID).FirstOrDefault();

        if (!res.Succeeded)
        {
            throw new Exception("Can't Reschedule a Visit");
        }
        else
        {
            await SendSMSToEntityForRescheduleVisit(res.Model.ComplianceDetailsID);
            await SendNotificationToEntityForRescheduleVisit(res.Model.ComplianceDetailsID);
        }
        return res;
    }
    public async Task<ResponseResult<List<RequestRescheduleDto>>>? GetRescheduleRequests(long? LicensedID)
       => await unitOfWork.ComplianceRequestRepository.GetRescheduleRequests(LicensedID);
    public async Task<ResponseResult<RequestRescheduleDto>> ReviewReschedule(ReviewRescheduleDto dto)
    {
        var res = unitOfWork.ComplianceRequestRepository.ReviewRescheduleAsync(dto)?.Result;
        if (!res.Succeeded)
        {
            throw new Exception("Can't Reschedule a Visit");
        }
        else if (res?.Model?.StatusID == 2 || res?.Model?.StatusID == 4)
        {
            await SendSMSToEntityForRescheduleVisit(res.Model.ComplianceDetailsID);
            await SendNotificationToEntityForRescheduleVisit(res.Model.ComplianceDetailsID);
        }
        else if (res?.Model?.StatusID == 3)
        {
            await SendSMSToEntityForRejectRescheduleVisit(res.Model.ComplianceDetailsID, res.Model);
            await SendNotificationToEntityRejectForRescheduleVisit(res.Model.ComplianceDetailsID, res.Model);
        }
        return res;
    }
    public async Task<ResponseResult<ComplianceDetailsDto>> UpdateVisitStatus(UpdateVisitStatusDto statusDto)
    {
        var result = await unitOfWork.ComplianceRequestRepository.UpdateVisitStatus(statusDto);
        if (result.Succeeded && result.Model != null)
        {
            await SendSMSToEntityForUpdateStatus(result.Model.Id);
            await SendNotificationToEntityForUpdateStatus(result.Model.Id);
            return result;
        }
        return result;
    }
    public static DateTime BusinessDays(DateTime start, int days)
    {
        int CheckDays = 0;
        DateTime current = start;
        while (CheckDays < days)
        {
            current = current.AddDays(1);
            // Skip weekends (Friday=5, Saturday=6)
            if (current.DayOfWeek != DayOfWeek.Friday && current.DayOfWeek != DayOfWeek.Saturday)
                CheckDays++;
        }
        return current;
    }
    public async Task SendNotifycationToManagerRequestSubmitted(Guid RequestID)
    {
        var request = unitOfWork.ComplianceRequestRepository.GetExtensionRequest(RequestID)?.Result?.Model;
        var managers = unitOfWork.UserRepository.GetUsers(new List<string> { RoleEnum.ComplianceManager }).Result.Model;
        var managerEmails = managers?.Where(c => !string.IsNullOrEmpty(c.Email)).Select(c => c.Email).ToList() ?? new List<string>();

        var specialists = unitOfWork.UserRepository.GetUsers(new List<string> { RoleEnum.ComplianceSpecialist }).Result.Model;
        var specialistEmail = specialists?.FirstOrDefault(c => !string.IsNullOrEmpty(c.Email) && c.Id == request?.LicensedEntityId.ToString())?.Email;

        var visit = GetComplianceVisit().Result?.Model?.FirstOrDefault(x => x.Id == request?.ComplianceDetailsID);

        var allEmails = managerEmails;
        if (!string.IsNullOrEmpty(specialistEmail))
            allEmails.Add(specialistEmail);
        allEmails = allEmails.Distinct().ToList();

        if (request != null && allEmails.Any())
        {
            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
            {
                Content = new Dictionary<string, object>() {
                { "EmployeeName", currentUserService.User.UserName ?? "" },
                { "VisitNumber", request?.ComplianceDetails?.VisitReferenceNumber ?? "" },
                { "LicensedEntityName", visit?.LicensedEntityName ?? "" },
                { "SubmissionDate", DateTime.Now.ToShortDateString() },
                { "ActionUrl", "#" }
            },
                Body = $"Dear [Compliance Specialist, manager],\r\n\"A new extension request has been submitted for {visit?.LicensedEntityName}. Requested Days: {request?.RequestedDays}. Please review and take appropriate action.\"\r\n",
                ViewName = "SubmitExtensionRequestForm.cshtml",
                Subject = "New Extension Request",
                To = allEmails
            });
        }
    }
    public async Task SendNotificationToManagerRequestApproved(Guid RequestID)
    {
        var request = unitOfWork.ComplianceRequestRepository.GetExtensionRequest(RequestID)?.Result?.Model;
        var managers = unitOfWork.UserRepository.GetUsers(new List<string> { RoleEnum.ComplianceManager }).Result.Model;
        var managerEmails = managers?.Where(c => !string.IsNullOrEmpty(c.Email)).Select(c => c.Email).ToList() ?? new List<string>();

        var specialists = unitOfWork.UserRepository.GetUsers(new List<string> { RoleEnum.ComplianceSpecialist }).Result.Model;
        var specialistEmail = specialists?.FirstOrDefault(c => !string.IsNullOrEmpty(c.Email) && c.Id == request?.LicensedEntityId.ToString())?.Email;

        var visit = GetComplianceVisit().Result?.Model?.FirstOrDefault(x => x.Id == request?.ComplianceDetailsID);

        var allEmails = managerEmails;
        if (!string.IsNullOrEmpty(specialistEmail))
            allEmails.Add(specialistEmail);
        allEmails = allEmails.Distinct().ToList();

        if (request != null && allEmails.Any())
        {
            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
            {
                Content = new Dictionary<string, object>() {
                { "EmployeeName", currentUserService.User.UserName ?? "" },
                { "VisitNumber", request?.ComplianceDetails?.VisitReferenceNumber ?? "" },
                { "LicensedEntityName", visit?.LicensedEntityName ?? "" },
                { "SubmissionDate", DateTime.Now.ToShortDateString() },
                { "ActionUrl", "#" }
            },
                Body = $"Dear [Compliance Specialist, manager],\r\n\"A new extension request has been submitted for {visit?.LicensedEntityName}. Requested Days: {request?.RequestedDays}. Please review and approve/reject the request.\"\r\n",
                ViewName = "SubmitExtensionRequestForm.cshtml",
                Subject = "New Approval Request",
                To = allEmails
            });
        }
    }
    public async Task SendNotifycationToEntityforManagerRequestPinding(Guid RequestID)
    {
        var request = unitOfWork.ComplianceRequestRepository.GetExtensionRequest(RequestID)?.Result?.Model;
        var managers = unitOfWork.UserRepository.GetUsers(new List<string> { RoleEnum.ComplianceManager }).Result.Model;
        var managerEmails = managers?.Where(c => !string.IsNullOrEmpty(c.Email)).Select(c => c.Email).ToList() ?? new List<string>();

        var specialists = unitOfWork.UserRepository.GetUsers(new List<string> { RoleEnum.ComplianceSpecialist }).Result.Model;
        var specialistEmail = specialists?.FirstOrDefault(c => !string.IsNullOrEmpty(c.Email) && c.Id == request?.LicensedEntityId.ToString())?.Email;

        var visit = GetComplianceVisit().Result?.Model?.FirstOrDefault(x => x.Id == request?.ComplianceDetailsID);

        var allEmails = managerEmails;

        if (!string.IsNullOrEmpty(specialistEmail))
            allEmails.Add(specialistEmail);
        allEmails = allEmails.Distinct().ToList();

        if (request != null && allEmails.Count != 0)
        {
            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
            {
                Content = new Dictionary<string, object>() {
                { "EmployeeName", currentUserService.User.UserName ?? "" },
                { "VisitNumber", request?.ComplianceDetails?.VisitReferenceNumber ?? "" },
                { "LicensedEntityName", visit?.LicensedEntityName ?? "" },
                { "SubmissionDate", DateTime.Now.ToShortDateString() },
                { "ActionUrl", "#" }
            },
                Body = $"Dear [Compliance Specialist, manager],An extension request requiring additional approval has been escalated to you. Please review and provide your decision.",
                ViewName = "SubmitExtensionRequestForm.cshtml",
                Subject = "Extension Request Pending Review",
                To = allEmails
            });
        }
    }

    // cancel visit 
    public async Task SendSMSToEntityForCancelVisit(Guid ComplianceDetailsID)
    {
        var complianceVisits = unitOfWork.ComplianceRequestRepository.GetComplianceVisit()?.Result?.Model?.Where(s => s.Id == ComplianceDetailsID).FirstOrDefault();
        var LicensedEntity = unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.LicensedEntity }).Result.Model?.ToList();

        if (LicensedEntity != null)
        {
            var _LicensedEntityId = complianceVisits?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !string.IsNullOrEmpty(c.MobileNumber) & c.Id == _LicensedEntityId).FirstOrDefault();
            var mobileNumbers = new List<string> { SendTo?.MobileNumber ?? "" };

            if (mobileNumbers != null)
            {
                string messageBody = $"Your compliance visit {complianceVisits?.VisitReferenceNumber} has been cancelled.\r\n\r\nReason for cancellation: {complianceVisits?.CancellationReason}\r\n\r\nIf you have any questions, please contact the compliance Manager.";

                var content = new Dictionary<string, string>() {
                     { "{VisitDate}", complianceVisits?.VisitDate?.ToShortDateString() ?? ""},
                };

                foreach (var pair in content)
                {
                    messageBody = messageBody.Replace(pair.Key, pair.Value ?? string.Empty);
                }

                await notificationService(NotificationTypeEnum.SMS).SendAsync(
                    new NotificationMessageModel()
                    {
                        To = mobileNumbers,
                        Body = messageBody,
                    }
                );
            }
        }
    }
    public async Task<ResponseResult<bool>> SendNotificationToEntityForCancelVisit(Guid ComplianceDetailsID)
    {
        var request = unitOfWork.ComplianceRequestRepository.GetComplianceVisit()?.Result?.Model?.Where(s => s.Id == ComplianceDetailsID).FirstOrDefault();
        var LicensedEntity = unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.LicensedEntity }).Result.Model?.ToList();

        if (LicensedEntity != null)
        {
            var _LicensedEntityId = request?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !string.IsNullOrEmpty(c.Email) & c.Id == _LicensedEntityId).FirstOrDefault();
            var LicensedEmail = new List<string> { SendTo?.Email ?? "" };

            if (SendTo != null)
            {
                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Content = new Dictionary<string, object>() {
                    { "EmployeeName", request?.LicensedEntityName ?? ""},
                    { "VisitNumber", request?.VisitReferenceNumber ?? ""},
                    { "LicensedEntityName", request?.LicensedEntityName ?? ""},
                    { "SubmissionDate", DateTime.Now.ToShortDateString() },
                    { "ActionUrl", "#" }
                },
                    Body = $"Your compliance visit {request?.VisitReferenceNumber} has been cancelled.\\r\\n\\r\\nReason for cancellation: {request?.CancellationReason} \\r\\n\\r\\nIf you have any questions, please contact the compliance Manager.\"\r\n",
                    ViewName = "SubmitExtensionRequestForm.cshtml",
                    Subject = " تم إلغاء زيارة الإمتثال",
                    To = LicensedEmail
                });
                return ResponseResult<bool>.Success(true);
            }
        }
        return ResponseResult<bool>.Success(false);
    }

    // Reschedule Request
    public async Task SendSMSToEntityForRescheduleVisit(Guid ComplianceDetailsID)
    {
        var complianceVisits = unitOfWork.ComplianceRequestRepository.GetComplianceVisit()?.Result?.Model?.Where(s => s.Id == ComplianceDetailsID).FirstOrDefault();
        var LicensedEntity = unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.LicensedEntity }).Result.Model?.ToList();

        if (LicensedEntity != null)
        {
            var _LicensedEntityId = complianceVisits?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !string.IsNullOrEmpty(c.MobileNumber) & c.Id == _LicensedEntityId).FirstOrDefault();
            var mobileNumbers = new List<string> { SendTo?.MobileNumber ?? "" };

            if (mobileNumbers.Count > 0)
            {
                string messageBody = $"Dear {complianceVisits?.LicensedEntityName},\r\n\r\nYour compliance visit {complianceVisits?.VisitReferenceNumber} has been rescheduled.\r\n\r\nNew visit date: {complianceVisits?.ScheduledDate}\r\nReason for rescheduling: {complianceVisits?.RescheduleReason}\r\n\r\nIf you have any questions, please contact the compliance team.\r\n\r\nBest regards,  \r\n[The Saudi Water Authority]";

                var content = new Dictionary<string, string>() {
                     { "{VisitDate}", complianceVisits?.VisitDate?.ToShortDateString() ?? ""},
                };

                foreach (var pair in content)
                {
                    messageBody = messageBody.Replace(pair.Key, pair.Value ?? string.Empty);
                }

                await notificationService(NotificationTypeEnum.SMS).SendAsync(
                    new NotificationMessageModel()
                    {
                        To = mobileNumbers,
                        Body = messageBody,
                    }
                );
            }
        }
    }
    public async Task<ResponseResult<bool>> SendNotificationToEntityForRescheduleVisit(Guid ComplianceDetailsID)
    {
        var request = unitOfWork.ComplianceRequestRepository.GetComplianceVisit()?.Result?.Model?.Where(s => s.Id == ComplianceDetailsID).FirstOrDefault();
        var LicensedEntity = unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.LicensedEntity }).Result.Model?.ToList();

        if (LicensedEntity != null)
        {
            var _LicensedEntityId = request?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !string.IsNullOrEmpty(c.MobileNumber) & c.Id == _LicensedEntityId).FirstOrDefault();
            var LicensedEmail = new List<string> { SendTo?.MobileNumber ?? "" };

            if (SendTo != null)
            {
                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Content = new Dictionary<string, object>() {
                    { "EmployeeName", request?.LicensedEntityName ?? ""},
                    { "VisitNumber", request?.VisitReferenceNumber ?? ""},
                    { "LicensedEntityName", request?.LicensedEntityName ?? ""},
                    { "SubmissionDate", DateTime.Now.ToShortDateString() },
                    { "ActionUrl", "#" }
                    },

                    Body = $"Dear {request?.LicensedEntityName},\r\n\r\nYour compliance visit {request?.VisitReferenceNumber} has been rescheduled.\r\n\r\nNew visit date: {request?.ScheduledDate}\r\nReason for rescheduling: {request?.RescheduleReason}\r\n\r\nIf you have any questions, please contact the compliance team.\r\n\r\nBest regards,  \r\n[The Saudi Water Authority]",
                    ViewName = "SubmitExtensionRequestForm.cshtml",
                    Subject = " تم إعادة جدولة زيارة الإمتثال",
                    To = LicensedEmail
                });
                return ResponseResult<bool>.Success(true);
            }
        }
        return ResponseResult<bool>.Success(false);
    }


    // Reject Reschedule Request
    public async Task SendSMSToEntityForRejectRescheduleVisit(Guid ComplianceDetailsID, RequestRescheduleDto dto)
    {
        var complianceVisits = unitOfWork.ComplianceRequestRepository.GetComplianceVisit()?.Result?.Model?.Where(s => s.Id == ComplianceDetailsID).FirstOrDefault();
        var LicensedEntity = unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.LicensedEntity }).Result.Model?.ToList();

        if (LicensedEntity != null)
        {
            var _LicensedEntityId = complianceVisits?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !string.IsNullOrEmpty(c.MobileNumber) & c.Id == _LicensedEntityId).FirstOrDefault();
            var mobileNumbers = new List<string> { SendTo?.MobileNumber ?? "" };

            if (mobileNumbers != null)
            {
                string messageBody = $"Dear {complianceVisits?.LicensedEntityName},\r\n\r\nYour Reschedule Request for compliance visit {complianceVisits?.VisitReferenceNumber} has been Rejected .\r\n\r\r\nReason for Rejection: {dto?.ReviewReason}\r\n\r\nIf you have any questions, please contact the compliance team.\r\n\r\nBest regards,  \r\n[The Saudi Water Authority]";

                var content = new Dictionary<string, string>() {
                     { "{VisitDate}", complianceVisits?.VisitDate?.ToShortDateString() ?? ""},
                };

                foreach (var pair in content)
                {
                    messageBody = messageBody.Replace(pair.Key, pair.Value ?? string.Empty);
                }

                await notificationService(NotificationTypeEnum.SMS).SendAsync(
                    new NotificationMessageModel()
                    {
                        To = mobileNumbers,
                        Body = messageBody,
                    }
                );
            }
        }
    }
    public async Task<ResponseResult<bool>> SendNotificationToEntityRejectForRescheduleVisit(Guid ComplianceDetailsID, RequestRescheduleDto dto)
    {
        var request = unitOfWork.ComplianceRequestRepository.GetComplianceVisit()?.Result?.Model?.Where(s => s.Id == ComplianceDetailsID).FirstOrDefault();
        var LicensedEntity = unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.LicensedEntity }).Result.Model?.ToList();

        if (LicensedEntity != null)
        {
            var _LicensedEntityId = request?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !string.IsNullOrEmpty(c.MobileNumber) & c.Id == _LicensedEntityId).FirstOrDefault();
            var LicensedEmail = new List<string> { SendTo?.MobileNumber ?? "" };
            if (SendTo != null)
            {
                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Content = new Dictionary<string, object>() {
                    { "EmployeeName", request?.LicensedEntityName ?? ""},
                    { "VisitNumber", request?.VisitReferenceNumber ?? ""},
                    { "LicensedEntityName", request?.LicensedEntityName ?? ""},
                    { "SubmissionDate", DateTime.Now.ToShortDateString() },
                    { "ActionUrl", "#" }
                    },

                    Body = $"Dear {request?.LicensedEntityName},\r\n\r\nYour Reschedule Request for compliance visit {request?.VisitReferenceNumber} has been Rejected .\r\n\r\r\nReason for Rejection: {dto?.ReviewReason}\r\n\r\nIf you have any questions, please contact the compliance team.\r\n\r\nBest regards,  \r\n[The Saudi Water Authority]",
                    ViewName = "SubmitExtensionRequestForm.cshtml",
                    Subject = " تم رفض طلب إعادة جدولة زيارة الإمتثال",
                    To = LicensedEmail
                });
                return ResponseResult<bool>.Success(true);
            }
        }
        return ResponseResult<bool>.Success(false);
    }

    // Update Status
    public async Task SendSMSToEntityForUpdateStatus(Guid ComplianceDetailsID)
    {
        var complianceVisits = unitOfWork.ComplianceRequestRepository.GetComplianceVisit()?.Result?.Model?.Where(s => s.Id == ComplianceDetailsID).FirstOrDefault();
        var LicensedEntity = unitOfWork.UserRepository.GetUsers([RoleEnum.LicensedEntity]).Result.Model?.ToList();

        if (LicensedEntity != null)
        {
            var _LicensedEntityId = complianceVisits?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !string.IsNullOrEmpty(c.MobileNumber) & c.Id == _LicensedEntityId).FirstOrDefault();
            var mobileNumbers = new List<string> { SendTo?.MobileNumber ?? "" };

            if (mobileNumbers != null)
            {
                string messageBody = $"Dear {complianceVisits?.LicensedEntityName},\r\n\r\nYour compliance visit {complianceVisits?.VisitReferenceNumber} has Updated Status.\r\n\r\r\n The New Status is : {complianceVisits?.VisitStatusName}\r\n\r\nIf you have any questions, please contact the compliance team.\r\n\r\nBest regards,  \r\n[The Saudi Water Authority]";

                var content = new Dictionary<string, string>() {
                     { "{VisitDate}", complianceVisits?.VisitDate?.ToShortDateString() ?? ""},
                };

                foreach (var pair in content)
                {
                    messageBody = messageBody.Replace(pair.Key, pair.Value ?? string.Empty);
                }

                await notificationService(NotificationTypeEnum.SMS).SendAsync(
                    new NotificationMessageModel()
                    {
                        Subject = "Visit Update Status !",
                        To = mobileNumbers,
                        Body = messageBody,
                    }
                );
            }


        }
    }
    public async Task<ResponseResult<bool>> SendNotificationToEntityForUpdateStatus(Guid ComplianceDetailsID)
    {
        var request = unitOfWork.ComplianceRequestRepository.GetComplianceVisit()?.Result?.Model?.Where(s => s.Id == ComplianceDetailsID).FirstOrDefault();
        var LicensedEntity = unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.LicensedEntity }).Result.Model?.ToList();

        if (LicensedEntity != null)
        {
            var _LicensedEntityId = request?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !string.IsNullOrEmpty(c.Email) & c.Id == _LicensedEntityId).FirstOrDefault();
            var LicensedEmail = new List<string> { SendTo?.Email ?? "" };
            if (SendTo != null)
            {
                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Content = new Dictionary<string, object>() {
                    { "EmployeeName", request?.LicensedEntityName ?? ""},
                    { "VisitNumber", request?.VisitReferenceNumber ?? ""},
                    { "LicensedEntityName", request?.LicensedEntityName ?? ""},
                    { "SubmissionDate", DateTime.Now.ToShortDateString() },
                    { "ActionUrl", "#" }
                },

                    Body = $"Dear {request?.LicensedEntityName},\r\n\r\nYour compliance visit {request?.VisitReferenceNumber} has Updated Status.\r\n\r\r\n The New Status is : {request?.VisitStatusName}\r\n\r\nIf you have any questions, please contact the compliance team.\r\n\r\nBest regards,  \r\n [The Saudi Water Authority]",
                    ViewName = "SubmitExtensionRequestForm.cshtml",
                    Subject = " تم تعديل حالة الزيارة ",
                    To = LicensedEmail
                });
                return ResponseResult<bool>.Success(true);
            }
        }
        return ResponseResult<bool>.Success(false);
    }

    public async Task SendSMSToEntityForRequestRescheduleVisit(int RequestId, long LicenseID)
    {
        var _request = unitOfWork.ComplianceRequestRepository.GetRescheduleRequests(LicenseID)?.Result?.Model?.Where(a => a.Id == RequestId).FirstOrDefault();
        var complianceVisits = unitOfWork.ComplianceRequestRepository.GetComplianceVisit()?.Result?.Model?.Where(s => s.Id == _request?.ComplianceDetailsID).FirstOrDefault();
        var LicensedEntity = unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.LicensedEntity }).Result.Model?.ToList();
        if (LicensedEntity != null)
        {
            var _LicensedEntityId = complianceVisits?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !string.IsNullOrEmpty(c.MobileNumber) & c.Id == _LicensedEntityId).FirstOrDefault();
            var mobileNumbers = new List<string> { SendTo?.MobileNumber ?? "" };

            if (mobileNumbers != null)
            {
                string messageBody = $"Dear {complianceVisits?.LicensedEntityName},\r\n\r\nA reschedule request has been submitted for the compliance visit {complianceVisits?.VisitReferenceNumber}." +
                    $"\r\n\r\nReason for reschedule: {complianceVisits?.RescheduleReason}\r\n\r\nBest regards,  \r\n[The Saudi Water Authority]";

                var content = new Dictionary<string, string>() {
                     { "{VisitDate}", complianceVisits?.VisitDate?.ToShortDateString() ?? ""},
                };

                foreach (var pair in content)
                {
                    messageBody = messageBody.Replace(pair.Key, pair.Value ?? string.Empty);
                }

                await notificationService(NotificationTypeEnum.SMS).SendAsync(
                    new NotificationMessageModel()
                    {
                        To = mobileNumbers,
                        Body = messageBody,
                    }
                );
            }
        }
    }
    public async Task<ResponseResult<bool>> SendNotificationToEntityForRequestRescheduleVisit(int RequestId, long LicenseID)
    {
        var _request = unitOfWork.ComplianceRequestRepository.GetRescheduleRequests(LicenseID)?.Result?.Model?.Where(a => a.Id == RequestId).FirstOrDefault();
        var complianceVisits = unitOfWork.ComplianceRequestRepository.GetComplianceVisit()?.Result?.Model?.Where(s => s.Id == _request?.ComplianceDetailsID).FirstOrDefault();

        var LicensedEntity = unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.LicensedEntity }).Result.Model?.ToList();

        if (LicensedEntity != null)
        {
            var _LicensedEntityId = complianceVisits?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !string.IsNullOrEmpty(c.MobileNumber) & c.Id == _LicensedEntityId).FirstOrDefault();
            var LicensedEmail = new List<string> { SendTo?.MobileNumber ?? "" };

            if (SendTo != null)
            {
                await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                {
                    Content = new Dictionary<string, object>() {
                    { "EmployeeName", complianceVisits?.LicensedEntityName ?? ""},
                    { "VisitNumber", complianceVisits?.VisitReferenceNumber ?? ""},
                    { "LicensedEntityName", complianceVisits?.LicensedEntityName ?? ""},
                    { "SubmissionDate", DateTime.Now.ToShortDateString() },
                    { "ActionUrl", "#" }
                },

                    Body = $"Dear {complianceVisits?.LicensedEntityName},\r\n\r\nA reschedule request has been submitted for the compliance visit {complianceVisits?.VisitReferenceNumber}." +
                    $"\r\n\r\nReason for reschedule: {complianceVisits?.RescheduleReason}\r\n\r\nBest regards,  \r\n[The Saudi Water Authority]",

                    ViewName = "SubmitExtensionRequestForm.cshtml",
                    Subject = " تم تقديم طلب إعادة جدولة زيارة ",
                    To = LicensedEmail
                });
                return ResponseResult<bool>.Success(true);
            }
        }
        return ResponseResult<bool>.Success(false);
    }

    #endregion
    #endregion

    #region figma part 2 unmerged
    public async Task<ResponseResult<ComplianceDisclosureReportDto>> GetVisitDisclosureReportForComplianceManager(Guid visitId)
    {
        var result = await unitOfWork.ComplianceRequestRepository.GetVisitDisclosureReportForComplianceManager(visitId);
        return result;
    }
    public async Task<ResponseResult<ComplianceVisitDisclosureDto>> GetVisitDisclosureFormForComplianceManager(Guid visitId, string visitSpecialistId)
    {
        var result = await unitOfWork.ComplianceRequestRepository.GetVisitDisclosureFormForComplianceManager(visitId, visitSpecialistId);
        return result;
    }
    public async Task<ResponseResult<ComplianceVisitDisclosureDto>> GetVisitDisclosureFormForLoggedInSpecialist(Guid visitId)
    {
        var result = await unitOfWork.ComplianceRequestRepository.GetVisitDisclosureFormForLoggedInSpecialist(visitId);
        return result;
    }
    public async Task<ResponseResult<bool>> SaveVisitDisclosureForm(ComplianceVisitDisclosureDto model)
    {
        var result = await unitOfWork.ComplianceRequestRepository.SaveVisitDisclosureForm(model);
        await unitOfWork.CommitAsync();

        if (result.Succeeded)
            BackgroundJob.Enqueue(() => NotifyForDisclosureFormConflicts(model));

        return result;
    }
    public async Task NotifyForDisclosureFormConflicts(ComplianceVisitDisclosureDto disclosureDto)
    {
        var complianceManagers = await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.ComplianceManager });
        var visit = await unitOfWork.ComplianceRequestRepository.GetComplianceVisitDetail(disclosureDto.ComplianceDetailId);
        var conflictedVisitSpecialist = unitOfWork.ComplianceRequestRepository.GetComplianceVisitDisclosureBySpecialistId(disclosureDto.ComplianceVisitSpecialistId).Result.Model;

        long conflictStatus = (long)VisitStatusEnum.ConflictOfInterestDisclosure;

        if (visit.Model.VisitStatusId.Equals(conflictStatus)
            && conflictedVisitSpecialist != null ? conflictedVisitSpecialist.HasConflicts : false
            && complianceManagers != null
            && complianceManagers.Model != null
        )
        {
            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
            {
                Content = new Dictionary<string, object>() {
                    { "EmployeeName", "مدير الادارة" },
                    { "VisitDate", visit?.Model?.VisitDate },
                    { "LicenseeName", visit?.Model?.LicensedEntityName },
                    { "VisitSpecialistName", visit.Model?.ComplianceVisitSpecialists?.FirstOrDefault(s=> s.Id.Equals(disclosureDto.ComplianceVisitSpecialistId))?.SpecialistUserName},
                    { "ActionUrl", "#" }
                },
                ViewName = "VisitTeamMemberDisclosureConflict.cshtml",
                Subject = $"تم تحديد الصراع في مهمة الفريق.",
                To = complianceManagers.Model.Select(s => s.Email).ToList(),
                CC = new List<string>
                { 
                    visit?.Model?.ComplianceVisitSpecialists?.FirstOrDefault(s => s.Id.Equals(disclosureDto.ComplianceVisitSpecialistId))?.SpecialistUserEmail
                }
            });
        }
    }
    public async Task SendVisitDisclosureNotSubmittedNotificationAsync()
    {
        int reminderAfterDays = 2;

        var complianceManagers = await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.ComplianceManager });
        var visits = await unitOfWork.ComplianceRequestRepository.GetVisitsByStatus((long)VisitStatusEnum.Scheduled);

        if (visits.Model != null && visits.Model.Count() > 0)
        {
            foreach (var visit in visits.Model)
            {
                var specialistsToRemind = visit.ComplianceVisitSpecialists.Where(s =>
                    s.ComplianceVisitDisclosure == null && // disclosure not submitted
                    s.CreatedOn != null && //specialist is assigned means created on date is not null
                    s.CreatedOn?.AddDays(reminderAfterDays).Date == DateTime.Today //2 days have passed since specialist was assigned
                ).ToList();

                foreach (var specialist in specialistsToRemind)
                {
                    await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
                    {
                        Content = new Dictionary<string, object>() {
                            { "EmployeeName", "مدير الادارة" },
                            { "VisitDate", visit.VisitDate },
                            { "LicenseeName", visit.LicensedEntityName },
                            { "VisitSpecialistName", specialist.SpecialistUserName},
                            { "ActionUrl", "#" }
                        },
                        ViewName = "DisclosureFormNotSubmittedBySpecialist.cshtml",
                        Subject = $"لم يتم تقديم نموذج إفصاح أخصائي الامتثال - يلزم اتخاذ إجراء",
                        To = complianceManagers.Model.Select(s => s.Email).ToList(),
                        CC = new List<string> { specialist.SpecialistUserEmail }
                    });
                }
            }

        }
    }
    #endregion Figma part 2 unmerged

    #region Complaince Report 
    public async Task<List<ReportCategoryDto>> GetReportStructureDto()
    {
        return await unitOfWork.ComplianceRequestRepository.GetReportStructureDto();
    }
    public async Task<List<ReportCategory>> GetCategory()
    {
        return await unitOfWork.ComplianceRequestRepository.GetCategory();
    }

    public async Task<List<ReportSubCategory>> GetSubCategory(int? CategoryID)
    {
        return await unitOfWork.ComplianceRequestRepository.GetSubCategory(CategoryID);
    }

    public async Task<List<ReportEntries>> GetEntries(int? SubCategoryID)
    {
        return await unitOfWork.ComplianceRequestRepository.GetEntries(SubCategoryID);
    }

    public async Task<ResponseResult<ComplianceReportDto>> AddComplianceReport(ComplianceReportDto reportDto)
    {
        if (reportDto.Attachments != null)
            ValidateVisitAttachments(reportDto.Attachments);

            // Deserialize nested JSON if present (handle nulls gracefully)
            var auditors = !string.IsNullOrWhiteSpace(reportDto.AuditorsJS)
                ? JsonConvert.DeserializeObject<List<AuditorsDto>>(reportDto.AuditorsJS)
                : reportDto.Auditors?.ToList();

            var participants = !string.IsNullOrWhiteSpace(reportDto.ParticipantsJS)
                ? JsonConvert.DeserializeObject<List<LicenseParticipantDto>>(reportDto.ParticipantsJS)
                : reportDto.Participants?.ToList();

            var questions = !string.IsNullOrWhiteSpace(reportDto.QuestaionsJS)
                ? JsonConvert.DeserializeObject<List<QuestaionDto>>(reportDto.QuestaionsJS)
                : reportDto.Questaions?.ToList();
        
            var previous = !string.IsNullOrWhiteSpace(reportDto.PreviousJS)
                ? JsonConvert.DeserializeObject<PreviousRecommendationsDto>(reportDto.PreviousJS)
                : reportDto.PreviousRecommendations;

            reportDto.Auditors = auditors;
            reportDto.Participants = participants;
            reportDto.Questaions = questions;
            reportDto.PreviousRecommendations = previous;

        
        if (currentUserService.User.Role.Any(a => a.Contains(RoleEnum.ComplianceSpecialist)))
        {
            var ReportObject = unitOfWork.ComplianceRequestRepository.AddComplianceReport(reportDto).Result.Model;
            if (reportDto.Attachments != null && reportDto.Attachments.Count > 0)
            {
                reportDto.AttachmentsList = new List<AttachmentDto>();
                foreach (var file in reportDto.Attachments)
                {
                    var attachmentGuid = Guid.NewGuid().ToString();
                    var attachment = new Attachment
                    {
                        AttachmentGuid = attachmentGuid,
                        AttachmentName = $"{file.FileName}",
                        EntityId = ReportObject.Id,
                        EntityName = AttachmentEntityEnum.Report,
                        AttachmentTypeId = (long)AttachmentTypeEnum.ReportAttachment
                    };

                    List<KeyValuePair<Stream, string>> attachemnts = [];
                    var fileSplitted = attachment.AttachmentName.Split('.');
                    string fileExtension = fileSplitted[fileSplitted.Length - 1];

                    string dir = attachmentService.GetMappedDirectory(AttachmentEntityEnum.Report, new Dictionary<string, string>() { { "ReportId", reportDto.Id.ToString() } });
                    dir += $"/{attachmentGuid}.{fileExtension}";
                    attachemnts.Add(new KeyValuePair<Stream, string>(file.OpenReadStream(), dir));

                    attachmentService.UploadAttachment(attachemnts);
                    await unitOfWork.AttachmentRepository.AddAttachment(attachment);
                    await unitOfWork.CommitAsync();

                    reportDto.AttachmentsList.Add(new AttachmentDto()
                    {
                        AttachmentId = attachment.Id,
                        AttachmentGuid = attachmentGuid,
                        AttachmentName = attachment.AttachmentName,
                        AttachmentType = (AttachmentTypeEnum)attachment.AttachmentTypeId,
                        EntityId = attachment.EntityId,
                        EntityName = attachment.EntityName,
                    });
                }
            }
            var getreport = unitOfWork.ComplianceRequestRepository.GetComplianceReport(reportDto.Id).Result.Model;
            return ResponseResult<ComplianceReportDto>.Success(getreport);
        }
        return ResponseResult<ComplianceReportDto>.Success(null);

    }

    public async Task<ResponseResult<ComplianceReportDto>> GetComplianceReport(Guid? id)
    {
        return await unitOfWork.ComplianceRequestRepository.GetComplianceReport(id);
    }
    public async Task<ResponseResult<List<ComplianceReportDto>>> GetAllComplianceReports()
    {
        return await unitOfWork.ComplianceRequestRepository.GetAllComplianceReports();
    }

    public async Task<CorrectiveActionPlan> AddCorrectPlan(CorrectiveActionPlanDto dto)
    {
        var plan = await unitOfWork.ComplianceRequestRepository.AddCorrectPlan(dto);
        ValidateVisitAttachments(dto.Files);
        if (dto.Files != null && dto.Files.Count > 0)
        {
            dto.FileList = [];
            foreach (var file in dto.Files)
            {
                var attachmentGuid = Guid.NewGuid().ToString();
                var attachment = new Attachment
                {
                    AttachmentGuid = attachmentGuid,
                    AttachmentName = $"{file.FileName}",
                    EntityId = plan.Id,
                    EntityName = AttachmentEntityEnum.Report,
                    AttachmentTypeId = (long)AttachmentTypeEnum.CorrectPlanAttachment
                };

                List<KeyValuePair<Stream, string>> attachemnts = [];
                var fileSplitted = attachment.AttachmentName.Split('.');
                string fileExtension = fileSplitted[fileSplitted.Length - 1];

                string dir = attachmentService.GetMappedDirectory(AttachmentEntityEnum.Report, new Dictionary<string, string>() { { "ReportId", plan.Id.ToString() } });
                dir += $"/{attachmentGuid}.{fileExtension}";
                attachemnts.Add(new KeyValuePair<Stream, string>(file.OpenReadStream(), dir));

                attachmentService.UploadAttachment(attachemnts);
                await unitOfWork.AttachmentRepository.AddAttachment(attachment);
                await unitOfWork.CommitAsync();

                dto.FileList.Add(new AttachmentDto()
                {
                    AttachmentId = attachment.Id,
                    AttachmentGuid = attachmentGuid,
                    AttachmentName = attachment.AttachmentName,
                    AttachmentType = (AttachmentTypeEnum)attachment.AttachmentTypeId,
                    EntityId = attachment.EntityId,
                    EntityName = attachment.EntityName,
                });
            }
        }
        return plan;
    }

    public async Task<CorrectiveActionPlanDto?> GetCorrectPlanById(Guid planId)
    {
        return await unitOfWork.ComplianceRequestRepository.GetPlanWithAttachments(planId);
    }
    public async Task<CorrectiveEvidence> UploadEvidence(EvidenceUploadDto dto)
    {
        ValidateVisitAttachments(dto.Files);
        var record = await unitOfWork.ComplianceRequestRepository.UploadEvidence(dto);
        if (dto.Files != null && dto.Files.Count > 0)
        {
            dto.FileList = [];
            foreach (var file in dto.Files)
            {
                var attachmentGuid = Guid.NewGuid().ToString();
                var attachment = new Attachment
                {
                    AttachmentGuid = attachmentGuid,
                    AttachmentName = $"{file.FileName}",
                    EntityId = record.Id,
                    EntityName = AttachmentEntityEnum.Report,
                    AttachmentTypeId = (long)AttachmentTypeEnum.CorrectPlanAttachment
                };

                List<KeyValuePair<Stream, string>> attachemnts = [];
                var fileSplitted = attachment.AttachmentName.Split('.');
                string fileExtension = fileSplitted[fileSplitted.Length - 1];

                string dir = attachmentService.GetMappedDirectory(AttachmentEntityEnum.Report, new Dictionary<string, string>() { { "ReportId", record.Id.ToString() } });
                dir += $"/{attachmentGuid}.{fileExtension}";
                attachemnts.Add(new KeyValuePair<Stream, string>(file.OpenReadStream(), dir));

                attachmentService.UploadAttachment(attachemnts);
                await unitOfWork.AttachmentRepository.AddAttachment(attachment);
                await unitOfWork.CommitAsync();

                dto.FileList.Add(new AttachmentDto()
                {
                    AttachmentId = attachment.Id,
                    AttachmentGuid = attachmentGuid,
                    AttachmentName = attachment.AttachmentName,
                    AttachmentType = (AttachmentTypeEnum)attachment.AttachmentTypeId,
                    EntityId = attachment.EntityId,
                    EntityName = attachment.EntityName,
                });
            }
        }
        return record;
    }
    public async Task ReviewEvidence(EvidenceReviewDto dto)
    {
        await unitOfWork.ComplianceRequestRepository.ReviewEvidence(dto);  
    }
    public async Task ReviewReport(ComplianceReportReviewDto dto)
    {
        await unitOfWork.ComplianceRequestRepository.ReviewReport(dto);
    }

    public async Task<ResponseResult<bool>> SaveComplianceReportActivity(ReportRequestActivityModel model)
    {
        if (model.ReplyAttachments != null)
            ValidateVisitAttachments(model.ReplyAttachments);

        if (model.RequestAttachments != null)
            ValidateVisitAttachments(model.RequestAttachments);

        var  reportActivityId = await unitOfWork.ComplianceRequestRepository.SaveComplianceReportActivity(model);
        if (model.ReplyAttachments != null && model.ReplyAttachments.Count > 0)
        {
            foreach (var file in model.ReplyAttachments)
            {
                var attachmentGuid = Guid.NewGuid().ToString();
                var attachment = new Attachment
                {
                    AttachmentGuid = attachmentGuid,
                    AttachmentName = $"{file.FileName}",
                    EntityId = reportActivityId.Model,
                    EntityName = AttachmentEntityEnum.Report,
                    AttachmentTypeId = (long)AttachmentTypeEnum.ReportReplyAttachment
                };

                List<KeyValuePair<Stream, string>> attachemnts = new List<KeyValuePair<Stream, string>>();
                var fileSplitted = attachment.AttachmentName.Split('.');
                string fileExtension = fileSplitted[fileSplitted.Length - 1];

                string dir = attachmentService.GetMappedDirectory(AttachmentEntityEnum.Report, new Dictionary<string, string>() { { "ReportId", reportActivityId.Model.ToString() } });
                dir += $"/{attachmentGuid}.{fileExtension}";
                attachemnts.Add(new KeyValuePair<Stream, string>(file.OpenReadStream(), dir));

                attachmentService.UploadAttachment(attachemnts);
                await unitOfWork.AttachmentRepository.AddAttachment(attachment);
                await unitOfWork.CommitAsync();

            }
        }

        if (model.RequestAttachments != null && model.RequestAttachments.Count > 0)
        {
            foreach (var file in model.RequestAttachments)
            {
                var attachmentGuid = Guid.NewGuid().ToString();
                var attachment = new Attachment
                {
                    AttachmentGuid = attachmentGuid,
                    AttachmentName = $"{file.FileName}",
                    EntityId = reportActivityId.Model,
                    EntityName = AttachmentEntityEnum.Report,
                    AttachmentTypeId = (long)AttachmentTypeEnum.ReportSendAttachment
                };

                List<KeyValuePair<Stream, string>> attachemnts = new List<KeyValuePair<Stream, string>>();
                var fileSplitted = attachment.AttachmentName.Split('.');
                string fileExtension = fileSplitted[fileSplitted.Length - 1];

                string dir = attachmentService.GetMappedDirectory(AttachmentEntityEnum.Report, new Dictionary<string, string>() { { "ReportId", reportActivityId.Model.ToString() } });
                dir += $"/{attachmentGuid}.{fileExtension}";
                attachemnts.Add(new KeyValuePair<Stream, string>(file.OpenReadStream(), dir));

                attachmentService.UploadAttachment(attachemnts);
                await unitOfWork.AttachmentRepository.AddAttachment(attachment);
                await unitOfWork.CommitAsync();

            }
        }
        return ResponseResult<bool>.Success(true);
    }
    public async Task<ResponseResult<ReportRequestActivityDto>> GetComplianceReportActivity(Guid id)
    {
        return await unitOfWork.ComplianceRequestRepository.GetComplianceReportActivity(id);
    }
    public async Task<ResponseResult<List<ReportRequestActivityDto>>> GetComplianceReportActivities(bool isReply)
    {
        return await unitOfWork.ComplianceRequestRepository.GetComplianceReportActivities(isReply);
    }

    public async Task<ResponseResult<List<RequestRescheduleDto>>> GetRescheduleRequestsForManager()
    {
        return await unitOfWork.ComplianceRequestRepository.GetRescheduleRequestsForManager();
    }

    public async Task<TeamShortageDto> SubmitTeamShortageRequest(TeamShortageDto dto)
    {
        var visit = await unitOfWork.ComplianceRequestRepository.GetComplianceVisitDetail(dto.ComplianceDetailsId);

        var entity = new TeamShortage
        {
            ComplianceDetailsId = dto.ComplianceDetailsId,
            VisitDate = visit.Model?.VisitDate,
            LicensedEntityId = visit.Model?.LicensedEntityId,
            ShortageReason = dto.ShortageReason,
            CreatedBy = currentUserService.User.UserName
        };
        var result = await unitOfWork.ComplianceRequestRepository.AddTeamShortage(entity);

        if (result != null)
        {
            var team = new TeamShortageDto
            {
                Id = result.Id,
                ComplianceDetailsId = result.ComplianceDetailsId,
                VisitDate = result.VisitDate,
                LicensedEntityId = result.LicensedEntityId,
                LicensedEntityName = result?.ComplianceDetails?.LicensedEntity.ValueAr ?? "",
                ShortageReason = result?.ShortageReason,
                CreatedOn = result.CreatedOn,
                CreatedBy = result?.CreatedBy
            };

            List<Guid> VisitIDs = [result.ComplianceDetailsId];

            await SendNotifycationToManagerForTeamShortage(VisitIDs);
            await SendSmsToSpecialistForTeamShortage(VisitIDs);
            return team;
        }
        else return new TeamShortageDto();
    }

    public async Task<List<TeamShortageDto>> GetByComplianceDetailsIds(List<Guid> complianceDetailsIds)
    {
        if (complianceDetailsIds == null || complianceDetailsIds.Count < 1)
            throw new Exception("Please Assign at least On Visit ID.");
        else
        {
            var items = await unitOfWork.ComplianceRequestRepository.GetTeamShortageByVisitId(complianceDetailsIds);

            return items.Select(sr => new TeamShortageDto
            {
                Id = sr.Id,
                ComplianceDetailsId = sr.ComplianceDetailsId,
                VisitDate = sr.VisitDate,
                LicensedEntityId = sr.LicensedEntityId,
                ShortageReason = sr.ShortageReason,
                CreatedOn = sr.CreatedOn,
                CreatedBy = sr.CreatedBy
            }).ToList();
        }
    }

    public async Task SendNotifycationToManagerForTeamShortage(List<Guid> VisitDeatilasID)
    {
        var request =  unitOfWork.ComplianceRequestRepository.GetTeamShortageByVisitId(VisitDeatilasID).Result.FirstOrDefault();
        var managers = unitOfWork.UserRepository.GetUsers(new List<string> { RoleEnum.ComplianceManager }).Result.Model;

        var managerEmails = managers?.Where(c => !string.IsNullOrEmpty(c.Email)).Select(c => c.Email).ToList() ?? new List<string>();

        var visit = GetComplianceVisitDetail(request.ComplianceDetailsId).Result?.Model;

        var allEmails = managerEmails;
        
        allEmails = allEmails.Distinct().ToList();

        if (request != null && allEmails.Any())
        {
            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
            {
                Content = new Dictionary<string, object>
                {
                { "EmployeeName", "مدير الإمتثال" },
                { "VisitNumber", visit?.VisitReferenceNumber?.ToString()  ?? ""},
                { "LicensedEntityName", visit?.LicensedEntityName ?? "" },
                { "ActionUrl", "#" }
                },


                ViewName = "TeamShortagesNotify.cshtml",
                Subject = "تنبيه بنقص الفريق",
                Body = $"سبب النقص: {request.ShortageReason}",
                To = allEmails
            });
        }
    }

    public async Task SendSmsToSpecialistForTeamShortage(List<Guid> VisitDeatilasID)
    {
        var Request = unitOfWork.ComplianceRequestRepository.GetTeamShortageByVisitId(VisitDeatilasID).Result.FirstOrDefault();
        var Specialist = unitOfWork.UserRepository.GetUsers([RoleEnum.ComplianceSpecialist]).Result.Model?.ToList();

        var visit = GetComplianceVisitDetail(Request.ComplianceDetailsId).Result?.Model;


        if (Specialist != null)
        {
            var SendTo = Specialist?.Where(c => !string.IsNullOrEmpty(c.MobileNumber)).ToList();
            if (SendTo != null)
            {
                foreach(var item in SendTo)
                {
                    var mobileNumbers = new List<string> { item?.MobileNumber ?? "" };
                    string messageBody =
  $"عزيزي: مدير الامتثال، " +
  $"تم تسجيل نقص في الفريق. " +
  $"رقم الزيارة: {visit?.VisitReferenceNumber}, " +
  $"تاريخ الزيارة: {visit?.VisitDate:yyyy-MM-dd}, " +
  $"اسم الجهة: {visit?.LicensedEntityName}, " +
  $"سبب النقص: {Request?.ShortageReason}.";

                    var content = new Dictionary<string, string>() {
                     { "{VisitDate}", Request?.VisitDate?.ToShortDateString() ?? ""},
                };

                    foreach (var pair in content)
                    {
                        messageBody = messageBody.Replace(pair.Key, pair.Value ?? string.Empty);
                    }

                    await notificationService(NotificationTypeEnum.SMS).SendAsync(
                        new NotificationMessageModel()
                        {
                            To = mobileNumbers,
                            Body = messageBody,
                        }
                    );
                }
            }
        }
    }

    public async Task<ResponseResult<string>> ReturnLicenseNumber(long LicenseEntityID)
    {
       return await unitOfWork.ComplianceRequestRepository.ReturnLicenseNumber(LicenseEntityID);
    }
    #endregion
}
