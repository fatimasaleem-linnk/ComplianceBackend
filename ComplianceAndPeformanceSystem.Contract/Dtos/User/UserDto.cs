namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class UserDto
{
    public List<string> Roles { get; set; }
    public string Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string? MobileNumber { get; set; }
}
