using IsNewsPropaganda.Models;
using Microsoft.EntityFrameworkCore;

namespace IsNewsPropaganda.DataBase;

public class IsNewsPropagandaDbContext : DbContext
{
    public DbSet<Article> Articles { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Source> Sources { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("workstation id=IsNewsPropaganda.mssql.somee.com;packet size=4096;user id=kamyczek;pwd=:m:Uy)e6]_aN+)SMuq6|;data source=IsNewsPropaganda.mssql.somee.com;persist security info=False;initial catalog=IsNewsPropaganda;TrustServerCertificate=True");
    }
}