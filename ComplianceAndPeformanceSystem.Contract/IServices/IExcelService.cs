
namespace ComplianceAndPeformanceSystem.Contract.IServices;

public interface IExcelService
{
    Task<List<string>> GetData(string path);
    Task<List<string>> GetData(Stream data);
}
