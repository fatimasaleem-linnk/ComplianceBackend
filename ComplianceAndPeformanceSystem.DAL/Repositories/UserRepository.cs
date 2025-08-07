using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.IRepositories;

namespace ComplianceAndPeformanceSystem.DAL.Repositories;

public class UserRepository/*(ISWAESContext sWAESContext)*/ : IUserRepository
{
    public async Task<ResponseResult<List<UserDto>>> GetUsers(List<string> rolesName)
    {
        List<UserDto> users = new List<UserDto>();
        if (rolesName.Contains(RoleEnum.ComplianceSpecialist) || rolesName.Count == 0 || rolesName == null)
        {

            users.Add(new UserDto()
            {
                Email = "MAhmed1ebb94@swa.gov.sa",
                Roles = new List<string>() { RoleEnum.ComplianceSpecialist },
                Id = 4.ToString(),
                UserName = "Mohammed Maher",
                MobileNumber = "0562572162"
            });

            users.Add(new UserDto()
            {
                Email = "fsaleem@swcc.gov.sa",
                Id = 1.ToString(),
                Roles = new List<string>() { RoleEnum.ComplianceSpecialist },
                UserName = "Fatima Saleem",
                MobileNumber = "0562572162"
            });

            users.Add(new UserDto()
            {
                //Email = "KAlasmary@swa.gov.sa",
                Email = "efarag2@swa.gov.sa",
                Id = 2.ToString(),
                Roles = new List<string>() { RoleEnum.ComplianceSpecialist },
                UserName = "Khaled Alasmary",
                MobileNumber = "0562572162"
            });

            users.Add(new UserDto()
            {
                Email = "MAbkar@swa.gov.sa",
                Id = 3.ToString(),
                Roles = new List<string>() { RoleEnum.ComplianceSpecialist },
                UserName = "Mohammed kamal Abkar",
                MobileNumber = "0569065085"
            });

            users.Add(new UserDto()
            {
                Roles = new List<string>() { RoleEnum.ComplianceManager },
                //Email = "SKhan7@swa.gov.sa",
                Email = "Q3@swa.gov.sa",
                Id = 5.ToString(),
                UserName = "Saeed Khan",
                MobileNumber = "0562572162"
            });

            

        }
        if (rolesName.Contains(RoleEnum.PerformanceMonitoringManager) || rolesName.Count == 0 || rolesName == null)
        {
            users.Add(new UserDto()
            {
                //Email = "OMohammed@swa.gov.sa",
                Email = "u112233@swa.gov.sa",
                Roles = new List<string>() { RoleEnum.PerformanceMonitoringManager },
                Id = 6.ToString(),
                UserName = "Osama Mohammed",
                MobileNumber = "0562572162"
            });
           

        }
        if (rolesName.Contains(RoleEnum.ComplianceManager) || rolesName.Count == 0 || rolesName == null)
        {
            users.Add(new UserDto()
            {
                Email = "fsaleem@swcc.gov.sa",
                Id = 7.ToString(),
                Roles = new List<string>() { RoleEnum.ComplianceManager },
                UserName = "Fatima Saleem",
                MobileNumber = "0562572162"
            });

            users.Add(new UserDto()
            {
                Roles = new List<string>() { RoleEnum.ComplianceManager },
                //Email = "SKhan7@swa.gov.sa",
                Email = "Q3@swa.gov.sa",
                Id = 5.ToString(),
                UserName = "Saeed Khan",
                MobileNumber = "0562572162"
            });
        }
        if (rolesName.Contains(RoleEnum.LicensedEntity) || rolesName.Count == 0 || rolesName == null)
        {

            users.Add(new UserDto()
            {
                Roles = new List<string>() { RoleEnum.LicensedEntity },
                Email = "Mabkar@swa.gov.sa",
                Id = 11.ToString(),
                UserName = "Mohamed Abkar",
                MobileNumber = "0569065085"
            });
        }

        return ResponseResult<List<UserDto>>.Success(users);
    }

    public async Task<ResponseResult<List<UserDto>>> GetUsersByIds(List<string> ids)
    {
        List<UserDto> users = new List<UserDto>();

        users.Add(new UserDto()
        {
            Email = "fsaleem@swcc.gov.sa",
            Id = 1.ToString(),
            Roles = new List<string>() { RoleEnum.ComplianceSpecialist },
            UserName = "Fatima Saleem",
            MobileNumber = "0562572162"
        });
        users.Add(new UserDto()
        {
            //Email = "KAlasmary@swa.gov.sa",
            Email = "efarag2@swa.gov.sa",
            Id = 2.ToString(),
            Roles = new List<string>() { RoleEnum.ComplianceSpecialist },
            UserName = "Khaled Alasmary",
            MobileNumber = "0562572162"
        });

        users.Add(new UserDto()
        {
            Email = "MAbkar@swa.gov.sa",
            Id = 3.ToString(),
            Roles = new List<string>() { RoleEnum.LicensedEntity },
            UserName = "Mohammed kamal Abkar",
            MobileNumber = "0569065085"
        });


        users.Add(new UserDto()
        {
            Email = "MAhmed1ebb94@swa.gov.sa",
            Roles = new List<string>() { RoleEnum.ComplianceSpecialist },
            Id = 4.ToString(),
            UserName = "Mohammed Maher",
            MobileNumber = "0562572162"
        });

        users.Add(new UserDto()
        {
            //Email = "OMohammed@swa.gov.sa",
            Email = "u112233@swa.gov.sa",
            Roles = new List<string>() { RoleEnum.PerformanceMonitoringManager },
            Id = 6.ToString(),
            UserName = "Osama Mohammed",
            MobileNumber = "0562572162"
        });

        users.Add(new UserDto()
        {
            Roles = new List<string>() { RoleEnum.ComplianceManager },
            //Email = "SKhan7@swa.gov.sa",
            Email = "Q3@swa.gov.sa",
            Id = 5.ToString(),
            UserName = "Saeed Khan",
            MobileNumber = "0562572162"
        });

        users.Add(new UserDto()
        {
            Email = "fsaleem@swcc.gov.sa",
            Id = 7.ToString(),
            Roles = new List<string>() { RoleEnum.ComplianceManager },
            UserName = "Fatima Saleem",
            MobileNumber = "0562572162"
        });

        users = users.Where(s => ids.Contains(s.Id)).ToList();

        return ResponseResult<List<UserDto>>.Success(users);
    }
}
