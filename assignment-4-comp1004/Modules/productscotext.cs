namespace assignment_4_comp1004.Modules
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class productscotext : DbContext
    {
        public productscotext()
            : base("name=productscotextconnection")
        {
        }

        public virtual DbSet<product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<product>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
