using Microsoft.AspNet.Identity.EntityFramework;

namespace FCamaraSPAProductsApplication
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {

        }
    }
}