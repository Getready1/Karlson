using Karlson.Application.TestEntities.Queries.GetEntityDetails;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Karlson.Core.Services.ServicesInterfaces.TestEntity
{
	public interface ITestEntityReadService
	{
		Task<GetEntityModel> GetEntityDetail(int id);
	}
}
