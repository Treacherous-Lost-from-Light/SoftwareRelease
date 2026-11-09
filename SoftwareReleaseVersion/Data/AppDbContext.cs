using Microsoft.EntityFrameworkCore;
using SoftwareReleaseVersion.Models;

namespace SoftwareReleaseVersion.Data
{
    public class AppDbContext : DbContext 
    {
        public DbSet<Release> Releases { get; set; }
        public DbSet<ReleaseHistory> ReleaseHistories { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }
    }
}
