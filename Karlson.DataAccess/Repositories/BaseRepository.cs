using Karlson.DataAccess.DbCtx;
using Karlson.Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Karlson.DataAccess.Repositories
{
	public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
	{
		protected KarlsonDbCtx ctx;
		private DbSet<T> dbSet;

		public BaseRepository(KarlsonDbCtx ctx)
		{
			this.ctx = ctx;
			dbSet = ctx.Set<T>();
		}

		public async Task AddAsync(T entity)
		{
			await dbSet.AddAsync(entity);
			await ctx.SaveChangesAsync().ConfigureAwait(false);
		}

		public async Task Delete(T entity)
		{
			dbSet.Remove(entity);
			await ctx.SaveChangesAsync().ConfigureAwait(false);
		}

		public async Task<T> GetByIdAsync(object id)
		{
			return await dbSet.FindAsync(id);
		}

		public async Task<List<T>> ListAllAsync()
		{
			return await dbSet.ToListAsync();
		}
	}
}
