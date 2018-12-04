using Karlson.Application.Exceptions;
using Karlson.DataAccess.DbCtx;
using Karlson.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Karlson.Application.TestEntities.Queries.GetEntityDetails
{
	public class GetEntityQueryHandler : IRequestHandler<GetEntityDetailQuery, GetEntityModel>
	{
		private KarlsonDbCtx ctx;

		public GetEntityQueryHandler(KarlsonDbCtx ctx)
		{
			this.ctx = ctx;
		}

		public async Task<GetEntityModel> Handle(GetEntityDetailQuery request, CancellationToken cancellationToken)
		{
			var entity = await ctx.TestEntity.FindAsync(request.TestEntityId);

			if(entity == null)
			{
				throw new NotFoundException(nameof(TestEntity), request.TestEntityId);
			}

			return new GetEntityModel
			{
				TestEntityId = entity.TestEntityId,
				Name = entity.Name
			};
		}
	}
}
