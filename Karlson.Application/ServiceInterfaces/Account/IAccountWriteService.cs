using Karlson.Application.Account.Commands.RegisterUserCommand;
using Karlson.Application.Account.Commands.SignUserInCommand;
using Karlson.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Karlson.Application.ServiceInterfaces.Account
{
	public interface IAccountWriteService
	{
		Task<IdentityResult> RegisterUserAsync(RegisterUserCommand command);
		Task<SignInResult> SignUserInAsync(SignUserInCommand command);
	}
}
