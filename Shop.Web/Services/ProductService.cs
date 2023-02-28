using Shop.Web.Models;
using Shop.Web.Services.IServices;

namespace Shop.Web.Services
{
	public class ProductService : BaseService, IProductService
	{
		private readonly IHttpClientFactory _clientFactory;
		public ProductService(IHttpClientFactory clientFactory) : base(clientFactory)
		{
			_clientFactory = clientFactory;
		}

		public async Task<T> CreateProductAsync<T>(ProductDto productDto)
		{
			return await this.SendAsync<T>(new ApiRequest()
			{
				ApiType = SD.ApiType.POST,
				Data = productDto,
				Url = SD.ProductAPIBase + "/api/products",
				AccessToken = ""
			});
		}

		public async Task<T> DeleteProductAsync<T>(int productId)
		{
			return await this.SendAsync<T>(new ApiRequest()
			{
				ApiType = SD.ApiType.DELETE,
				Url = SD.ProductAPIBase + "/api/products" + productId,
				AccessToken = ""
			});
		}

		public async Task<T> GetAllProductsAsync<T>()
		{
			return await this.SendAsync<T>(new ApiRequest()
			{
				ApiType = SD.ApiType.GET,
				Url = SD.ProductAPIBase + "/api/products",
				AccessToken = ""
			});
		}

		public async Task<T> GetProductByIdAsync<T>(int productId)
		{
			return await this.SendAsync<T>(new ApiRequest()
			{
				ApiType = SD.ApiType.GET,
				Url = SD.ProductAPIBase + "/api/products",
				AccessToken = ""
			});
		}

		public async Task<T> UpdateProductAsync<T>(ProductDto productDto)
		{
			return await this.SendAsync<T>(new ApiRequest()
			{
				ApiType = SD.ApiType.PUT,
				Data = productDto,
				Url = SD.ProductAPIBase + "/api/products",
				AccessToken = ""
			});
		}
	}
}
