using Karlson.DataAccess.Extensions;
using Karlson.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Karlson.DataAccess.DbCtx
{
	public class KarlsonDbCtx : IdentityDbContext<ApplicationUser>
	{
		public KarlsonDbCtx(DbContextOptions options) : base(options)
		{
		}

		public DbSet<TestEntity> TestEntity { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyAllConfigurations();
		}
	}
}
