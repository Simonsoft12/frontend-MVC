using FrontendMVC.Models.ApiResponse;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace FrontendMVC.Controllers
{
    public partial class ProductController : Controller
    {
        [HttpGet("AddForm")]
        public IActionResult AddForm()
        {
            return View();
        }

        [HttpGet("ViewProducts")]
        public async Task<IActionResult> ViewProducts()
        {
            var response = await _httpClient.GetAsync("https://localhost:7101/api/product/GetProducts");

            if (response.IsSuccessStatusCode)
            {
                var productsJson = await response.Content.ReadAsStringAsync();

                var apiResponse = JsonSerializer.Deserialize<ApiResponse>(productsJson);
                if (apiResponse != null && apiResponse.Result != null)
                {
                    return View("View", apiResponse.Result);
                }

                return View("Error");
            }

            return View("Error");
        }
    }
}
