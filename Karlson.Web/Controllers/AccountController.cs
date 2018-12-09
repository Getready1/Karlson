using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Karlson.Application.Account.Commands.RegisterUserCommand;
using Karlson.Application.Account.Commands.SignUserInCommand;
using Karlson.Application.ServiceInterfaces;
using Karlson.Application.ServiceInterfaces.Account;
using Karlson.Application.Token.Queries;
using Karlson.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Karlson.Web.Controllers
{
	[Produces("application/json")]
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController : Controller
    {
		private IAccountReadService accountReadService;
		private IAccountWriteService accountWriteService;
		private ITokenService tokenService;

		public AccountController(
			IAccountReadService accountReadService,
			IAccountWriteService accountWriteService,
			ITokenService tokenService
			)
		{
			this.accountReadService = accountReadService;
			this.accountWriteService = accountWriteService;
			this.tokenService = tokenService;
		}

		[HttpPost, AllowAnonymous]
		[Route("register")]
		public async Task<IActionResult> Register([FromBody] RegisterUserCommand command)
		{
			var result = await accountWriteService.RegisterUserAsync(command);
			if (result.Succeeded)
			{
				var signInResult = await accountWriteService.SignUserInAsync(new SignUserInCommand
				{
					Email = command.Email,
					Password = command.Password
				});

				if (signInResult.Succeeded)
				{
					var token = await tokenService.GetToken(new GetTokenQuery { Email = command.Email });
					return Ok(token);
				}
				else return BadRequest("Sign in failed.");
			}

			return BadRequest("Registration failed.");
		}

		[HttpPost, AllowAnonymous]
		[Route("sign-in")]
		public async Task<IActionResult> SignIn([FromBody] SignUserInCommand command)
		{
			var signInResult = await accountWriteService.SignUserInAsync(new SignUserInCommand
			{
				Email = command.Email,
				Password = command.Password
			});

			if (signInResult.Succeeded)
				return Ok(await tokenService.GetToken(new GetTokenQuery { Email = command.Email }));

			return BadRequest("Sign in failed.");
		}

		[HttpPost, Authorize]
		[Route("refresh-token")]
		public async Task<IActionResult> RefreshToken()
			=> Ok(await tokenService.GetToken(new GetTokenQuery { Email = User.Identity.Name}));
	}
}