using AccountServer.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountServer.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ServerInfoController : ControllerBase
{
    ServerInfoDbContext _serverInfoContext;

    public ServerInfoController(ServerInfoDbContext serverInfoContext)
    {
        _serverInfoContext = serverInfoContext;
    }


    [HttpGet]
    [Route("ServerList")]
    public GetServerListRes GetServerList([FromBody] CreateAccountPacketReq req)
    {
        GetServerListRes res = new();
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
        return res;
    }
}
