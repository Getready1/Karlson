using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Karlson.Application.Token.Queries
{
	public class GetTokenQuery : IRequest<string>
	{
		public string Email { get; set; }
	}
}
