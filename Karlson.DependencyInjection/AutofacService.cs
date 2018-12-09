using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using MediatR;
using Karlson.DependencyInjection.Modules;
using Karlson.DataAccess.DbCtx;

namespace Karlson.DependencyInjection
{
	public static class AutofacService
	{
		public static IServiceProvider GetServiceProvider(IServiceCollection services)
		{
			var builder = new ContainerBuilder();
			builder.Populate(services);
			builder.RegisterType<Mediator>().As<IMediator>();

			builder.RegisterModule(new ServicesModule());
			builder.RegisterModule(new RepositoriesModule());

			return new AutofacServiceProvider(builder.Build());
		}
	}
}
