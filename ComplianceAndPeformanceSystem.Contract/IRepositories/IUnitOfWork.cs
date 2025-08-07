namespace ComplianceAndPeformanceSystem.Contract.IRepositories;

public interface IUnitOfWork
{
    ILookupRepository LookupRepository { get; }
    IComplianceRequestRepository ComplianceRequestRepository { get; }
    IAttachmentRepository AttachmentRepository { get; }
    IUserRepository UserRepository { get; }
    ITemplateRepository TemplateRepository { get; }
    Task CommitAsync();
}
