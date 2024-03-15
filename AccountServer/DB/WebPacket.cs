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
    public int AccountId { get; set; }
    public int Token { get; set; }
    public List<ServerInfo> ServerList { get; set; } = new();
}

public class ServerInfo
{
    public string Name { get; set; } = string.Empty;
    public string IpAddress { get; set; } = string.Empty;
    public int Port { get; set; }
    public int BusyScore { get; set; }
}
