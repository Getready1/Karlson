using Karlson.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Karlson.Application.Account.Commands.SignUserInCommand
{
	public class SignUserInCommandHandler : IRequestHandler<SignUserInCommand, SignInResult>
	{
		private SignInManager<ApplicationUser> signInManager;

		public SignUserInCommandHandler(SignInManager<ApplicationUser> signInManager)
		{
			this.signInManager = signInManager;
		}

		public async Task<SignInResult> Handle(SignUserInCommand request, CancellationToken cancellationToken)
			=> await signInManager.PasswordSignInAsync(
			request.Email,
			request.Password,
			request.IsPersistent,
			request.LockoutOnFailure
			);
	}
}
