using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Shop.Services.ProductAPI.DbContaxts;
using Shop.Services.ProductAPI.Models;
using Shop.Services.ProductAPI.Models.Dto;

namespace Shop.Services.ProductAPI.Repository
{
	public class ProductRepository : IProductRepository
	{
		private readonly ApplicationDbContext _db;
		private IMapper _mapper;

		public ProductRepository(ApplicationDbContext db, IMapper mapper)
		{
			_db= db;
			_mapper= mapper;
		}

		public async Task<ProductDto> CreateUpdateProductAsync(ProductDto productDto)
		{
			Product product = _mapper.Map<ProductDto, Product>(productDto);
			if (product.ProductId > 0)
			{
				_db.Products.Update(product);
			}
			else
			{
				_db.Products.Add(product);
			}
			await _db.SaveChangesAsync();
			return _mapper.Map<Product, ProductDto>(product);
		}

		public async Task<bool> DeleteProductAsync(int productId)
		{
			Product product = await _db.Products.FirstOrDefaultAsync(x => x.ProductId == productId);
			if (product != null) 
			{
				_db.Products.Remove(product);
				await _db.SaveChangesAsync();
				return true;
			}
			return false;
		}

		public async Task<IEnumerable<ProductDto>> GetAllAsync()
		{
			List<Product> products = await _db.Products.ToListAsync();
			return _mapper.Map<List<ProductDto>>(products);
		}

		public async Task<ProductDto> GetProductByIdAsync(int productId)
		{
			Product product = await _db.Products.Where(x => x.ProductId == productId).FirstOrDefaultAsync();
			return _mapper.Map<ProductDto>(product);
		}
	}
}
