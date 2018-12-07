using Autofac;
using Karlson.Application.Repositories.TestEntity;
using Karlson.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Karlson.DependencyInjection.Modules
{
	public class RepositoriesModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<TestEntityRepository>().As<ITestEntityRepository>();
		}
	}
}
