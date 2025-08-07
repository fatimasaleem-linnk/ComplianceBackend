using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Core.Entities;

namespace ComplianceAndPeformanceSystem.Contract.IRepositories;

public interface IAttachmentRepository
{
    Task AddAttachment(Attachment attachment);
    Task DeleteAttachment(Guid attachmentId);
    Task<AttachmentDto>? GetAttachmentById(Guid attachmentId);
    Task<List<AttachmentDto>>? GetAttachmentByEntityId(Guid entityId);

}
