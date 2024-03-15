using AccountServer.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountServer.Controllers;


[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    AccountDbContext _accountContext;

    public AccountController(AccountDbContext acountContext)
    {
        _accountContext = acountContext;
    }


    [HttpPost]
    [Route("create")]
    public CreateAccountPacketRes CreateAccount([FromBody] CreateAccountPacketReq req)
    {
        CreateAccountPacketRes res = new();
        return res;
    }
}
