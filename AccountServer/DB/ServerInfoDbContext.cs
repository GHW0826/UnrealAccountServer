using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace AccountServer.DB;

public class ServerInfoDbContext : DbContext
{
    public DbSet<ServerInfoDb> ServerInfos { get; set; }

    public ServerInfoDbContext(DbContextOptions<ServerInfoDbContext> options)
    : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ServerInfoDb>()
            .HasIndex(a => a.ServerId)
            .IsUnique();
    }
}