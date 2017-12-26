using MediaStore.Infrastructure.Interfaces;
using Caliburn.Micro;
using Windows.UI.Xaml.Controls;
using MediaStore.Infrastructure.Layout;
using System.Linq;
using MediaStore.Infrastructure.Categories;
using MediaStore.Win10.ViewModels.TitleCards;

namespace MediaStore.Win10.ViewModels
{
	public class ShellViewModel : ViewModelBase
	{
		private readonly ILayoutService _layoutService;

		public VideoDetailsViewModel VideoDetailsViewModel { get; }
		public ImageDetailsViewModel ImageDetailsViewModel { get; }

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

		public ShellViewModel(
			INavigationManager navigationManager,
			ILayoutService layoutService,
			VideoDetailsViewModel videoDetailsViewModel,
			ImageDetailsViewModel imageDetailsViewModel
			) : base(navigationManager)
		{
			_layoutService = layoutService;
			VideoDetailsViewModel = videoDetailsViewModel;
			ImageDetailsViewModel = imageDetailsViewModel;
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
