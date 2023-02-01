using Blazor.Muebleria.Repositorio;
using Blazor.Muebleria.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blazor.Muebleria.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductCategoryController : ControllerBase
	{
		private readonly IProductCategoryRepository _repo;

		public ProductCategoryController(IProductCategoryRepository repo)
		{
			_repo= repo;
		}

		[HttpGet]
		public async Task<IEnumerable<ProductCategory>> GetAll()
		{
			return await _repo.GetAll();
		}
	}
}
