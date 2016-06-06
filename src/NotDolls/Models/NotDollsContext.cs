using Microsoft.EntityFrameworkCore;

namespace NotDolls.Models
{
    public class NotDollsContext : DbContext
    {
        public NotDollsContext(DbContextOptions<NotDollsContext> options)
            : base(options)
        { }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<InventoryImage> Images { get; set; }
    }

}
