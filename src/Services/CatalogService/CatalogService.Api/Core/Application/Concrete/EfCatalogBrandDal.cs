using CatalogService.Api.Core.Application.Abstract;
using CatalogService.Api.Core.Domain;
using CatalogService.Api.Infrastructure.Context;

namespace CatalogService.Api.Core.Application.Concrete
{
	public class EfCatalogBrandDal : EfEntityRepositoryBase<CatalogBrand, CatalogContext>, ICatalogBrandDal
	{
	}
}
