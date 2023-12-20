using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace OnlineStoreApp_2.Data.Context
{
    public class OnlineStoreDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HASANKORKMAZDES\\HASANKORKMAZ;Database=OnlineStoreApp;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
    }
}
