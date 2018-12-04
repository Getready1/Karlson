using Karlson.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Karlson.DataAccess.EntityConfigs
{
	public class TestEntityConfiguration : IEntityTypeConfiguration<TestEntity>
	{
		public void Configure(EntityTypeBuilder<TestEntity> builder)
		{
			builder.HasKey(x => x.TestEntityId);
			builder.Property(x => x.TestEntityId).HasColumnName("TestId");
		}
	}
}
