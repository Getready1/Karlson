using Karlson.DataAccess.DbCtx;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Karlson.DataAccess.Extensions
{
	public static class ModelBuilderExtensions
	{
		public static void ApplyAllConfigurations(this ModelBuilder builder)
		{
			var applyConfigurationMethodInfo = builder
				.GetType()
				.GetMethods(BindingFlags.Instance | BindingFlags.Public)
				.First(m => m.Name.Equals("ApplyConfiguration", StringComparison.OrdinalIgnoreCase));

			typeof(KarlsonDbCtx).Assembly
				.GetTypes()
				.Select(t => (t, i: t.GetInterfaces().FirstOrDefault(i => i.Name.Equals(typeof(IEntityTypeConfiguration<>).Name, StringComparison.Ordinal))))
				.Where(it => it.i != null)
				.Select(it => (et: it.i.GetGenericArguments()[0], cfgObj: Activator.CreateInstance(it.t)))
				.Select(it => applyConfigurationMethodInfo.MakeGenericMethod(it.et).Invoke(builder, new[] { it.cfgObj }))
				.ToList();
		}
	}
}
