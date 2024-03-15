using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace AccountServer.DB;

public class AccountDbContext : DbContext
{
    public DbSet<AccountDb> Accounts { get; set; }

    public AccountDbContext(DbContextOptions<AccountDbContext> options)
    : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<AccountDb>()
            .HasIndex(a => a.AccountName)
            .IsUnique();
    }
}