using Microsoft.AspNetCore.Mvc;
using Shop.Services.ProductAPI.Models.Dto;
using Shop.Services.ProductAPI.Repository;

namespace Shop.Services.ProductAPI.Controllers
{
	[Route("api/products")]
	public class ProductAPIController : ControllerBase
	{
		private IProductRepository _productRepository;
		private ResponceDto _responceDto;

		public ProductAPIController(IProductRepository productRepository)
		{
			_productRepository= productRepository;
			_responceDto= new ResponceDto();
		}

		[HttpGet]
		public async Task<object> Get() 
		{
			try
			{
				IEnumerable<ProductDto> productDtos = await _productRepository.GetAllAsync();
				_responceDto.Result= productDtos;
			}
			catch (Exception ex)
			{
				_responceDto.IsSuccess = false;
				_responceDto.ErrorMesage = new List<string> { ex.Message };
			}
			return _responceDto;
		}

		[HttpGet]

		public async Task<object> Get(int id)
		{
			try
			{
				ProductDto productDtos = await _productRepository.GetProductByIdAsync(id);
				_responceDto.Result = productDtos;
			}
			catch (Exception ex)
			{
				_responceDto.IsSuccess = false;
				_responceDto.ErrorMesage = new List<string> { ex.Message };
			}
			return _responceDto;
		}
	}
}
