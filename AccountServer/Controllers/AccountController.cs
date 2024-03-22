using AccountServer.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AccountServer.Controllers;


[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    AccountDbContext _accountContext;
    ServerInfoDbContext _serverInfoContext;

    public AccountController(AccountDbContext acountContext, ServerInfoDbContext serverInfoContext)
    {
        _accountContext = acountContext;
        _serverInfoContext = serverInfoContext;
    }

    [HttpPost]
    [Route("create")]
    public CreateAccountPacketRes CreateAccount([FromBody] CreateAccountPacketReq req)
    {
        CreateAccountPacketRes res = new();
        AccountDb? account = _accountContext.Accounts
                                       .AsNoTracking()
                                       .Where(a => a.AccountName == req.AccountName)
                                       .FirstOrDefault();

        if (account == null)
        {
            _accountContext.Accounts.Add(new AccountDb()
            {
                AccountName = req.AccountName,
                Password = req.Password
            });
            bool success = _accountContext.SaveChangesEx();
            res.CreateOk = success;
        }
        else
        {
            res.CreateOk = false;
        }

        return res;
    }

    [HttpPost]
    [Route("login")]
    public LoginAccountPacketRes Login([FromBody] LoginAccountPacketReq req)
    {
        LoginAccountPacketRes res = new();
        AccountDb? account = _accountContext.Accounts
                               .AsNoTracking()
                               .Where(a => a.AccountName == req.AccountName && a.Password == req.Password)
                               .FirstOrDefault();

        if (account == null)
        {
            res.LoginOk = false;
        }
        else
        {
            res.LoginOk = true;

            res.ServerList = new List<ServerInfo>();
            foreach (ServerInfoDb serverDb in _serverInfoContext.ServerInfos)
            {
                res.ServerList.Add(new ServerInfo()
                {
                    Name = serverDb.Name,
                    IpAddress = serverDb.IpAddress,
                    Port = serverDb.Port,
                });
            }
        }

        return res;
    }
}
