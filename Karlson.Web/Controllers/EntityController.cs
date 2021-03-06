﻿using Karlson.Application.ServiceInterfaces.TestEntity;
using Karlson.Application.TestEntities.Commands.CreateTestEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Karlson.Web.Controllers
{
	[ApiController]
	[Route("api/entities")]
	public class EntityController : Controller
	{
		private ITestEntityReadService entityReadService;
		private ITestEntityWriteService entityWriteServices;

		public EntityController(ITestEntityReadService entityReadService, ITestEntityWriteService entityWriteServices)
		{
			this.entityReadService = entityReadService;
			this.entityWriteServices = entityWriteServices;
		}

		[Authorize]
		[HttpGet("{id:int}")]
		public async Task<IActionResult> Get(int id)
		{
			return Ok(await entityReadService.GetEntityDetail(id));
		}

		[HttpPost]
		public async Task<IActionResult> Create([FromBody] CreateTestEntityCommand command)
		{
			return Ok(await entityWriteServices.CreateTestEntity(command));
		}
	}
}
