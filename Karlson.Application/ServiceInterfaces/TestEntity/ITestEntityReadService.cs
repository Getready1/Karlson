using Karlson.Application.TestEntities.Queries.GetEntityDetails;
using System.Threading.Tasks;

namespace Karlson.Application.ServiceInterfaces.TestEntity
{
	public interface ITestEntityReadService
	{
		Task<GetEntityModel> GetEntityDetail(int id);
	}
}
