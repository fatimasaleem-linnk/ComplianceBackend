using ComplianceAndPeformanceSystem.Contract.Common.Exceptions;
using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Dtos.Compliance;
using ComplianceAndPeformanceSystem.Contract.Dtos.ComplianceVisit;
using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.IRepositories;
using ComplianceAndPeformanceSystem.Contract.IServices;
using ComplianceAndPeformanceSystem.Contract.Models;
using ComplianceAndPeformanceSystem.Contract.Models.Compliance;
using ComplianceAndPeformanceSystem.Core.Entities;
using Hangfire;
using Microsoft.AspNetCore.Http;
using System.Data.Common;

namespace ComplianceAndPeformanceSystem.BLL.Services;

public class ComplianceRequestService(IUnitOfWork unitOfWork ,ICurrentUserService currentUserService, ICurrentLanguageService currentLanguageService,
    Func<NotificationTypeEnum, INotificationService> notificationService) : IComplianceRequestService
{
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
            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
            {
                Content = new Dictionary<string, object>() { { "EmployeeName", "مدير الادارة" }, { "ActionUrl", "#" } },
                ViewName = "CreateComplianceRequest.cshtml",
                Subject = "البدء بإعداد خطة الامتثال السنوية",
                To = complianceManager.Model.Select(s => s.Email).ToList()
            });
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
        var notifications = (await unitOfWork.ComplianceRequestRepository.GetComplianceNotifications(currentUserService.User.Role)).Model;
        var complianceRequest = (await unitOfWork.ComplianceRequestRepository.GetComplianceRequest())?.Model;
        if (notifications != null && complianceRequest != null && notificationsResult != null)
        {
            if(currentUserService.User.Role.Contains(RoleEnum.ComplianceSpecialist))
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

                if(complianceRequest.StatusId == (int)ComplianceStatusEnum.PendingReviewOfComplianceManager)
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
                    var scheduledVisits = (await unitOfWork.ComplianceRequestRepository.GetVisitsByStatusForLoggedInUser(currentUserService.User.UserId, (long) VisitStatusEnum.Scheduled));

                    if (scheduledVisits != null && scheduledVisits.Model != null && scheduledVisits.Model.Count() > 0)
                    {
                        foreach (var visit in scheduledVisits.Model)
                        {
                            if (visit.ComplianceVisitSpecialists?.FirstOrDefault(vs=> vs.SpecialistUserId.Equals(currentUserService.User.UserId))?.ComplianceVisitDisclosure == null)
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

                    if (scheduledVisits!=null && scheduledVisits?.Count() > 0 ) 
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
                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.PendingReviewOfPerformanceMonitoringManager)
                {
                    if (complianceRequest.RemainingDays > 5)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 10);
                        if (notification != null)
                            notificationsResult.Add(notification);
                        
                    }


                    if (complianceRequest.RemainingDays == 2)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 11);
                        if (notification != null)
                            notificationsResult.Add(notification);
                    }

                    
                    if (complianceRequest.RemainingDays <= 0)
                    {
                        var notification = notifications.FirstOrDefault(s => s.Id == 12);
                        if (notification != null)
                            notificationsResult.Add(notification);
                    }
                }


                if (complianceRequest.StatusId == (int)ComplianceStatusEnum.PendingReviewOfComplianceManager)
                {
                    var notification = notifications.FirstOrDefault(s => s.Id == 9);
                    if (notification != null)
                    {
                        notification.MessageTitle = notification.MessageTitle.Replace("{{PlanTitle}}", complianceRequest.AssignTaskName);
                        notificationsResult.Add(notification);
                    }
                }
            }

        }


        return ResponseResult<List<ComplianceNotificationMessageDto>>.Success(notificationsResult);
    
    }

    public async Task<ResponseResult<ComplianceRequestDto>> GetComplianceRequest()
    {
        var result = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest();
        if (result != null && result.Model != null)
            result.Model.ComplianceNotificationMessages = GetNotifications()?.Result?.Model;
        return result;
    }

    public async Task<ResponseResult<GetComplianceRequestStatusDto>> GetComplianceRequestStatus()
    {
        var compliance = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest();
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
    
    public async Task<ResponseResult<bool>> AssignComplianceSpecialist(AssignComplianceSpecialistModel model)
    {
        var result = await unitOfWork.ComplianceRequestRepository.AssignComplianceSpecialist(model);
        await unitOfWork.CommitAsync();
        BackgroundJob.Enqueue(() => 
            SendAssignComplianceSpecialist(result.Model)
        );

        return ResponseResult<bool>.Success(true);
    }


    public async Task SendAssignComplianceSpecialist(KeyValuePair<List<string>, bool> result)
    {
        var allUsers = (await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.ComplianceSpecialist, RoleEnum.PerformanceMonitoringManager })).Model;
        if (allUsers != null && allUsers != null)
        {
            var users = allUsers.Where(s => result.Key.Contains(s.Id)).ToList();
            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
            {
                Content = new Dictionary<string, object>() { { "EmployeeName", "اخصائي الالتزام" }, { "ActionUrl", "#" } },
                ViewName = "AssignComplianceSpecialist.cshtml",
                Subject = result.Value == false ? "البدء بإعداد خطة الامتثال السنوية":"تعيين اخصائي للخطة الامتثال السنوية",
                To = users.Where(s => s.Roles.Contains(RoleEnum.ComplianceSpecialist)).Select(s => s.Email).ToList(),
                CC = allUsers.Where(s => s.Roles.Contains(RoleEnum.PerformanceMonitoringManager)).Select(s => s.Email).ToList(),
            });
        }
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
        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(isEmail: true);
        var performanceMonitoringManagers = await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.PerformanceMonitoringManager });
        if (performanceMonitoringManagers != null && performanceMonitoringManagers.Model != null)
        {
            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
            {
                Content = new Dictionary<string, object>() { { "EmployeeName", "مدير عام مراقبة الاداء" }, { "SenderName", senderName }, { "PlanTitle", request.Model.AssignTaskName }, { "RequestNumber", request.Model.Seq }, { "SubmissionDate", DateTime.Now }, { "ActionUrl", "#" } },
                ViewName = "SendComplianceRequest.cshtml",
                Subject = "خطة امتثال سنوية جديدة مُقدمة للمراجعة",
                To = performanceMonitoringManagers.Model.Select(s => s.Email).ToList(),
                CC = request.Model.AssignedSpecialists.Select(s => s.SpecialistUserEmail).ToList()
            });
        }
    }

    public async Task SendComplianceRequestForPerformanceComplianceManager(string senderName)
    {
        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(isEmail: true);
        var complianceManager = await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.ComplianceManager });
        if (complianceManager != null && complianceManager.Model != null)
        {
            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
            {
                Content = new Dictionary<string, object>() { { "EmployeeName", "مدير الادارة" }, { "SenderName", senderName }, { "PlanTitle", request.Model.AssignTaskName }, { "RequestNumber", request.Model.Seq }, { "SubmissionDate", DateTime.Now }, { "ActionUrl", "#" } },
                ViewName = "SendComplianceRequest.cshtml",
                Subject = "خطة امتثال سنوية جديدة مُقدمة للمراجعة",
                To = complianceManager.Model.Select(s => s.Email).ToList(),
                CC = request.Model.AssignedSpecialists.Select(s => s.SpecialistUserEmail).ToList()
            });
        }
    }
    public async Task<ResponseResult<bool>> ApproveComplianceRequestByComplianceManager(ApproveOrRejectComplianceRequestModel model)
    {
        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest();
        if (request?.Model?.StatusId != (int)ComplianceStatusEnum.PendingReviewOfComplianceManager)
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
        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(isEmail: true);
        var performanceMonitoringManagers = await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.PerformanceMonitoringManager });
        if (performanceMonitoringManagers != null && performanceMonitoringManagers.Model != null)
        {
            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
            {
                Content = new Dictionary<string, object>() { { "EmployeeName", "مدير عام مراقبة الاداء" }, { "SenderName", senderName }, { "PlanTitle", request.Model.AssignTaskName }, { "RequestNumber", request.Model.Seq }, { "SubmissionDate", DateTime.Now }, { "ActionUrl", "#" } },
                ViewName = "SendComplianceRequest.cshtml",
                Subject = "خطة امتثال سنوية جديدة مُقدمة للمراجعة",
                To = performanceMonitoringManagers.Model.Select(s => s.Email).ToList(),
                CC = request.Model.AssignedSpecialists.Select(s => s.SpecialistUserEmail).ToList()
            });
        }
    }

    public async Task<ResponseResult<bool>> ReturnComplianceRequestByComplianceManager(ApproveOrRejectComplianceRequestModel model)
    {
        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest();
        if (request?.Model?.StatusId != (int)ComplianceStatusEnum.PendingReviewOfComplianceManager)
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
        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(isEmail: true);
        var complianceManager = await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.ComplianceManager });
        if (complianceManager != null && complianceManager.Model != null)
        {
            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
            {
                Content = new Dictionary<string, object>() { { "From", "مدير الادارة" }, { "EmployeeName", "اخصائي" }, { "SenderName", senderName }, { "PlanTitle", request.Model.AssignTaskName }, { "RequestNumber", request.Model.Seq }, { "SubmissionDate", DateTime.Now }, { "ActionUrl", "#" } },
                ViewName = "ReturnComplianceRequest.cshtml",
                Subject = "تم ارجاع خطة امتثال السنوية المُقدمة ",
                To = request.Model.AssignedSpecialists.Select(s => s.SpecialistUserEmail).ToList(),
                CC = complianceManager.Model.Select(s => s.Email).ToList()
            });
        }
    }

    public async Task<ResponseResult<bool>> ApproveComplianceRequestByPerformanceMonitoringManager(ApproveOrRejectComplianceRequestModel model)
    {
        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest();
        if (request?.Model?.StatusId != (int)ComplianceStatusEnum.PendingReviewOfPerformanceMonitoringManager)
            throw new ValidationException(new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("Status", currentLanguageService.Language == LanguageEnum.En ? "Performance Monitoring Manager role only can be Approve" : "لا يمكن الموافقة الا من قبل مدير مراقبة الاداء اولا") });


        model.Role = RoleEnum.PerformanceMonitoringManager;
        model.IsApproved = true;
        var result = await unitOfWork.ComplianceRequestRepository.ApproveOrRejectComplianceRequest(model, ComplianceStatusEnum.ApprovalOfPerformanceMonitoringManager);
        await unitOfWork.CommitAsync();
        await UpdateRemainingDays();

        return result;

    }

    public async Task<ResponseResult<bool>> ReturnComplianceRequestByPerformanceMonitoringManager(ApproveOrRejectComplianceRequestModel model)
    {
        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest();
        if (request?.Model?.StatusId != (int)ComplianceStatusEnum.PendingReviewOfPerformanceMonitoringManager)
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
        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(isEmail: true);
        var PerformanceMonitoringManager = await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.PerformanceMonitoringManager });
        if (PerformanceMonitoringManager != null && PerformanceMonitoringManager.Model != null)
        {
            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
            {
                Content = new Dictionary<string, object>() { { "From", "مدير الادارة" }, { "EmployeeName", "اخصائي" }, { "SenderName", senderName }, { "PlanTitle", request.Model.AssignTaskName }, { "RequestNumber", request.Model.Seq }, { "SubmissionDate", DateTime.Now }, { "ActionUrl", "#" } },
                ViewName = "ReturnComplianceRequest.cshtml",
                Subject = "تم ارجاع خطة امتثال السنوية المُقدمة ",
                To = request.Model.AssignedSpecialists.Select(s => s.SpecialistUserEmail).ToList(),
                CC = PerformanceMonitoringManager.Model.Select(s => s.Email).ToList()
            });
        }
    }

    public async Task<ResponseResult<bool>> ChangeRequestStatus(long requestStatusId)
    {
        throw new NotImplementedException();
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

        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(isEmail: true);
        var complianceManagers = await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.ComplianceManager });

        string currentMonthName = DateTime.Now.ToString("MMMM");

        var quarterName = request.Model?.CompliancePlans?.Where(p => p.QuarterPlannedForVisitNameEn.Contains(currentMonthName)).FirstOrDefault()?.QuarterPlannedForVisitName;
        
        var quarterNameEnForPendingVisits = request.Model?.CompliancePlans?.Where(p => p.QuarterPlannedForVisitNameEn.Contains(currentMonthName)).FirstOrDefault()?.QuarterPlannedForVisitNameEn;
        quarterNameEnForPendingVisits = string.Join(" ", quarterNameEnForPendingVisits.Split(' ', StringSplitOptions.RemoveEmptyEntries).Take(2));


        int? pendingVists = request.Model?.CompliancePlans?.Where( p =>
            p.QuarterPlannedForVisitNameEn.StartsWith(quarterNameEnForPendingVisits)
        ).Count();
        
        if (complianceManagers != null && complianceManagers.Model != null && pendingVists!=null && pendingVists > 0)
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

    public async Task<ResponseResult<List<ComplianceSpecialistDto>>> GetComplianceRequestSpecialists()
    {
        var result = await unitOfWork.ComplianceRequestRepository.GetComplianceRequestSpecialists();
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
        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(isEmail: true);
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
        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(isEmail: true);
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
                List<string> listCC =  visitSpecialists != null && visitSpecialists.Model != null ? visitSpecialists.Model.Select(s => s.SpecialistUserEmail).ToList() : new List<string>();

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
        var request = await unitOfWork.ComplianceRequestRepository.GetComplianceRequest(isEmail: true);
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
                            .Where(c => !String.IsNullOrEmpty(c.MobileNumber))
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
        await unitOfWork.CommitAsync();
        BackgroundJob.Enqueue(() =>
            NotifyAssignedAndConflictedComplianceVisitSpecialist(result.Model, model.ComplianceDetailsId)
        );
        if(result.Succeeded)
            return ResponseResult<bool>.Success(true);
        else
            return ResponseResult<bool>.Failure(new List<string> { "An error occured while assigning visit specialists." }, false);
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

            if (result.IsUpdate && result.NotifyConflictUsers != null && result.NotifyConflictUsers.Count()>0) 
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
    public async Task<ResponseResult<bool>> AddVisitAttachment(List<IFormFile> attachmentvm, Guid ComplianceDetailsID)
    {
        var request = await unitOfWork.ComplianceRequestRepository.AddAttachment(attachmentvm, ComplianceDetailsID);
        if (!request.Model != false)
            throw new ValidationException([new KeyValuePair<string, string>("Status", currentLanguageService.Language == LanguageEnum.En ? "Visit documents cannot be saved." : "لا يمكن حفظ  مستندات الزيارة ")]);
        else
            await SendNotificationToLicensedEntityforUploadDocument(ComplianceDetailsID, currentUserService.User.UserName);
        await SendSMSUploadAttachmentSecsessed(ComplianceDetailsID);
        return request;
    }
    public async Task SendSMSUploadAttachmentSecsessed(Guid ComplianceDetailsID)
    {
        var complianceVisits = unitOfWork.ComplianceRequestRepository.GetComplianceVisit()?.Result?.Model?.Where(s => s.Id == ComplianceDetailsID).FirstOrDefault();
        var LicensedEntity = unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.LicensedEntity }).Result.Model?.ToList();

        if (LicensedEntity != null)
        {
            var _LicensedEntityId = complianceVisits?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !String.IsNullOrEmpty(c.MobileNumber) & c.Id == _LicensedEntityId).FirstOrDefault();
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

        if (LicensedEntity != null)
        {
            var _LicensedEntityId = request?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !String.IsNullOrEmpty(c.Email) & c.Id == _LicensedEntityId).FirstOrDefault();
            var LicensedEmail = new List<string> { SendTo?.Email ?? "" };

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
                string messageBody = "Entity [LicenseeName] failed to upload required documents for visit on [VisitDate]. Please follow up\r\n Best regards,\r\n";
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
                    To = ComplianceManager?.Select(s => s.Email).ToList() ?? new List<string>(),
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

    public async Task<ResponseResult<DocumentExtensionRequestDto>> AddExtensionRequest(DocumentExtensionRequestDto request, Guid complianceDetailsId)
    {
        var res = unitOfWork.ComplianceRequestRepository.AddExtensionRequest(request, complianceDetailsId)?.Result;
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
            var SendTo = LicensedEntity?.Where(c => !String.IsNullOrEmpty(c.Email) & c.Id == _LicensedEntityId).FirstOrDefault();
            var LicensedEmail = new List<string> { SendTo?.Email ?? "" };

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
    public async Task SendNotifycationToEntityforExtensionRequestSubmitted(Guid RequestID)
    {
        var request = unitOfWork.ComplianceRequestRepository.GetExtensionRequest(RequestID)?.Result?.Model;
        var LicensedEntity = unitOfWork.UserRepository.GetUsers([RoleEnum.LicensedEntity]).Result.Model?.ToList();
        var visit = GetComplianceVisit().Result?.Model?.FirstOrDefault(x => x.Id == request.ComplianceDetailsID);

        if (LicensedEntity != null)
        {
            var _LicensedEntityId = request?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !String.IsNullOrEmpty(c.Email) & c.Id == _LicensedEntityId).FirstOrDefault();
            var LicensedEmail = new List<string> { SendTo?.Email ?? "" };

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
    public async Task SendNotifycationToEntityforExtensionRequestRejection(Guid RequestID)
    {
        var request = unitOfWork.ComplianceRequestRepository.GetExtensionRequest(RequestID)?.Result?.Model;
        var LicensedEntity = unitOfWork.UserRepository.GetUsers([RoleEnum.LicensedEntity]).Result.Model?.ToList();
        var visit = GetComplianceVisit().Result?.Model?.FirstOrDefault(x => x.Id == request.ComplianceDetailsID);

        if (LicensedEntity != null)
        {
            var _LicensedEntityId = request?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !String.IsNullOrEmpty(c.Email) & c.Id == _LicensedEntityId).FirstOrDefault();
            var LicensedEmail = new List<string> { SendTo?.Email ?? "" };

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

    public async Task<ResponseResult<DocumentExtensionRequestDto>> GetExtensionRequest(Guid id)
        => await unitOfWork.ComplianceRequestRepository.GetExtensionRequest(id);
    public async Task<ResponseResult<List<DocumentExtensionRequestDto>>> ExtensionRequests()
    => await unitOfWork.ComplianceRequestRepository.ExtensionRequests();

    public async Task<ResponseResult<List<DocumentExtensionRequestDto>>> GetExtensionRequestByEntityId(long licensedEntityId)
        => await unitOfWork.ComplianceRequestRepository.GetExtensionRequestByEntityId(licensedEntityId);

    public async Task<ResponseResult<DocumentExtensionReviewDto>> UpdateExtensionRequest(DocumentExtensionReviewDto dto, Guid requestId, Guid managerId)
    {
        var res = await unitOfWork.ComplianceRequestRepository.UpdateExtensionRequest(dto, requestId, managerId);
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

    public async Task<ResponseResult<ComplianceDetailsDto>> CancelVisitByManager(CancelVisitDto dto)
    {
        var res = unitOfWork.ComplianceRequestRepository.CancelVisitByManager(dto)?.Result;
        if (!res.Succeeded)
            throw new Exception("Can't Cancel a Visit");
        else
            await SendSMSToEntityForCancelVisit(res.Model.Id);
        await SendNotificationToEntityForCancelVisit(res.Model.Id);
        return res;
    }

    public async Task<ResponseResult<ReviewRescheduleDto>> RequestReschedule(RequestRescheduleDto dto)
    {
        var res = unitOfWork.ComplianceRequestRepository.RequestReschedule(dto)?.Result;
        if (!res.Succeeded)
        {
            throw new Exception("Can't Reschedule a Visit");
        }
        else if (res.Model?.Status == (long?)VisitStatusEnum.Rescheduled)
        {
            await SendSMSToEntityForRescheduleVisit(res.Model.ComplianceDetailsID);
            await SendNotificationToEntityForRescheduleVisit(res.Model.ComplianceDetailsID);
        }
        else if (res.Model?.Status == (long?)VisitStatusEnum.RescheduleRequested)
        {
            await SendSMSToEntityForRequestRescheduleVisit(res.Model.RequestId, res.Model.LicensedEntityId);
            await SendNotificationToEntityForRequestRescheduleVisit(res.Model.RequestId, res.Model.LicensedEntityId);
        }
        return res;
    }

    public async Task<ResponseResult<List<ReviewRescheduleDto>>>? GetRescheduleRequests(long? LicensedID)
       => await unitOfWork.ComplianceRequestRepository.GetRescheduleRequests(LicensedID);

    public async Task<ResponseResult<ComplianceDetailsDto>> ReviewReschedule(ReviewRescheduleDto dto)
    {
        var res = unitOfWork.ComplianceRequestRepository.ReviewRescheduleAsync(dto)?.Result;
        if (!res.Succeeded)
        {
            throw new Exception("Can't Reschedule a Visit");
        }
        else if (res?.Model.VisitStatusId == (long?)VisitStatusEnum.Rescheduled)
        {
            await SendSMSToEntityForRescheduleVisit(res.Model.Id);
            await SendNotificationToEntityForRescheduleVisit(res.Model.Id);
        }
        else
        {
               /// await SendSMSToEntityForRequestRescheduleVisit(res.re, res?.LicensedEntityId);
                //await SendNotificationToEntityForRequestRescheduleVisit(res.Model.Id);
        }
            return res;
    }

    public async Task<ResponseResult<ComplianceDetailsDto>> UpdateVisitStatus(UpdateVisitStatusDto statusDto)
        => await unitOfWork.ComplianceRequestRepository.UpdateVisitStatus(statusDto);
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
            var SendTo = LicensedEntity?.Where(c => !String.IsNullOrEmpty(c.MobileNumber) & c.Id == _LicensedEntityId).FirstOrDefault();
            var mobileNumbers = new List<string> { SendTo?.MobileNumber ?? "" };

            if (SendTo != null)
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
            var SendTo = LicensedEntity?.Where(c => !String.IsNullOrEmpty(c.MobileNumber) & c.Id == _LicensedEntityId).FirstOrDefault();
            var LicensedEmail = new List<string> { SendTo?.MobileNumber ?? "" };

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
            var SendTo = LicensedEntity?.Where(c => !String.IsNullOrEmpty(c.MobileNumber) & c.Id == _LicensedEntityId).FirstOrDefault();
            var mobileNumbers = new List<string> { SendTo?.MobileNumber ?? "" };

            if (SendTo != null)
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
            var SendTo = LicensedEntity?.Where(c => !String.IsNullOrEmpty(c.MobileNumber) & c.Id == _LicensedEntityId).FirstOrDefault();
            var LicensedEmail = new List<string> { SendTo?.MobileNumber ?? "" };

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
        return ResponseResult<bool>.Success(false);
    }

    public async Task SendSMSToEntityForRequestRescheduleVisit(int RequestId, long LicenseID)
    {
        var _request = unitOfWork.ComplianceRequestRepository.GetRescheduleRequests(LicenseID)?.Result?.Model?.Where(a => a.RequestId == RequestId).FirstOrDefault();
        var complianceVisits = unitOfWork.ComplianceRequestRepository.GetComplianceVisit()?.Result?.Model?.Where(s => s.Id == _request?.ComplianceDetailsID).FirstOrDefault();
        var LicensedEntity = unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.LicensedEntity }).Result.Model?.ToList();
        if (LicensedEntity != null)
        {
            var _LicensedEntityId = complianceVisits?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !String.IsNullOrEmpty(c.MobileNumber) & c.Id == _LicensedEntityId).FirstOrDefault();
            var mobileNumbers = new List<string> { SendTo?.MobileNumber ?? "" };

            if (SendTo != null)
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
        var _request = unitOfWork.ComplianceRequestRepository.GetRescheduleRequests(LicenseID)?.Result?.Model?.Where(a => a.RequestId == RequestId).FirstOrDefault();
        var complianceVisits = unitOfWork.ComplianceRequestRepository.GetComplianceVisit()?.Result?.Model?.Where(s => s.Id == _request?.ComplianceDetailsID).FirstOrDefault();

        var LicensedEntity = unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.LicensedEntity }).Result.Model?.ToList();

        if (LicensedEntity != null)
        {
            var _LicensedEntityId = complianceVisits?.LicensedEntityId.ToString();
            var SendTo = LicensedEntity?.Where(c => !String.IsNullOrEmpty(c.MobileNumber) & c.Id == _LicensedEntityId).FirstOrDefault();
            var LicensedEmail = new List<string> { SendTo?.MobileNumber ?? "" };

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
    public async Task<ResponseResult<ComplianceVisitDisclosureDto>> GetVisitDisclosureFormForComplianceManager(Guid visitId, Guid visitSpecialistId)
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
        var conflictedVisitSpecialist = await unitOfWork.ComplianceRequestRepository.GetComplianceVisitDisclosureBySpecialistId(disclosureDto.ComplianceVisitSpecialistId);

        if (visit.Model.VisitStatusId.Equals((long)VisitStatusEnum.ConflictOfInterestDisclosure)
            && conflictedVisitSpecialist.Model.HasConflicts
            && complianceManagers != null
            && complianceManagers.Model != null
        )
        {
            await notificationService(NotificationTypeEnum.Email).SendAsync(new NotificationMessageModel()
            {
                Content = new Dictionary<string, object>() {
                    { "EmployeeName", "مدير الادارة" },
                    { "VisitDate", visit.Model.VisitDate },
                    { "LicenseeName", visit.Model.LicensedEntityName },
                    { "VisitSpecialistName", visit.Model.ComplianceVisitSpecialists.FirstOrDefault(s=> s.Id.Equals(disclosureDto.ComplianceVisitSpecialistId)).SpecialistUserName},
                    { "ActionUrl", "#" }
                },
                ViewName = "VisitTeamMemberDisclosureConflict.cshtml",
                Subject = $"تم تحديد الصراع في مهمة الفريق.",
                To = complianceManagers.Model.Select(s => s.Email).ToList(),
                CC = new List<string> { visit.Model.ComplianceVisitSpecialists.FirstOrDefault(s => s.Id.Equals(disclosureDto.ComplianceVisitSpecialistId)).SpecialistUserEmail }
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

}
