using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace AccountServer.DB;

public class MatchInfoDbContext : DbContext
{
    public DbSet<MatchInfoDb> MatchInfos { get; set; }

    public MatchInfoDbContext(DbContextOptions<MatchInfoDbContext> options)
    : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<MatchInfoDb>();
    }
}