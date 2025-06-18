using Microsoft.EntityFrameworkCore;

namespace ComplianceAndPeformanceSystem.DAL;

public class ComplianceAndPeformanceDbContextFactory : DesignTimeDbContextFactoryBase<ComplianceAndPeformanceDbContext>
{
    protected override ComplianceAndPeformanceDbContext CreateNewInstance(DbContextOptions<ComplianceAndPeformanceDbContext> options)
    {
        return new ComplianceAndPeformanceDbContext(options);
    }
}
