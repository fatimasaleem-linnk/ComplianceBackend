namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class ComplianceActivityDto
{
    public DateTime CreatedOn { get; set; }
    public string CreatedByUserName { get; set; }
    public string CreatedByUserEmail { get; set; }
    public string ActionAr { get; set; }
    public string ActionEn { get; set; }
    public List<KeyValuePair<string, string>> DetailsAr { get; set; }
    public List<KeyValuePair<string, string>> DetailsEn { get; set; }
}
