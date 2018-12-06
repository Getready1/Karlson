using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using MediatR;
using Karlson.DependencyInjection.Modules;

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
			
			return new AutofacServiceProvider(builder.Build());
		}
	}
}
