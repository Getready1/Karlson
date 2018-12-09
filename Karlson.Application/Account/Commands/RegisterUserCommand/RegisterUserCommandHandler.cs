using System.Threading;
using System.Threading.Tasks;
using Karlson.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Karlson.Application.Account.Commands.RegisterUserCommand
{
	public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, IdentityResult>
	{
		private UserManager<ApplicationUser> userManager;

		public RegisterUserCommandHandler(UserManager<ApplicationUser> userManager)
		{
			this.userManager = userManager;
		}

		public async Task<IdentityResult> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
			=> await userManager.CreateAsync(new ApplicationUser
			{
				UserName = request.Email,
				Email = request.Email
			}, request.Password);
	}
}
