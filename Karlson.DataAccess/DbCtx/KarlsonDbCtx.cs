using Karlson.DataAccess.Extensions;
using Karlson.Domain;
using Microsoft.EntityFrameworkCore;

namespace Karlson.DataAccess.DbCtx
{
	public class KarlsonDbCtx : DbContext
	{
		public KarlsonDbCtx(DbContextOptions options) : base(options)
		{
		}

		public DbSet<TestEntity> TestEntity { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyAllConfigurations();
		}
	}
}
