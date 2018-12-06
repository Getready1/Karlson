using Karlson.Application.TestEntities.Commands.CreateTestEntity;
using MediatR;
using System.Threading.Tasks;

namespace Karlson.Core.Services.ServicesInterfaces.TestEntity
{
	public interface ITestEntityWriteService
	{
		Task<Unit> CreateTestEntity(CreateTestEntityCommand command);
	}
}
