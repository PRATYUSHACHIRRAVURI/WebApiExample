namespace WebApiExa.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProductModel : DbContext
    {
        public ProductModel()
            : base("name=ProductModel")
        {
        }

        public virtual DbSet<Producttb> Producttbs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
