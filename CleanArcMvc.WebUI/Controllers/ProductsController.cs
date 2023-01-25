using System.Threading.Tasks;
using CleanArcMvc.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArcMvc.WebUI.Controllers
{
	public class ProductsController : Controller
	{
		private readonly IProductService _productsService;
		public ProductsController(IProductService productService)
		{
			_productsService = productService;						
        }			
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var products = await _productsService.GetProducts();
			return View(products);
		}
	}
}
