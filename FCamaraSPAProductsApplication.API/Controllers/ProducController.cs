using System.Linq;
using System.Web.Http;

namespace FCamaraSPAProductsApplication.API.Controllers
{
    [RoutePrefix("api/Products")]
    public class ProductController : ApiController
    {
        private ProductContext db = new ProductContext();

        // GET: api/Products
        [Authorize]
        [Route("")]
        public IQueryable<ProductModel> GetProduct()
        {
            return db.Products;
        }
    }
}