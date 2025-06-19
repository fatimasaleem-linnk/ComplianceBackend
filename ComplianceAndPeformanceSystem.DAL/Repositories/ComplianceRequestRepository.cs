using Azure.Core;
using ComplianceAndPeformanceSystem.Contract.Common.Exceptions;
using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.IRepositories;
using ComplianceAndPeformanceSystem.Contract.IServices;
using ComplianceAndPeformanceSystem.Contract.Models;
using ComplianceAndPeformanceSystem.Contract.Models.Compliance;
using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data;
using System.Globalization;

namespace ComplianceAndPeformanceSystem.DAL.Repositories;

internal class ComplianceRequestRepository(IComplianceAndPeformanceDbContext dbContext, ICurrentUserService currentUserService, ICurrentLanguageService currentLanguageService) : IComplianceRequestRepository
{
    #region Phase 1
    public async Task<ResponseResult<List<ComplianceNotificationMessageDto>>> GetComplianceNotifications(List<string> rolesName)
    {
        var notifications = await dbContext.ComplianceNotificationMassage.Where(s => rolesName.Contains(s.Role)).ToListAsync();
        return ResponseResult<List<ComplianceNotificationMessageDto>>.Success(notifications.Select(s => new ComplianceNotificationMessageDto()
        {
            Id = s.Id,
            ActionUrl = s.ActionUrl,
            MessageBody = currentLanguageService.Language == LanguageEnum.En ? s.MessageBodyEn : s.MessageBodyAR,
            MessageTitle = currentLanguageService.Language == LanguageEnum.En ? s.MessageTitleEn : s.MessageTitleAR,
            MessageType = s.MessageType
        }).ToList());
    }

    public async Task CreateComplianceRequest()
    {

        var record = await dbContext.ComplianceRequest
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

        var record = await dbContext.ComplianceRequest
               .Include(s => s.ComplianceApprovals)
               .OrderByDescending(s => s.CreatedOn).FirstOrDefaultAsync();

        if (record != null && DateTime.Now.Date.Subtract(record.CreatedOn.Date).Days > 365) return;

        if (record != null)
        {
            if (record.StatusId == (int)ComplianceStatusEnum.New)
            {
                record.RemainingDays = record.AssignedOn.Value.Date.AddDays(60).Subtract(DateTime.Now.Date).Days;
                record.PassedDays = DateTime.Now.Date.Subtract(record.AssignedOn.Value.Date).Days;
            }

            if (record.StatusId == (int)ComplianceStatusEnum.ApprovalOfTheComplianceManager)
            {
                var approvalRecord = record.ComplianceApprovals.FirstOrDefault(a => a.Role == RoleEnum.ComplianceManager);
                if (approvalRecord != null && approvalRecord.IsApproved == true)
                {
                    record.RemainingDays = approvalRecord.ModifiedOn.Date.AddDays(7).Subtract(DateTime.Now.Date).Days;
                    record.PassedDays = DateTime.Now.Date.Subtract(approvalRecord.ModifiedOn.Date).Days;
                }
            }

            if (record.StatusId == (int)ComplianceStatusEnum.ReturnPlanOfComplianceManager)
            {
                var approvalRecord = record.ComplianceApprovals.FirstOrDefault(a => a.Role == RoleEnum.ComplianceManager);
                if (approvalRecord != null && approvalRecord.IsApproved == false)
                {
                    record.RemainingDays = approvalRecord.ModifiedOn.Date.AddDays(approvalRecord.DaysForFinish.Value).Subtract(DateTime.Now.Date).Days;
                    record.PassedDays = DateTime.Now.Date.Subtract(approvalRecord.ModifiedOn.Date).Days;
                }
            }

            if (record.StatusId == (int)ComplianceStatusEnum.ReturnPlanOfPerformanceMonitoringManager)
            {
                var approvalRecord = record.ComplianceApprovals.FirstOrDefault(a => a.Role == RoleEnum.PerformanceMonitoringManager);
                if (approvalRecord != null && approvalRecord.IsApproved == false)
                {
                    record.RemainingDays = approvalRecord.ModifiedOn.Date.AddDays(approvalRecord.DaysForFinish.Value).Subtract(DateTime.Now.Date).Days;
                    record.PassedDays = DateTime.Now.Date.Subtract(approvalRecord.ModifiedOn.Date).Days;
                }
            }

            if (record.StatusId == (int)ComplianceStatusEnum.PendingReviewOfComplianceManager)
            {
                var approvalRecord = record.ComplianceApprovals.FirstOrDefault(a => a.Role == RoleEnum.ComplianceManager);
                if (approvalRecord != null && approvalRecord.IsApproved == null)
                {
                    record.RemainingDays = approvalRecord.CreatedOn.Date.AddDays(7).Subtract(DateTime.Now.Date).Days;
                    record.PassedDays = DateTime.Now.Date.Subtract(approvalRecord.CreatedOn.Date).Days;
                }
            }

            if (record.StatusId == (int)ComplianceStatusEnum.PendingReviewOfPerformanceMonitoringManager)
            {
                var approvalRecord = record.ComplianceApprovals.FirstOrDefault(a => a.Role == RoleEnum.PerformanceMonitoringManager);
                if (approvalRecord != null && approvalRecord.IsApproved == null)
                {
                    record.RemainingDays = approvalRecord.CreatedOn.Date.AddDays(7).Subtract(DateTime.Now.Date).Days;
                    record.PassedDays = DateTime.Now.Date.Subtract(approvalRecord.CreatedOn.Date).Days;
                }
            }



            await dbContext.SaveChangesAsync();
        }
    }

