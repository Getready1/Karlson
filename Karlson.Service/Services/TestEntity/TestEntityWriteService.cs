using Karlson.Application.TestEntities.Commands.CreateTestEntity;
using Karlson.Core.Services.ServicesInterfaces.TestEntity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Karlson.Service.Services.TestEntity
{
	public class TestEntityWriteService : BaseService, ITestEntityWriteService
	{
		public async Task<Unit> CreateTestEntity(CreateTestEntityCommand command)
		{
			return await Mediatr.Send(command);
		}
	}
}
