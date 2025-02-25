using Microsoft.AspNetCore.Mvc;

namespace FrontendMVC.Controllers
{
    [Route("product")]
    public partial class ProductController : Controller
    {
        private readonly HttpClient _httpClient;

        public ProductController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
    }
}
