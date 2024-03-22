using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountServer.DB;


[Table("Account")]
public class AccountDb
{
    [Key]
    public int AccountDbId { get; set; }
    public string AccountName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string GameDbId { get; set; } = string.Empty;
}

[Table("ServerInfo")]
public class ServerInfoDb
{
    [Key]
    public int ServerId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string IpAddress { get; set; } = string.Empty;
    public int Port { get; set; }
    public int PlayerNum { get; set; }
}

[Table("MatchInfo")]
public class MatchInfoDb
{
    [Key]
    public int MatchId { get; set; }
    public int ServerId { get; set; }
}

[Table("MatchDetailInfo")]
public class MatchDetailInfoDb
{
    [Key]
    public int MatchId { get; set; }
    public string GameDbId { get; set; } = string.Empty;
    public int Score { get; set; }
}