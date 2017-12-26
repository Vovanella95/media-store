namespace MediaStore.Infrastructure.Interfaces
{
	public interface IMessageHandler<in T>
	{
		void Handle(T message);
	}
}
