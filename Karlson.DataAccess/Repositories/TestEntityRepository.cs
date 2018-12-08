using Karlson.DataAccess.DbCtx;
using Karlson.Domain;
using Karlson.Domain.RepositoryInterfaces.TestEntities;

namespace Karlson.DataAccess.Repositories
{
	public class TestEntityRepository : BaseRepository<TestEntity>, ITestEntityRepository
	{
		public TestEntityRepository(KarlsonDbCtx ctx) : base(ctx)
		{
		}
	}
}
