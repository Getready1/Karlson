using Karlson.Domain;
using System.Threading.Tasks;

namespace Karlson.Application.ServiceInterfaces.Account
{
	public interface IAccountReadService
	{
		string GetToken();
		string PasswordSignInAsync(string userName, string password);
		Task<ApplicationUser> FindByNameAsync(string userName);
	}
}
