using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Karlson.Application.TestEntities.Commands.CreateTestEntity
{
	public class CreateTestEntityCommand : IRequest
	{
		public string Name { get; set; }
	}
}
