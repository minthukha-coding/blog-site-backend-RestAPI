using blog_site_backendAPI_RestAPI.Modesl;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace blog_site_backendAPI_RestAPI
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = ".",
                InitialCatalog = "LemonDotNetCore",
                UserID = "sa",
                Password = "sasasu",
                TrustServerCertificate = true,
            };
            optionsBuilder.UseSqlServer(sqlConnectionStringBuilder.ConnectionString);
        }
        public DbSet<BlogDataModel> Blogs { get; set; }
    }
}