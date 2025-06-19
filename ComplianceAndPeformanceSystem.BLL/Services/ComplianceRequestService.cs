using ComplianceAndPeformanceSystem.Contract.Common.Exceptions;
using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Dtos.ComplianceVisit;
using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.IRepositories;
using ComplianceAndPeformanceSystem.Contract.IServices;
using ComplianceAndPeformanceSystem.Contract.Models;
using ComplianceAndPeformanceSystem.Contract.Models.Compliance;
using Hangfire;
using Microsoft.AspNetCore.Http;

namespace ComplianceAndPeformanceSystem.BLL.Services;

public class ComplianceRequestService(IUnitOfWork unitOfWork ,ICurrentUserService currentUserService, ICurrentLanguageService currentLanguageService, Func<NotificationTypeEnum, INotificationService> notificationService) : IComplianceRequestService
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
                    var notification = notifications.FirstOrDefault(s => s.Id == 21);
                    if (notification != null)
                        notificationsResult.Add(notification);

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

                    //to do: change schema and modify code to  filter visits according to whether or not the disclosure is submitted.
                    //to do: filter those where not submitted, so that we can notify the specialist to start working on disclosure.
                    var scheduledVisits = (await unitOfWork.ComplianceRequestRepository.GetVisitsByStatusForLoggedInUser(currentUserService.User.UserId, (long) VisitStatusEnum.Scheduled));

                    if (scheduledVisits != null && scheduledVisits.Model != null && scheduledVisits.Model.Count() > 0)
                    {
                        foreach (var visit in scheduledVisits.Model)
                        {
                            //to do: change schema and modify code for check if specialist has filled disclosure form or not.
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
                        var notification = notifications.FirstOrDefault(s => s.Id == 25);

                        string currentMonthName = DateTime.Now.ToString("MMMM");
                        var quarterName = complianceRequest?.CompliancePlans?.Where(p => p.QuarterPlannedForVisitNameEn.Contains(currentMonthName)).FirstOrDefault()?.QuarterPlannedForVisitName;

                        notification.MessageBody = notification?.MessageBody.Replace("{QuarterName}", quarterName.ToString());

                        if (notification != null)
                            notificationsResult.Add(notification);
                                            
                    }

                    var scheduledVisits = (await unitOfWork.ComplianceRequestRepository.GetNewVisitsForCurrentQuarter());

                    foreach(var visit in scheduledVisits)
                    {
                        if (visit.VisitStatusId.Equals((long)VisitStatusEnum.New))
                        {
                            var notification = notifications.FirstOrDefault(s => s.Id == 26);

                            notification.MessageBody = notification?.MessageBody
                                .Replace("{LicenseeName}", visit.LicensedEntityName.ToString())
                                .Replace("{VisitDate}", visit.VisitDate.Value.ToString("dd-MMMM-yyyy"));

                            if (notification != null)
                                notificationsResult.Add(notification);
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

    public async Task<ResponseResult<bool>> AssignComplianceVisitSpecialist(AssignComplianceVisitSpecialistModel model)
    {
        var result = await unitOfWork.ComplianceRequestRepository.AssignComplianceVisitSpecialist(model);
        await unitOfWork.CommitAsync();
        BackgroundJob.Enqueue(() =>
            NotifyAssignedComplianceVisitSpecialist(result.Model, model.ComplianceDetailsId)
        );
        if(result.Succeeded)
            return ResponseResult<bool>.Success(true);
        else
            return ResponseResult<bool>.Failure(new List<string> { "An error occured while assigning visit specialists." }, false);
    }

    public async Task NotifyAssignedComplianceVisitSpecialist(KeyValuePair<List<string>, bool> result, Guid visitId)
    {
        var visit = (await unitOfWork.ComplianceRequestRepository.GetComplianceVisitDetail(visitId)).Model;

        var allUsers = (await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.ComplianceSpecialist })).Model;
        if (allUsers != null && allUsers != null)
        {
            var users = allUsers.Where(s => result.Key.Contains(s.Id)).ToList();
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
                To = users.Where(s => s.Roles.Contains(RoleEnum.ComplianceSpecialist)).Select(s => s.Email).ToList(),
            });
        }
    }

    public async Task<ResponseResult<bool>> AddVisitAttachment(List<IFormFile> attachmentvm, Guid ComplianceDetailsID)
    {
        var request = await unitOfWork.ComplianceRequestRepository.AddAttachment(attachmentvm, ComplianceDetailsID);
        if (!request.Succeeded)
            throw new ValidationException([new KeyValuePair<string, string>("Status", currentLanguageService.Language == LanguageEnum.En ? "Visit documents cannot be saved." : "لا يمكن حفظ  مستندات الزيارة ")]);
        else
            BackgroundJob.Enqueue(() => SendNotificationToLicensedEntityforUploadDocument(ComplianceDetailsID, currentUserService.User.UserName));
        return request;
    }
    public async Task<ResponseResult<bool>> SendNotificationToLicensedEntityforUploadDocument(Guid ComplianceDetailsID, string senderName)
    {
        var visit = await unitOfWork.ComplianceRequestRepository.GetComplianceVisit();
        var request = visit?.Model?.Where(a => a.Id == ComplianceDetailsID).FirstOrDefault();

        var LicensedEntity = await unitOfWork.UserRepository.GetUsers(new List<string>() { RoleEnum.LicensedEntity });
        if (LicensedEntity != null && LicensedEntity.Model != null)
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
                Body = "",
                ViewName = "SubmitDocumentForm.cshtml",
                Subject = "تحميل المستندات الخاصة بزيارة الإمتثال",
                To = LicensedEntity.Model.Select(s => s.Email).ToList()
            });
            return ResponseResult<bool>.Success(true);
        }
        return ResponseResult<bool>.Success(false);
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
        => await unitOfWork.ComplianceRequestRepository.AddExtensionRequest(request, complianceDetailsId);

    public async Task<ResponseResult<DocumentExtensionRequestDto>> GetExtensionRequest(Guid id)
        => await unitOfWork.ComplianceRequestRepository.GetExtensionRequest(id);

    public async Task<ResponseResult<List<DocumentExtensionRequestDto>>> GetExtensionRequestByEntityId(long licensedEntityId)
        => await unitOfWork.ComplianceRequestRepository.GetExtensionRequestByEntityId(licensedEntityId);

    public async Task<ResponseResult<DocumentExtensionReviewDto>> UpdateExtensionRequest(DocumentExtensionReviewDto dto, Guid requestId, Guid managerId)
        => await unitOfWork.ComplianceRequestRepository.UpdateExtensionRequest(dto, requestId, managerId);

    public async Task<ResponseResult<List<ExtensionStatusHistoryDto>>> GetExtensionRequestHistory(Guid requestId)
        => await unitOfWork.ComplianceRequestRepository.GetExtensionRequestHistory(requestId);

    public async Task<ResponseResult<ComplianceDetailsDto>> CancelVisitByManager(CancelVisitDto dto)
        => await unitOfWork.ComplianceRequestRepository.CancelVisitByManager(dto);

    public async Task<ResponseResult<ComplianceDetailsDto>> RequestReschedule(RequestRescheduleDto dto)
        => await unitOfWork.ComplianceRequestRepository.RequestReschedule(dto);

    public async Task<ResponseResult<ComplianceDetailsDto>> ReviewReschedule(ReviewRescheduleDto dto)
        => await unitOfWork.ComplianceRequestRepository.ReviewRescheduleAsync(dto);

    public async Task<ResponseResult<ComplianceDetailsDto>> UpdateVisitStatus(UpdateVisitStatusDto statusDto)
        => await unitOfWork.ComplianceRequestRepository.UpdateVisitStatus(statusDto);




    #endregion
}
