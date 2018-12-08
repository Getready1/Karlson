using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Karlson.Domain.RepositoryInterfaces

{
	public interface IBaseRepository<T>
	{
		Task<List<T>> ListAllAsync();
		Task AddAsync(T entity);
		Task Delete(T entity);
		Task<T> GetByIdAsync(object id);
	}
}