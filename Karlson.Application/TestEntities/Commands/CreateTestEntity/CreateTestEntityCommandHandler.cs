using Karlson.Domain.RepositoryInterfaces.TestEntities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Karlson.Application.TestEntities.Commands.CreateTestEntity
{
	public class CreateTestEntityCommandHandler : IRequestHandler<CreateTestEntityCommand, Unit>
	{
		private readonly ITestEntityRepository teRepository;

		public CreateTestEntityCommandHandler(ITestEntityRepository teRepository)
		{
			this.teRepository = teRepository;
		}

		public async Task<Unit> Handle(CreateTestEntityCommand request, CancellationToken cancellationToken)
		{
			var entity = new Domain.TestEntity
			{
				Name = request.Name
			};

			await teRepository.AddAsync(entity);

			return Unit.Value;
		}
	}
}
