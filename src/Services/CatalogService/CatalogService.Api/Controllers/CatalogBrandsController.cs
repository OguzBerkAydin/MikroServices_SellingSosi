using CatalogService.Api.Core.Application.Abstract;
using CatalogService.Api.Core.Application.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogService.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CatalogBrandsController : ControllerBase
	{
		EfCatalogBrandDal brandDal = new EfCatalogBrandDal();

		[HttpGet]
		public IActionResult GetAll()
		{
			return Ok(brandDal.GetAll());
		}



    }
}
