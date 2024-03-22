namespace AccountServer.DB;

public class CreateAccountPacketReq
{
    public string AccountName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}

public class CreateAccountPacketRes
{
    public bool CreateOk { get; set; }
}

public class LoginAccountPacketReq
{
    public string AccountName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}

public class LoginAccountPacketRes
{
    public bool LoginOk { get; set; }
    public List<ServerInfo> ServerList { get; set; } = new();
}

public class ServerInfo
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string IpAddress { get; set; } = string.Empty;
    public int Port { get; set; }
    public int PlayerNum { get; set; }
}

public class GetServerListReq
{
}

public class GetServerListRes
{
    public List<ServerInfo>? ServerList { get; set; } = new();
}
