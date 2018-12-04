using JetBrains.Annotations;
using Karlson.DataAccess.Extensions;
using Karlson.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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
