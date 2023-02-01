using Blazor.Muebleria.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Muebleria.Repositorio
{
	public interface IProductCategoryRepository
	{
		Task<IEnumerable<ProductCategory>> GetAll();
	}
}
