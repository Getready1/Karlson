using Karlson.Application.ServiceInterfaces;
using Karlson.Application.Token.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Karlson.Service.Services
{
	public class TokenService : ServiceBase, ITokenService
	{
		public async Task<string> GetToken(GetTokenQuery query)
		{
			return await Mediatr.Send(query);
		}
	}
}
