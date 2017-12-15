using MediaStore.Infrastructure.Interfaces;
using Caliburn.Micro;
using Windows.UI.Xaml.Controls;
using MediaStore.Infrastructure.Layout;
using System.Linq;
using MediaStore.Infrastructure.Categories;

namespace MediaStore.Win10.ViewModels
{
	public class ShellViewModel : ViewModelBase
	{
		private readonly INavigationManager _navigationManager;
		private readonly ILayoutService _layoutService;

		private FeedsLayoutModel _layout;

		public FeedsLayoutModel Layout
		{
			get => _layout;
			set
			{
				_layout = value;
				NotifyOfPropertyChange(nameof(Layout));
			}
		}

		public ShellViewModel(INavigationManager navigationManager, ILayoutService layoutService)
		{
			_navigationManager = navigationManager;
			_layoutService = layoutService;
		}

		protected override async void PrepareForActivate()
		{
			Layout = await _layoutService.FetchLayoutAsync();
		}

		public void SelectCategory(LayoutCategoryModel item)
		{
			_navigationManager.ShellNavigationService.NavigateToViewModel<FeedsViewModel>(item);
		}

		protected override void PrepareForDeactivate()
		{
			
		}

		public void InitializeShellNavigationService(Frame frame)
		{
			_navigationManager.InitializeShellNavigationService(frame);
		}
	}
}
