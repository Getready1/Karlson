using Karlson.Application.Exceptions;
using Karlson.Application.Repositories.TestEntity;
using Karlson.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Karlson.Application.TestEntities.Queries.GetEntityDetails
{
	public class GetEntityQueryHandler : IRequestHandler<GetEntityDetailQuery, GetEntityModel>
	{
		private ITestEntityRepository teRepository;

		public GetEntityQueryHandler(ITestEntityRepository teRepository)
		{
			this.teRepository = teRepository;
		}

		public async Task<GetEntityModel> Handle(GetEntityDetailQuery request, CancellationToken cancellationToken)
		{
			var entity = await teRepository.GetByIdAsync(request.TestEntityId);

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
