using AccountServer.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountServer.Controllers;


[Route("api/[controller]")]
[ApiController]
public class MatchInfoController : ControllerBase
{
    MatchInfoDbContext _matchInfoContext;

    public MatchInfoController(MatchInfoDbContext matchInfoContext)
    {
        _matchInfoContext = matchInfoContext;
    }


    [HttpGet]
    [Route("ServerList")]
    public GetServerListRes GetServerList([FromBody] CreateAccountPacketReq req)
    {
        GetServerListRes res = new();
        return res;
    }
}
