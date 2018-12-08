using Karlson.Application.TestEntities.Commands.CreateTestEntity;
using MediatR;
using System.Threading.Tasks;

namespace Karlson.Application.ServiceInterfaces.TestEntity
{
	public interface ITestEntityWriteService
	{
		Task<Unit> CreateTestEntity(CreateTestEntityCommand command);
	}
}
