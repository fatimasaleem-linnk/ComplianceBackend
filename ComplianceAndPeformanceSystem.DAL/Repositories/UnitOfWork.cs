using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.Helper;
using ComplianceAndPeformanceSystem.Contract.IRepositories;
using ComplianceAndPeformanceSystem.Contract.IServices;
using Microsoft.AspNetCore.Hosting;

namespace ComplianceAndPeformanceSystem.DAL.Repositories;


public class UnitOfWork(
    IComplianceAndPeformanceDbContext context,
    ISWAESContext eswaContext,
    ICurrentUserService currentUserService,
    ICurrentLanguageService currentLanguageService,
    Func<NotificationTypeEnum, INotificationService> notificationService
    ) : IUnitOfWork
{
    private readonly IComplianceAndPeformanceDbContext _context = context;
    private readonly ISWAESContext _eswaContext = eswaContext;
    private ILookupRepository _lookupRepository;
    private IComplianceRequestRepository _complianceRequestRepository;
    private IAttachmentRepository _attachmentRepository;
    private IUserRepository _userRepository;
    private ITemplateRepository _templateRepository;

    public ILookupRepository LookupRepository
    {
        get
        {
            if (_lookupRepository == null)
                _lookupRepository = new LookupRepository(_context,currentLanguageService);
            return _lookupRepository;

        }
    }

    public IAttachmentRepository AttachmentRepository
    {
        get
        {
            if (_attachmentRepository == null)
                _attachmentRepository = new AttachmentRepository(_context);
            return _attachmentRepository;

        }
    }

    public ITemplateRepository TemplateRepository
    {
        get
        {
            if (_templateRepository == null)
                _templateRepository = new TemplateRepository(_context,currentLanguageService);
            return _templateRepository;

        }
    }

    public IComplianceRequestRepository ComplianceRequestRepository
    {
        get
        {
            if (_complianceRequestRepository == null)
                _complianceRequestRepository = new ComplianceRequestRepository(_context ,currentUserService, currentLanguageService, _userRepository, notificationService);
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
