using Karlson.Application.Account.Queries.FindUserByNameQuery;
using Karlson.Application.ServiceInterfaces.Account;
using Karlson.Domain;
using System;
using System.Threading.Tasks;

namespace Karlson.Service.Services.Account
{
	public class AccountReadService : ServiceBase, IAccountReadService
	{
		public string GetToken()
		{
			throw new NotImplementedException();
		}

		public async Task<ApplicationUser> FindByNameAsync(string userName)
		{
			return await Mediatr.Send(new FindUserByNameQuery { UserName = userName });
		}

		public string PasswordSignInAsync(string userName, string password)
		{
			throw new NotImplementedException();
		}


	}
}
