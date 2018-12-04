using Karlson.Application.TestEntities.Commands.CreateTestEntity;
using Karlson.Application.TestEntities.Queries.GetEntityDetails;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Karlson.Web.Controllers
{
	public class EntityController : BaseController
	{
		[HttpGet("{id:int}")]
		public async Task<IActionResult> Get(int id)
		{
			return Ok(await Mediator.Send(new GetEntityDetailQuery { TestEntityId = id }));
		}

		[HttpPost]
		public async Task<IActionResult> Create([FromBody]CreateTestEntityCommand command)
		{
			return Ok(await Mediator.Send(command));
		}
	}
}
