using ComplianceAndPeformanceSystem.Contract.IRepositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ComplianceAndPeformanceSystem.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
[Authorize]
public class AccountController : ControllerBase
{
    private readonly IUserRepository _complianceRequestService;
    public AccountController(IUserRepository complianceRequestService)
    {
        _complianceRequestService = complianceRequestService;
    }
    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> GetToken(string role)
    {
        string jwtKey = "a8f5f167f44f4964e6c998dee827110c64d03eac6767687cba9b87f26a5f2790";
        var issuer = "https://app.swcc.gov.sa/ParkingPermit";

        var secKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
        var credentials = new SigningCredentials(secKey, SecurityAlgorithms.HmacSha256);


        var userData = await _complianceRequestService.GetUsers(new List<string>() { role });
        var user = userData.Model.First();

        var permClaims = new List<Claim>();
        permClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
        permClaims.Add(new Claim("UserName", !string.IsNullOrWhiteSpace(user.UserName) ? user.UserName : ""));
        permClaims.Add(new Claim("UserEmail", !string.IsNullOrWhiteSpace(user.Email) ? user.Email : ""));
        permClaims.Add(new Claim("UserId", user.Id));
        permClaims.Add(new Claim("Roles", string.Join(',', user.Roles)));



        //Create Security Token object by giving required parameters
        var authToken = new JwtSecurityToken(issuer, //Issure
                        issuer,  //Audience
                        permClaims,
                        expires: DateTime.Now.AddDays(1),
                        signingCredentials: credentials);
        var jwt_token = new JwtSecurityTokenHandler().WriteToken(authToken);
        return Ok(jwt_token);


    }

}
