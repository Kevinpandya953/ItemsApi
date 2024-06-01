using ItemsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ItemsApi.Data
{
    public partial class itemsContext : DbContext
    {
        public itemsContext(DbContextOptions<itemsContext> options) : base (options) {
        }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
