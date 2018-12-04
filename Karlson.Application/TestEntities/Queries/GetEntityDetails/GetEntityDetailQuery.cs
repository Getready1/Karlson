using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Karlson.Application.TestEntities.Queries.GetEntityDetails
{
	public class GetEntityDetailQuery : IRequest<GetEntityModel>
	{
		public int TestEntityId { get; set; }
	}
}
