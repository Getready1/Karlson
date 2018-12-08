using Autofac;
using Karlson.Application.ServiceInterfaces.TestEntity;
using Karlson.Service.Services.TestEntity;

namespace Karlson.DependencyInjection.Modules
{
	public class ServicesModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<TestEntityReadService>()
				.PropertiesAutowired()
				.As<ITestEntityReadService>();

			builder.RegisterType<TestEntityWriteService>()
				.PropertiesAutowired()
				.As<ITestEntityWriteService>();
		}
	}
}
