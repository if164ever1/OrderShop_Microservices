using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Shop.Services.ProductAPI.Models;

namespace Shop.Services.ProductAPI.DbContaxts
{
	public class ApplicationDbContext: DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions): base(dbContextOptions)
		{

		}

		public DbSet<Product> Products { get; set; }
	}
}
