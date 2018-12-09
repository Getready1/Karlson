using Autofac;
using Karlson.Application.ServiceInterfaces;
using Karlson.Application.ServiceInterfaces.Account;
using Karlson.Application.ServiceInterfaces.TestEntity;
using Karlson.Service.Services;
using Karlson.Service.Services.Account;
using Karlson.Service.Services.TestEntity;

namespace Karlson.DependencyInjection.Modules
{
	public class ServicesModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<TestEntityReadService>().As<ITestEntityReadService>().PropertiesAutowired();
			builder.RegisterType<TestEntityWriteService>().As<ITestEntityWriteService>().PropertiesAutowired();

			builder.RegisterType<AccountReadService>().As<IAccountReadService>().PropertiesAutowired();
			builder.RegisterType<AccountWriteService>().As<IAccountWriteService>().PropertiesAutowired();

			builder.RegisterType<TokenService>().As<ITokenService>().PropertiesAutowired();
		}
	}
}
