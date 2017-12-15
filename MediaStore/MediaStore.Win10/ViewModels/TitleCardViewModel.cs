using MediaStore.Infrastructure.Interfaces;

namespace MediaStore.Win10.ViewModels
{
	public class TitleCardViewModel : ViewModelBase
	{
		private readonly INavigationManager _navigationManager;

		public TitleCardViewModel(INavigationManager navigationManager)
		{
			_navigationManager = navigationManager;
		}

		protected override void PrepareForActivate()
		{
			
		}

		protected override void PrepareForDeactivate()
		{
			
		}

		public void GoBack()
		{
			_navigationManager.WindowNavigationService.GoBack();
		}
	}
}
