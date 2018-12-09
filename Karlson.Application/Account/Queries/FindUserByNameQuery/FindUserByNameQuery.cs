using Karlson.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Karlson.Application.Account.Queries.FindUserByNameQuery
{
	public class FindUserByNameQuery : IRequest<ApplicationUser>
	{
		public string UserName { get; set; }
	}
}
