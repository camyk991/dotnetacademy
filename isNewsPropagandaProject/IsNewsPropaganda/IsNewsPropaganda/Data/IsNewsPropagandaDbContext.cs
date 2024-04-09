using IsNewsPropaganda.Models;
using Microsoft.EntityFrameworkCore;

namespace IsNewsPropaganda.Data;

public class IsNewsPropagandaDbContext : DbContext
{
    public DbSet<Article> Articles { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Source> Sources { get; set; }
    public DbSet<User> Users { get; set; }

    public IsNewsPropagandaDbContext(DbContextOptions<IsNewsPropagandaDbContext> options) : base(options)
    {
            
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }
}