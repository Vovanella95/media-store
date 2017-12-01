using Caliburn.Micro;

namespace MediaStore.Win10.ViewModels
{
	public abstract class ViewModelBase : Screen
	{
		public ViewModelBase()
		{
			
		}

		protected abstract void PrepareForActivate();
		protected abstract void PrepareForDeactivate();

		protected override void OnActivate()
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