    public async Task<ResponseResult<KeyValuePair<List<string>, bool>>> AssignComplianceSpecialist(AssignComplianceSpecialistModel model)
    {
        bool isUpdate = false;
        List<string> notifiedUser = new List<string>();
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
        return ResponseResult<KeyValuePair<List<string>, bool>>.Success(new KeyValuePair<List<string>, bool>(notifiedUser, isUpdate));

    }

    public async Task<ResponseResult<ComplianceRequestDto>> GetComplianceRequest(bool isEmail = false)
    {

        var record = await dbContext.ComplianceRequest
               .Include(s => s.ComplianceSpecialists)
               .Include(s => s.ComplianceDetails)
               .Include(s => s.Status)
               .OrderByDescending(s => s.CreatedOn).FirstOrDefaultAsync();


        if (record == null) throw new NotFoundException("ComplianceRequest", "Not found");

        if (DateTime.Now.Subtract(record.CreatedOn).Days > 365) throw new NotFoundException("ComplianceRequest", "Yearly Compliance Request not found \r\n لم يتم العثور على طلب الامتثال السنوي");


        if (isEmail || (currentUserService != null && (record.ComplianceSpecialists.Any(s => s.SpecialistUserName == currentUserService.User.UserName) || currentUserService.User.Role.Contains(RoleEnum.PerformanceMonitoringManager) || currentUserService.User.Role.Contains(RoleEnum.ComplianceManager))))
        {
            var categoryLookupValue = await dbContext.LookupValue.ToListAsync();
            ComplianceRequestDto complianceRequestDto = new ComplianceRequestDto()
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
                CompliancePlans = record.ComplianceDetails?.Where(s => s.IsDeleted == false).OrderByDescending(s => s.Seq).Select(s => new CompliancePlanDto()
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

                detailsAr.Add(new KeyValuePair<string, string>("Activity", $"النشاط الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.ActivityId)?.ValueAr} , النشاط السابق : - "));
                detailsEn.Add(new KeyValuePair<string, string>("Activity", $"Current Activity: {categoryLookupValue.FirstOrDefault(a => a.Id == model.ActivityId)?.ValueEn} , Old Activity : -"));


                detailsAr.Add(new KeyValuePair<string, string>("LicensedEntity", $"المرخص له الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.LicensedEntityId)?.ValueAr} , المخص له السابق : -"));
                detailsEn.Add(new KeyValuePair<string, string>("LicensedEntity", $"Current Licensed Entity: {categoryLookupValue.FirstOrDefault(a => a.Id == model.LicensedEntityId)?.ValueEn} , Old Licensed Entity : -"));

                detailsAr.Add(new KeyValuePair<string, string>("PlantName", $"اسم المحطة الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.PlantNameId)?.ValueAr} , اسم المحطة السابق : -"));
                detailsEn.Add(new KeyValuePair<string, string>("PlantName", $"Current Plant Name: {categoryLookupValue.FirstOrDefault(a => a.Id == model.PlantNameId)?.ValueEn} , Old Plant Name : -"));


                detailsAr.Add(new KeyValuePair<string, string>("Location", $"الموقع الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.LocationId)?.ValueAr} , الموقع السابق : -"));
                detailsEn.Add(new KeyValuePair<string, string>("Location", $"Current Location: {categoryLookupValue.FirstOrDefault(a => a.Id == model.LocationId)?.ValueEn} , Old Location : -"));

                detailsAr.Add(new KeyValuePair<string, string>("QuarterPlannedForVisit", $"الربع المخطط له الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.QuarterPlannedForVisitId)?.ValueAr} , الربع المخطط له السابق : -"));
                detailsEn.Add(new KeyValuePair<string, string>("QuarterPlannedForVisit", $"Current Quarter Planned For Visit: {categoryLookupValue.FirstOrDefault(a => a.Id == model.QuarterPlannedForVisitId)?.ValueEn} , Old Quarter Planned For Visit : -"));

                detailsAr.Add(new KeyValuePair<string, string>("VisitType", $"نوع الزيارة الحالي: {categoryLookupValue.FirstOrDefault(a => a.Id == model.VisitTypeId)?.ValueAr} , نوع الزيارة السابق : -"));
                detailsEn.Add(new KeyValuePair<string, string>("VisitType", $"Current Visit Type: {categoryLookupValue.FirstOrDefault(a => a.Id == model.VisitTypeId)?.ValueEn} , Old Visit Type : -"));


            }

            complianceDetailsRecord.VisitTypeId = model.VisitTypeId;
            complianceDetailsRecord.LocationId = model.LocationId;
            complianceDetailsRecord.LicensedEntityId = model.LicensedEntityId;
            complianceDetailsRecord.PlantNameId = model.PlantNameId;
            complianceDetailsRecord.QuarterPlannedForVisitId = model.QuarterPlannedForVisitId;
            complianceDetailsRecord.ActivityId = model.ActivityId;


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
            if (complianceSpecialist.Any(s => s.SpecialistUserId == currentUserService.User.UserId))
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

                detailsAr.Add(new KeyValuePair<string, string>("QuarterPlannedForVisit", $"الربع المخطط له : {categoryLookupValue.FirstOrDefault(a => a.Id == compliancePlan.QuarterPlannedForVisitId)?.ValueAr} , الربع المخطط له السابق : -"));
                detailsEn.Add(new KeyValuePair<string, string>("QuarterPlannedForVisit", $" Quarter Planned For Visit: {categoryLookupValue.FirstOrDefault(a => a.Id == compliancePlan.QuarterPlannedForVisitId)?.ValueEn} , Old Quarter Planned For Visit : -"));

                detailsAr.Add(new KeyValuePair<string, string>("VisitType", $"نوع الزيارة : {categoryLookupValue.FirstOrDefault(a => a.Id == compliancePlan.VisitTypeId)?.ValueAr} , نوع الزيارة السابق : -"));
                detailsEn.Add(new KeyValuePair<string, string>("VisitType", $" Visit Type: {categoryLookupValue.FirstOrDefault(a => a.Id == compliancePlan.VisitTypeId)?.ValueEn} , Old Visit Type : -"));



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
            }
            return ResponseResult<bool>.Success(true);
        }
        throw new ValidationException(new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Unauthoried User", "Unauthoried User") });
    }

