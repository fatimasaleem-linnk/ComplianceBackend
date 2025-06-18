namespace ComplianceAndPeformanceSystem.Contract.IRepositories;

public interface IUnitOfWork
{
    ILookupRepository LookupRepository { get; }
    IComplianceRequestRepository ComplianceRequestRepository { get; }
    IUserRepository UserRepository { get; }
    Task CommitAsync();
}
