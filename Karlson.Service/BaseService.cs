using MediatR;

namespace Karlson.Service
{
	public abstract class BaseService
	{
		public IMediator Mediatr { get; set; }
	}
}
