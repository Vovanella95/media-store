using MediaStore.Infrastructure.Categories;
using MediaStore.Infrastructure.Interfaces;
using MediaStore.Win10.Common;
using MediaStore.Win10.ViewModels.Feeds;

namespace MediaStore.Win10.ViewModels
{
	public class FeedsViewModel : ViewModelBase
	{
		private readonly ILayoutService _layoutService;
		private readonly GenericFeedsViewModelFactory _feedsFactory;

		private FeedsControlViewModel _feedsControlViewModel;

		public FeedsControlViewModel FeedsControlViewModel
		{
			get => _feedsControlViewModel;
			set
			{
				_feedsControlViewModel = value;
				NotifyOfPropertyChange(nameof(FeedsControlViewModel));
			}
		}

		//public string BackgroundImageUrl => ((Feeds?.FirstOrDefault() as TopSpotFeedModel)?.Items?.FirstOrDefault() as TopSpotModelBase)?.ImageUrl;

		public FeedsViewModel(
			ILayoutService layoutService,
			INavigationManager navigationManager,
			GenericFeedsViewModelFactory feedsFactory) : base(navigationManager)
		{
			_layoutService = layoutService;
			_feedsFactory = feedsFactory;
		}

		protected override void PrepareForActivate()
		{
			var feedModels = (Parameter as LayoutCategoryModel).Feeds;

			if(feedModels == null)
			{
				return;
			}

			FeedsControlViewModel = new FeedsControlViewModel(_feedsFactory, feedModels);
		}

		protected override void PrepareForDeactivate()
		{

		}
	}
}
