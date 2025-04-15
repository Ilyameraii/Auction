namespace BIA_Task_10.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AuctionModel : DbContext
    {
        public AuctionModel()
            : base("name=AuctionModel")
        {
        }

        public virtual DbSet<Directory> Directories { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .Property(e => e.AssessedValue)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Sale>()
                .Property(e => e.StartPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Sale>()
                .Property(e => e.LastPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<User>()
                .Property(e => e.UserPassword)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
