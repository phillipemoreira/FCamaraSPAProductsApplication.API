using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace FCamaraSPAProductsApplication.API
{
    public class ProductModel
    {
        [Key]
        public string ProdId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class ProductContext : DbContext
    {
        public DbSet<ProductModel> Products { get; set; }
    }
}
