using System.Threading.Tasks;

namespace MediaStore.Infrastructure.Interfaces
{
	public interface IAsyncMessageHandler<in T>
	{
		Task HandleAsync(T message);
	}
}
