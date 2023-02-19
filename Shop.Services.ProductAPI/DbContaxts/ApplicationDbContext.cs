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

		protected override void OnModelCreating(ModelBuilder modelBuilder) 
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Product>().HasData(new Product 
			{
				ProductId = 1,
				Name = "LG UltraGear 27GN800-B 68.6 cm (27\") WQHD Monitor",
				Price = 289.90,
				Description = "68.6 cm (27\") 16:9, IPS-Panel (matt)",
				CategoryName = "Monitor",
				ImageUrl = "https://img.computerunivers.net/images/400x400/908610758A1A6A22A492410BAD9A4C32.jpg"
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				ProductId = 2,
				Name = "LG UltraGear 24GN60R-B 61.0 cm (24\") Full HD Monitor",
				Price = 173.90,
				Description = "1920 x 1080 Full HD, Reaktionszeit 1 ms, HDR10",
				CategoryName = "Monitor",
				ImageUrl = "https://img.computerunivers.net/images/400x400/90912818F785671B23BD4C2A93CB400E.jpg"
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				ProductId = 3,
				Name = "AOC CQ27G2U/BK 68.6 cm (27\") WQHD Monitor",
				Price = 259.90,
				Description = "68.6 cm (27\") 16:9 Curved, VA-Panel",
				CategoryName = "Monitor",
				ImageUrl = "https://img.computerunivers.net/images/400x400/9078908779FE8FA2CB54449EB7996CD7.jpg"
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				ProductId = 4,
				Name = "ASUS TUF VG27AQ 68.6 cm (27\") WQHD Monitor",
				Price = 319.00,
				Description = "up to 165 Hz, Adaptive Sync / FreeSync, G-SYNC®, G-SYNC® kompatibel",
				CategoryName = "Monitor",
				ImageUrl = "https://img.computerunivers.net/images/400x400/90777448CE8646DF987A45B098375EA1.jpg"
			});
		}
	}
}
