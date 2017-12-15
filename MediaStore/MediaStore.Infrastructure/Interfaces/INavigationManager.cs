using Caliburn.Micro;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Infrastructure.Interfaces
{
	public interface INavigationManager
	{
		INavigationService ShellNavigationService { get; }
		INavigationService WindowNavigationService { get; }

		void InitializeShellNavigationService(Frame frame);
	}
}