    public async Task<ResponseResult<List<ComplianceActivityDto>>> GetComplianceActivities(Guid requestId)
    {
        var complianceActivities = await dbContext.ComplianceRequestActivity.Where(s => s.ComplianceRequestId == requestId).ToListAsync();
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

        if (record != null && (record.ComplianceSpecialists.Any(s => s.SpecialistUserId == currentUserService.User.UserId) && (record.StatusId == (long)ComplianceStatusEnum.New || record.StatusId == (long)ComplianceStatusEnum.ReturnPlanOfPerformanceMonitoringManager || record.StatusId == (long)ComplianceStatusEnum.ReturnPlanOfComplianceManager)))
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
                role = RoleEnum.PerformanceMonitoringManager;


                detailsAr.Add(new KeyValuePair<string, string>("Status", $"تم ارسال الخطة للمراجعة من قبل مدير عام مراقبة الاداء"));
                detailsEn.Add(new KeyValuePair<string, string>("Status", $"The Plan Send for review by Performance Monitoring Manager"));

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
    private QuarterPlannedEnum GetMonthlyVisit()
    {
        if (DateTime.Now.Month == 1 || DateTime.Now.AddDays(10).Month == 1)
            return QuarterPlannedEnum.FirstQuarterJanuary;
        else if (DateTime.Now.Month == 2 || DateTime.Now.AddDays(10).Month == 2)
            return QuarterPlannedEnum.FirstQuarterFebruary;
        else if (DateTime.Now.Month == 3 || DateTime.Now.AddDays(10).Month == 3)
            return QuarterPlannedEnum.FirstQuarterMarch;
        else if (DateTime.Now.Month == 4 || DateTime.Now.AddDays(10).Month == 4)
            return QuarterPlannedEnum.SecondQuarterApril;
        else if (DateTime.Now.Month == 5 || DateTime.Now.AddDays(10).Month == 5)
            return QuarterPlannedEnum.SecondQuarterMay;
        else if (DateTime.Now.Month == 6 || DateTime.Now.AddDays(10).Month == 6)
            return QuarterPlannedEnum.SecondQuarterJune;
        else if (DateTime.Now.Month == 7 || DateTime.Now.AddDays(10).Month == 7)
            return QuarterPlannedEnum.ThirdQuarterJuly;
        else if (DateTime.Now.Month == 8 || DateTime.Now.AddDays(10).Month == 8)
            return QuarterPlannedEnum.ThirdQuarterAugust;
        else if (DateTime.Now.Month == 9 || DateTime.Now.AddDays(10).Month == 9)
            return QuarterPlannedEnum.ThirdQuarterSeptember;
        else if (DateTime.Now.Month == 10 || DateTime.Now.AddDays(10).Month == 10)
            return QuarterPlannedEnum.ForthQuarterOctober;
        else if (DateTime.Now.Month == 11 || DateTime.Now.AddDays(10).Month == 11)
            return QuarterPlannedEnum.ForthQuarterNovember;
        else if (DateTime.Now.Month == 12 || DateTime.Now.AddDays(10).Month == 12)
            return QuarterPlannedEnum.ForthQuarterDecember;
        else
            return QuarterPlannedEnum.FirstQuarterJanuary;
    }
    public async Task<List<CompliancePlanDto>> GetQuarterVisits()
    {
        List<CompliancePlanDto> results = new List<CompliancePlanDto>();
        var currentMonthlyQuarter = GetMonthlyVisit();
        var complianceVisits = dbContext.ComplianceDetails?.Where(s => s.IsDeleted == false && s.QuarterPlannedForVisitId == (long)currentMonthlyQuarter).OrderByDescending(s => s.Seq).AsQueryable();
        if (complianceVisits != null && complianceVisits.Count() > 0)
        {
            var categoryLookupValue = await dbContext.LookupValue.ToListAsync();
            foreach (var visit in complianceVisits)
            {
                CompliancePlanDto model = new CompliancePlanDto()
                {
                    Id = visit.Id,
                    Seq = visit.Seq,
                    ActivityId = visit.ActivityId,
                    ComplianceRequestId = visit.ComplianceRequestId,

                    ActivityName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == visit.ActivityId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == visit.ActivityId)?.ValueAr,

                    LicensedEntityId = visit.LicensedEntityId,
                    LicensedEntityName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == visit.LicensedEntityId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == visit.LicensedEntityId)?.ValueAr,


                    LocationId = visit.LocationId,
                    LocationName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == visit.LocationId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == visit.LocationId)?.ValueAr,

                    PlantNameId = visit.PlantNameId,
                    PlantName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == visit.PlantNameId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == visit.PlantNameId)?.ValueAr,

                    QuarterPlannedForVisitId = visit.QuarterPlannedForVisitId,
                    QuarterPlannedForVisitName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == visit.QuarterPlannedForVisitId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == visit.QuarterPlannedForVisitId)?.ValueAr,

