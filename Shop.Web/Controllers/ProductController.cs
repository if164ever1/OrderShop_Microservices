using Microsoft.AspNetCore.Mvc;
using Shop.Web.Models;
using Shop.Web.Services.IServices;
using System.Collections.Generic;

namespace Shop.Web.Controllers
{
	public class ProductController : Controller
	{
		private readonly IProductService _productService;

		public ProductController(IProductService productService)
		{
			_productService = productService;
		}

		public async Task<IActionResult> ProductIndex()
		{
			List<ProductDto> productList = new();
			var responce = await _productService.GetAllProductsAsync<ResponceDto>
			return View();
		}
	}
}
