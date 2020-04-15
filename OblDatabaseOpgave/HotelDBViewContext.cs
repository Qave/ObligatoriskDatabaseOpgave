namespace OblDatabaseOpgave
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HotelDBViewContext : DbContext
    {
        public HotelDBViewContext()
            : base("name=HotelDBViewContext")
        {
        }

        public virtual DbSet<BookingsView> BookingsViews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookingsView>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<BookingsView>()
                .Property(e => e.Address)
                .IsUnicode(false);
        }
    }
}
