using MediaStore.Infrastructure.Interfaces;

namespace MediaStore.Win10.ViewModels
{
	public class TitleCardViewModel : ViewModelBase
	{
		public TitleCardViewModel(INavigationManager navigationManager) : base(navigationManager)
		{
			
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
