using Karlson.Application.Services.TestEntity;
using Karlson.Application.TestEntities.Commands.CreateTestEntity;
using MediatR;
using System.Threading.Tasks;

namespace Karlson.Service.Services.TestEntity
{
	public class TestEntityWriteService : BaseService, ITestEntityWriteService
	{
		public async Task<Unit> CreateTestEntity(CreateTestEntityCommand command)
			=> await Mediatr.Send(command);
	}
}
