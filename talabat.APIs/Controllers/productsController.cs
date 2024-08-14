using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using talabat.core.entites;
using talabat.core.Repositores;

namespace talabat.APIs.Controllers
{
  
    public class productsController : ApiBaseController
    {
        private readonly IGenericRepository<product> _productrepo;

        public productsController(IGenericRepository<product> productrepo)
        {
          _productrepo = productrepo;
        }
    }
}
