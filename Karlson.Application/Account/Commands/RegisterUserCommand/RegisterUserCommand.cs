using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Karlson.Application.Account.Commands.RegisterUserCommand
{
	public class RegisterUserCommand : IRequest<IdentityResult>
	{
		public string Email { get; set; }
		public string Password { get; set; }
		public string PasswordConfirmation { get; set; }
	}
}
