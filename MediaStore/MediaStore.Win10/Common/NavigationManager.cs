using Caliburn.Micro;
using MediaStore.Infrastructure.Interfaces;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10
{
	public class NavigationManager : INavigationManager
	{
		public NavigationManager(INavigationService windowNavigationService)
		{
			WindowNavigationService = windowNavigationService;
		}

		public INavigationService ShellNavigationService { get; private set; }
		public INavigationService WindowNavigationService { get; private set; }

		public void InitializeShellNavigationService(Frame frame)
		{
			ShellNavigationService = new FrameAdapter(frame);
		}
	}
}
