using Karlson.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Karlson.Application.Account.Commands.SignUserInCommand
{
	public class SignUserInCommand : IRequest<SignInResult>
	{
		public string Email { get; set; }
		public string Password { get; set; }
		public bool IsPersistent { get; set; } = default(bool);
		public bool LockoutOnFailure { get; set; } = default(bool);
	}
}
