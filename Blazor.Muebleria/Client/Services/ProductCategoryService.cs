using Blazor.Muebleria.Shared;
using System.Net.Http.Json;

namespace Blazor.Muebleria.Client.Services
{
	public class ProductCategoryService : IProductCategoryService
	{
		private readonly HttpClient _httpClient;
		public ProductCategoryService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<IEnumerable<ProductCategory>> GetProductCategories()
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<ProductCategory>>($"api/ProductCategory");
		}
	}
}
