using Blazor.Muebleria.Shared;

namespace Blazor.Muebleria.Client.Services
{
	public interface IProductCategoryService
	{
		Task<IEnumerable<ProductCategory>> GetProductCategories();
	}
}
