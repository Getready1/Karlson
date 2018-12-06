﻿using Karlson.Application.TestEntities.Queries.GetEntityDetails;
using Karlson.Core.Services.ServicesInterfaces.TestEntity;
using System.Threading.Tasks;

namespace Karlson.Service.Services.TestEntity
{
	public class TestEntityReadService : BaseService, ITestEntityReadService
	{
		public async Task<GetEntityModel> GetEntityDetail(int id)
			=> await Mediatr.Send(new GetEntityDetailQuery { TestEntityId = id });
	}
}