                    VisitTypeId = visit.VisitTypeId,
                    VisitTypeName = currentLanguageService.Language == LanguageEnum.En ? categoryLookupValue.FirstOrDefault(a => a.Id == visit.VisitTypeId)?.ValueEn : categoryLookupValue.FirstOrDefault(a => a.Id == visit.VisitTypeId)?.ValueAr,

                    ModifiedOn = visit.ModifiedOn,
                    CreatedOn = visit.CreatedOn,

                    DesignedCapacity = visit.DesignedCapacity,
                    VisitDate = visit.VisitDate,
                    VisitReferenceNumber = visit.VisitReferenceNumber,
                };

                results.Add(model);
            }
        }

        return results;
    }
    public async Task<ResponseResult<bool>> SaveComplianceVisit(ComplianceVisitModel model, long? VisitStatusId = null)
    {        
        ComplianceDetails complianceDetailsRecord = await dbContext.ComplianceDetails.FirstOrDefaultAsync(s => s.Id == model.Id);
        var categoryLookupValue = await dbContext.LookupValue.ToListAsync();
        
        var currentQuarterNameEn = categoryLookupValue.FirstOrDefault(a => a.Id == model.QuarterPlannedForVisitId)?.ValueEn;
        var modelVisitMonthEn = model.VisitDate.ToString("MMMM", new CultureInfo("en"));

        if (!currentQuarterNameEn.Contains(modelVisitMonthEn))
            return ResponseResult<bool>.Failure(new List<string> { "Visit Date is outside its designated Quarter." }, false);

        if (complianceDetailsRecord != null && currentUserService.User.Role.Any(role=> role.Equals(RoleEnum.ComplianceSpecialist) || role.Equals(RoleEnum.ComplianceManager))) 
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

            bool isNewVisit = complianceDetailsRecord.VisitDate == null;

            complianceDetailsRecord.VisitTypeId = model.VisitTypeId;
            complianceDetailsRecord.LocationId = model.LocationId;
            complianceDetailsRecord.LicensedEntityId = model.LicensedEntityId;
            complianceDetailsRecord.PlantNameId = model.PlantNameId;
            complianceDetailsRecord.QuarterPlannedForVisitId = model.QuarterPlannedForVisitId;
            complianceDetailsRecord.ActivityId = model.ActivityId;
            complianceDetailsRecord.DesignedCapacity = model.DesignedCapacity;
            complianceDetailsRecord.VisitDate = model.VisitDate;


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
        var visitIds = await dbContext.ComplianceVisitSpecialist.Where(vs => vs.SpecialistUserId.Equals(LoggedInUserId)).Select(vs=> vs.ComplianceDetailsId).Distinct().ToListAsync();

        var visits = await dbContext.ComplianceDetails.Include(c=> c.ComplianceVisitSpecialists)
                            .ThenInclude(c=>c.ComplianceVisitDisclosure)
                        .Where(c => visitIds.Contains(c.Id) && c.VisitStatusId.Equals(visitStatusId)).ToListAsync();
        
        if (visits!=null && visits.Count() > 0) 
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
                            ComplianceVisitDisclosure = s.ComplianceVisitDisclosure !=  null 
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
        var request = await GetComplianceRequest(isEmail: true);

        string currentMonthName = DateTime.Now.ToString("MMMM");

        //get current quarter name excluding month
        //e.g: get "First Quarter" from "First Quarter - January"
        var quarterNameEnForPendingVisits = request.Model?.CompliancePlans?.Where(p => p.QuarterPlannedForVisitNameEn.Contains(currentMonthName)).FirstOrDefault()?.QuarterPlannedForVisitNameEn;
        quarterNameEnForPendingVisits = string.Join(" ", quarterNameEnForPendingVisits.Split(' ', StringSplitOptions.RemoveEmptyEntries).Take(2));

        //get scheduled visits for current quarter
        List<CompliancePlanDto>? scheduledVisits = request.Model?.CompliancePlans?.Where(p =>
            p.QuarterPlannedForVisitNameEn.StartsWith(quarterNameEnForPendingVisits)
            && p.VisitStatusId.Equals((long)VisitStatusEnum.New)
            && !String.IsNullOrEmpty(p.VisitReferenceNumber)
        ).ToList();

        return scheduledVisits;
    }


    public async Task<List<CompliancePlanDto>> GetUnscheduledVisitsForCurrentQuarter() 
    {
        var request = await GetComplianceRequest(isEmail: true);

        string currentMonthName = DateTime.Now.ToString("MMMM");

        //get current quarter name excluding month
        //e.g: get "First Quarter" from "First Quarter - January"
        var quarterNameEnForPendingVisits = request.Model?.CompliancePlans?.Where(p => p.QuarterPlannedForVisitNameEn.Contains(currentMonthName)).FirstOrDefault()?.QuarterPlannedForVisitNameEn;
        quarterNameEnForPendingVisits = string.Join(" ", quarterNameEnForPendingVisits.Split(' ', StringSplitOptions.RemoveEmptyEntries).Take(2));

        //get unscheduled visits for current quarter
        List<CompliancePlanDto>? unscheduledVisits = request.Model?.CompliancePlans?.Where(p =>
            p.QuarterPlannedForVisitNameEn.StartsWith(quarterNameEnForPendingVisits)
            && p.VisitStatusId == null
            && String.IsNullOrEmpty(p.VisitReferenceNumber)
        ).ToList();

        return unscheduledVisits;
    }

    public async Task<ResponseResult<CompliancePlanDto>> GetComplianceVisitDetail (Guid id) 
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


                UnscheduledVisitsForCurrentQuarter = GetUnscheduledVisitsForCurrentQuarter().Result.Count(),
                
                ComplianceVisitSpecialists = complianceVisit.ComplianceVisitSpecialists?.Where(s => s.IsDeleted == false)
                    .Select(s => new ComplianceVisitSpecialistModel() 
                    {
                        Id = s.Id,
                        ComplianceDetailsId = s.ComplianceDetailsId ,
                        SpecialistUserId = s.SpecialistUserId ,
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
        var complianceVisitSpecialists = dbContext.ComplianceVisitSpecialist?.Where(s => s.ComplianceDetailsId == complianceDetailId).ToListAsync();

        if (complianceVisitSpecialists != null && complianceVisitSpecialists.Result.Count() > 0)
        {
            List<ComplianceVisitSpecialistModel> result = new List<ComplianceVisitSpecialistModel>();
            foreach (var specialist in complianceVisitSpecialists.Result) 
            {
                ComplianceVisitSpecialistModel specialistModel = new ComplianceVisitSpecialistModel()
                {
                    Id = specialist.Id,
                    ComplianceDetailsId = specialist.ComplianceDetailsId,
                    SpecialistUserId = specialist.SpecialistUserId,
                    SpecialistUserName = specialist.SpecialistUserName,
                    SpecialistUserEmail = specialist.SpecialistUserEmail,
                };

                result.Add(specialistModel);
            }
            return ResponseResult<List<ComplianceVisitSpecialistModel>>.Success(result);
        }
        return null;
    }

    public async Task<ResponseResult<List<ComplianceSpecialistDto>>> GetComplianceRequestSpecialists()
    {
        var record = await dbContext.ComplianceRequest
              .Include(s => s.ComplianceSpecialists)
              .OrderByDescending(s => s.CreatedOn).FirstOrDefaultAsync();

        if (record != null && record.ComplianceSpecialists?.Count() > 0)
        {
            List<ComplianceSpecialistDto> result = new List<ComplianceSpecialistDto>();
            foreach (var specialist in record.ComplianceSpecialists)
            {
                ComplianceSpecialistDto specialistModel = new ComplianceSpecialistDto()
                {
                    SpecialistUserId = specialist.SpecialistUserId,
                    SpecialistUserName = specialist.SpecialistUserName,
                    SpecialistUserEmail = specialist.SpecialistUserEmail,
                };

                result.Add(specialistModel);
            }
            return ResponseResult<List<ComplianceSpecialistDto>>.Success(result);
        }
        return null;
    }

    private async Task<List<string>> CheckSpecialistsAvailablity(AssignComplianceVisitSpecialistModel model, DateTime? ModelComplianceVisitDate)
    {
        List<string> unavailableUserErrors = new List<string>();
        foreach (var item in model.AssignedUserId)
        {
            var specialistOtherAssignments = await dbContext.ComplianceVisitSpecialist.Where(s => s.SpecialistUserId == item && s.ComplianceDetailsId != model.ComplianceDetailsId).ToListAsync();

            if (specialistOtherAssignments != null && specialistOtherAssignments.Count() > 0)
            {
                foreach (var assignment in specialistOtherAssignments)
                {
                    var specialistOtherVisit = await dbContext.ComplianceDetails.FirstOrDefaultAsync(s => s.Id == assignment.ComplianceDetailsId);

                    if (specialistOtherVisit.VisitDate.Value.Date.Equals(ModelComplianceVisitDate.Value.Date))
                    {
                        unavailableUserErrors.Add($"UserId: {item} is unavailable and cannot be assigned to this visit.");
                    }
                }
            }
        }
        return unavailableUserErrors;
    }
    public async Task<ResponseResult<KeyValuePair<List<string>, bool>>> AssignComplianceVisitSpecialist(AssignComplianceVisitSpecialistModel model)
    {
        bool isUpdate = false;
        List<string> notifiedUser = new List<string>();
        var complianceDetail = await dbContext.ComplianceDetails.Include(s => s.ComplianceVisitSpecialists).FirstOrDefaultAsync(s => s.Id == model.ComplianceDetailsId);
        if (complianceDetail != null)
        {
            List<string> unavailableUserErrors = await CheckSpecialistsAvailablity(model, complianceDetail.VisitDate);
            if (unavailableUserErrors != null && unavailableUserErrors.Count() > 0)
            {
                return ResponseResult<KeyValuePair<List<string>, bool>>.Failure(unavailableUserErrors, new KeyValuePair<List<string>, bool>());
            }

            List<KeyValuePair<string, string>> detailsAr = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> detailsEn = new List<KeyValuePair<string, string>>();

            UserRepository userRepository = new UserRepository();
            var users = await userRepository.GetUsersByIds(model.AssignedUserId);

            if (complianceDetail.ComplianceVisitSpecialists != null && complianceDetail.ComplianceVisitSpecialists.Count() > 0)
            {
                var ids = complianceDetail.ComplianceVisitSpecialists.Select(s => s.SpecialistUserId).ToList();
                notifiedUser = model.AssignedUserId.Except(ids).ToList();
                dbContext.ComplianceVisitSpecialist.RemoveRange(complianceDetail.ComplianceVisitSpecialists);
                detailsAr.Add(new KeyValuePair<string, string>("Seq", $"تم تغيير المتخصصين في زيارة الامتثال"));
                detailsEn.Add(new KeyValuePair<string, string>("Seq", $"Compliance Visit Specialists have been changed"));
                isUpdate = true;
            }

            else
            {
                detailsAr.Add(new KeyValuePair<string, string>("Seq", $"لقد تم تعيين قائمة المتخصصين في الزيارة."));
                detailsEn.Add(new KeyValuePair<string, string>("Seq", $"Compliance Visit Specialists have been Assigned"));

                notifiedUser = model.AssignedUserId;
            }


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
        return ResponseResult<KeyValuePair<List<string>, bool>>.Success(new KeyValuePair<List<string>, bool>(notifiedUser, isUpdate));

    }



    #endregion
}
