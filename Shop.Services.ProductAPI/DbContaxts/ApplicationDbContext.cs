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
				Description = "68.6 cm (27\") 16:9, IPS-Panel (matt)",
				Price = 289.90,
				ImageUrl = "",
				CategoryName = "Monitor"
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				ProductId = 1,
				Name = "LG UltraGear 24GN60R-B 61.0 cm (24\") Full HD Monitor",
				Description = "1920 x 1080 Full HD, Reaktionszeit 1 ms, HDR10",
				Price =	173.90,
				ImageUrl = "",
				CategoryName = "Monitor"
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				ProductId = 1,
				Name = "AOC CQ27G2U/BK 68.6 cm (27\") WQHD Monitor",
				Description = "68.6 cm (27\") 16:9 Curved, VA-Panel",
				Price =	259.90,
				ImageUrl = "",
				CategoryName = "Monitor"
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				ProductId = 1,
				Name = "ASUS TUF VG27AQ 68.6 cm (27\") WQHD Monitor",
				Description = "up to 165 Hz, Adaptive Sync / FreeSync, G-SYNC®, G-SYNC® kompatibel",
				Price =	319.00,
				ImageUrl = "",
				CategoryName = "Monitor"
			});
		}
	}
}
