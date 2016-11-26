namespace FCamaraSPAProductsApplication.API
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProductContext context)
        {
            context.Product.AddOrUpdate(
              p => p.ProdId,
              new ProductModel { ProdId = "001", Name = "Bolacha", Price = 2.40 },
              new ProductModel { ProdId = "002", Name = "Salame", Price = 15.40 },
              new ProductModel { ProdId = "003", Name = "Aspargo", Price = 7.35 },
              new ProductModel { ProdId = "004", Name = "Melancia", Price = 10.0 },
              new ProductModel { ProdId = "005", Name = "Mobilete", Price = 5000.0 },
              new ProductModel { ProdId = "006", Name = "Cerveja", Price = 22.50 },
              new ProductModel { ProdId = "007", Name = "Chinelo", Price = 42.0 },
              new ProductModel { ProdId = "008", Name = "Cream cheese", Price = 5.82 }
            );
        }
    }
}