﻿using System.ComponentModel.DataAnnotations.Schema;

namespace AccountServer.DB;


[Table("Account")]
public class AccountDb
{
    public int AccountDbId { get; set; }
    public string AccountName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}