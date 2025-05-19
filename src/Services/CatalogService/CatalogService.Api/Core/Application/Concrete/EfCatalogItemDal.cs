using CatalogService.Api.Core.Application.Abstract;
using CatalogService.Api.Core.Domain;
using CatalogService.Api.Infrastructure.Context;

namespace CatalogService.Api.Core.Application.Concrete
{
	public class EfCatalogItemDal : EfEntityRepositoryBase<CatalogItem, CatalogContext>, ICatalogItemDal
	{
	}
}
