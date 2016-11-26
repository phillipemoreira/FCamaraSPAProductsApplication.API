using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;

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
            return db.Product;
        }

        // GET: api/Products/5
        [Authorize]
        [Route("")]
        [ResponseType(typeof(ProductModel))]
        public IHttpActionResult GetProductModel(string id)
        {
            ProductModel productModel = db.Product.Find(id);
            if (productModel == null)
            {
                return NotFound();
            }

            return Ok(productModel);
        }
    }
}