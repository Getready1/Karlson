using Karlson.Application.Account.Commands.RegisterUserCommand;
using Karlson.Application.Account.Commands.SignUserInCommand;
using Karlson.Application.ServiceInterfaces.Account;
using Karlson.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Karlson.Service.Services.Account
{
	public class AccountWriteService : ServiceBase, IAccountWriteService
	{
		public async Task<IdentityResult> RegisterUserAsync(RegisterUserCommand command)
			=> await Mediatr.Send(command);

		public async Task<SignInResult> SignUserInAsync(SignUserInCommand command)
			=> await Mediatr.Send(command);
	}
}
