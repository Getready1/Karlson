using Karlson.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Karlson.Application.Account.Queries.FindUserByNameQuery
{
	public class FindUserByNameQueryHandler : IRequestHandler<FindUserByNameQuery, ApplicationUser>
	{
		private UserManager<ApplicationUser> userManager;

		public FindUserByNameQueryHandler(UserManager<ApplicationUser> userManager)
		{
			this.userManager = userManager;
		}

		public async Task<ApplicationUser> Handle(FindUserByNameQuery request, CancellationToken cancellationToken)
		{
			return await userManager.FindByNameAsync(request.UserName);
		}
	}
}
