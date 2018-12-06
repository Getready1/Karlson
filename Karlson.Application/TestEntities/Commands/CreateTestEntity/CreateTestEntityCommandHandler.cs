using Karlson.DataAccess.DbCtx;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Karlson.Application.TestEntities.Commands.CreateTestEntity
{
	public class CreateTestEntityCommandHandler : IRequestHandler<CreateTestEntityCommand, Unit>
	{
		private readonly KarlsonDbCtx ctx;

		public CreateTestEntityCommandHandler(KarlsonDbCtx ctx)
		{
			this.ctx = ctx;
		}

		public async Task<Unit> Handle(CreateTestEntityCommand request, CancellationToken cancellationToken)
		{
			var entity = new Domain.TestEntity
			{
				Name = request.Name
			};

			ctx.TestEntity.Add(entity);

			var result = await ctx.SaveChangesAsync();

			return Unit.Value;
		}
	}
}
