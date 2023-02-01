using Blazor.Muebleria.Shared;
using Dapper;
using System.Data;

namespace Blazor.Muebleria.Repositorio
{
	public class ProductCategoryRepository : IProductCategoryRepository
	{
		private readonly IDbConnection _db;
			public ProductCategoryRepository(IDbConnection db)
		{
			_db = db;
		}
		public async Task<IEnumerable<ProductCategory>> GetAll()
		{
			var sql = @"SELECT Id as Id, Name as Name
						FROM ProductCategories";

			return await _db.QueryAsync<ProductCategory>(sql, new { });
		}
	}
}
