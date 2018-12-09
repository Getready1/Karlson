using Karlson.Application.Token.Queries;
using System.Threading.Tasks;

namespace Karlson.Application.ServiceInterfaces
{
	public interface ITokenService
	{
		Task<string> GetToken(GetTokenQuery query);
	}
}
