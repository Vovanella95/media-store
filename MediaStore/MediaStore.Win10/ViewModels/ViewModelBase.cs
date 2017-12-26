using Caliburn.Micro;
using MediaStore.Infrastructure.Interfaces;

namespace MediaStore.Win10.ViewModels
{
	public abstract class ViewModelBase : Screen
	{
		protected readonly INavigationManager _navigationManager;

		public ViewModelBase(INavigationManager navigationManager)
		{
			_navigationManager = navigationManager;
		}

		public object Parameter { get; set; }

		protected abstract void PrepareForActivate();
		protected abstract void PrepareForDeactivate();

		protected override void OnViewLoaded(object view)
		{
			base.OnActivate();
			PrepareForActivate();
		}

		protected override void OnDeactivate(bool close)
		{
			base.OnDeactivate(close);
			PrepareForDeactivate();
		}
	}
}
