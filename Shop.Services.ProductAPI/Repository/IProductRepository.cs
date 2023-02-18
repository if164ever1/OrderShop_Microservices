using Shop.Services.ProductAPI.Models.Dto;

namespace Shop.Services.ProductAPI.Repository
{
	public interface IProductRepository
	{
		Task<IEnumerable<ProductDto>> GetAllAsync();
		Task<ProductDto> GetProductByIdAsync(int productId);
		Task<ProductDto> CreateUpdateProductAsync(ProductDto productDto);
		Task<ProductDto> DeleteProductAsync(int productId);
	}
}
