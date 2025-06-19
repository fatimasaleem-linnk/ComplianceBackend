using ComplianceAndPeformanceSystem.Contract.Helper;
using ComplianceAndPeformanceSystem.Contract.IRepositories;
using ComplianceAndPeformanceSystem.Contract.IServices;

namespace ComplianceAndPeformanceSystem.DAL.Repositories;


public class UnitOfWork(
    IComplianceAndPeformanceDbContext context,
    ISWAESContext eswaContext,
    ICurrentUserService currentUserService,
    ICurrentLanguageService currentLanguageService,
    IBlobService blobService
    ) : IUnitOfWork
{
    private readonly IComplianceAndPeformanceDbContext _context = context;
    private readonly ISWAESContext _eswaContext = eswaContext;
    private ILookupRepository _lookupRepository;
    private IComplianceRequestRepository _complianceRequestRepository;
    private IUserRepository _userRepository;
    private IBlobService _blobService;

    public ILookupRepository LookupRepository
    {
        get
        {
            if (_lookupRepository == null)
                _lookupRepository = new LookupRepository(_context,currentLanguageService);
            return _lookupRepository;

        }
    }


    public IComplianceRequestRepository ComplianceRequestRepository
    {
        get
        {
            if (_complianceRequestRepository == null)
                _complianceRequestRepository = new ComplianceRequestRepository(_context ,currentUserService,currentLanguageService);
            return _complianceRequestRepository;
        }
    }

    public IUserRepository UserRepository
    {
        get
        {
            if (_userRepository == null)
                _userRepository = new UserRepository(/*eswaContext*/);
            return _userRepository;

        }
    }


    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }


}
