using ComplianceAndPeformanceSystem.Contract.Common.Exceptions;
using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.IRepositories;
using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComplianceAndPeformanceSystem.DAL.Repositories;

public class AttachmentRepository(IComplianceAndPeformanceDbContext dbContext) : IAttachmentRepository
{
    public async Task AddAttachment(Attachment attachment)
    {
        await dbContext.Attachments.AddAsync(attachment);
    }

    public async Task DeleteAttachment(Guid attachmentId)
    {
        var record = await dbContext.Attachments.FirstOrDefaultAsync(x => x.Id == attachmentId);
        if (record == null)
            throw new NotFoundException("Attachment", "id");

        record.IsDeleted = true;
    }

    public async Task<AttachmentDto>? GetAttachmentById(Guid attachmentId)
    {
        var record = await dbContext.Attachments.FirstOrDefaultAsync(s => s.Id == attachmentId);
        if (record == null)
            throw new NotFoundException("Attachment", "id");
        return new AttachmentDto()
        {
            AttachmentGuid = record.AttachmentGuid,
            AttachmentName = record.AttachmentName,
            AttachmentId = record.Id,
            EntityId = record.EntityId,
            EntityName = record.EntityName,
        };
    }


    public async Task<List<AttachmentDto>>? GetAttachmentByEntityId(Guid entityId)
    {
        var records = await dbContext.Attachments.Where(s => s.EntityId == entityId && s.IsDeleted == false).ToListAsync();
        if (records == null)
            throw new NotFoundException("EntityAttachment", "id");


        return records.Select(s => new AttachmentDto()
        {
            AttachmentType = (AttachmentTypeEnum)s.AttachmentTypeId,
            AttachmentGuid = s.AttachmentGuid,
            AttachmentName = s.AttachmentName,
            AttachmentId = s.Id,
            EntityId = s.EntityId,
            EntityName = s.EntityName,
        }).ToList();

    }

}
