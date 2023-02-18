using AutoMapper;
using Shop.Services.ProductAPI.Models;
using Shop.Services.ProductAPI.Models.Dto;

namespace Shop.Services.ProductAPI
{
	public class MapperConfig
	{
		public static MapperConfiguration RegisterMappers() 
		{
			var mappingConfig = new MapperConfiguration(config => 
			{
				config.CreateMap<ProductDto, Product>().ReverseMap();
			});

			return mappingConfig;
		}
	}
}
