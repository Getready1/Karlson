using MediatR;

namespace Karlson.Service
{
	public abstract class ServiceBase
	{
		public IMediator Mediatr { get; set; }
	}
}
