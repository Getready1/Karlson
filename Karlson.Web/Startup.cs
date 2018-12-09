using Karlson.DataAccess.DbCtx;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using MediatR;
using Karlson.Application;
using System.Reflection;
using Karlson.DependencyInjection;
using Karlson.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Karlson.Web
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public IServiceProvider ConfigureServices(IServiceCollection services)
		{
			//services.AddTransient(typeof(IPipelineBehavior<,>), typeof(IPipelineBehavior<,>));

			services.AddMediatR(typeof(ApplicationAssemblyPickUp).GetTypeInfo().Assembly);

			services.AddDbContext<KarlsonDbCtx>(options =>
				options.UseSqlServer(Configuration.GetConnectionString("KarlsonDb")));

			services.AddIdentity<ApplicationUser, IdentityRole>()
				.AddUserManager<UserManager<ApplicationUser>>()
				.AddSignInManager<SignInManager<ApplicationUser>>()
				.AddEntityFrameworkStores<KarlsonDbCtx>();

			var x = Configuration.GetSection("Jwt")["Key"];
			var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]));
			services
				.AddAuthentication(options =>
				{
					options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
					options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
				})
				.AddJwtBearer(config =>
				{
					config.RequireHttpsMetadata = false;
					config.SaveToken = true;
					config.TokenValidationParameters = new TokenValidationParameters
					{
						IssuerSigningKey = signingKey,
						ValidateAudience = true,
						ValidAudience = Configuration["Jwt:Audience"],
						ValidateIssuer = true,
						ValidIssuer = Configuration["Jwt:Issuer"],
						ValidateLifetime = true,
						ValidateIssuerSigningKey = true
					};
				});

			services.AddMvc()
				.SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

			// In production, the React files will be served from this directory
			services.AddSpaStaticFiles(configuration =>
			{
				configuration.RootPath = "ClientApp/build";
			});

			return AutofacService.GetServiceProvider(services);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseSpaStaticFiles();

			app.UseCors(builder => builder
				.AllowAnyOrigin()
				.AllowAnyMethod()
				.AllowAnyHeader()
				.AllowCredentials());

			app.UseAuthentication();

			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller}/{action=Index}/{id?}");
			});

			//app.UseSpa(spa =>
			//{
			//	spa.Options.SourcePath = "ClientApp";

			//	if (env.IsDevelopment())
			//	{
			//		spa.UseReactDevelopmentServer(npmScript: "start");
			//	}
			//});
		}
	}
}
