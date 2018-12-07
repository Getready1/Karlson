using Karlson.Application.Repositories.TestEntity;
using Karlson.DataAccess.DbCtx;
using Karlson.Domain;

namespace Karlson.DataAccess.Repositories
{
	public class TestEntityRepository : BaseRepository<TestEntity>, ITestEntityRepository
	{
		public TestEntityRepository(KarlsonDbCtx ctx) : base(ctx)
		{
		}
	}
}
