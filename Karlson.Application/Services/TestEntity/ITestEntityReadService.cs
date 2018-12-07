using Karlson.Application.TestEntities.Queries.GetEntityDetails;
using System.Threading.Tasks;

namespace Karlson.Application.Services.TestEntity
{
	public interface ITestEntityReadService
	{
		Task<GetEntityModel> GetEntityDetail(int id);
	}
}
