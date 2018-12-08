using Autofac;
using Karlson.DataAccess.Repositories;
using Karlson.Domain.RepositoryInterfaces.TestEntities;

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
