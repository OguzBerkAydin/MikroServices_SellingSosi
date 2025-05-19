using CatalogService.Api.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace CatalogService.Api.Infrastructure.Context
{
	public class CatalogContext : DbContext
	{

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Catalog;Trusted_Connection=true");
		}


		public DbSet<CatalogItem> CatalogItem { get; set; }
		public DbSet<CatalogBrand> CatalogBrand { get; set; }
		public DbSet<CatalogType> CatalogType { get; set; }

	}	
}
