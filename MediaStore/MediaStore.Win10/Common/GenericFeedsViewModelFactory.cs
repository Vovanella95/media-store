using MediaStore.Infrastructure.Feeds;
using MediaStore.Infrastructure.Interfaces;
using MediaStore.Win10.ViewModels.Feeds;

namespace MediaStore.Win10.Common
{
	public class GenericFeedsViewModelFactory
	{
		private readonly INavigationManager _navigationManager;
		private readonly ILayoutService _layoutService;

		public GenericFeedsViewModelFactory(INavigationManager navigationManager, ILayoutService layoutService)
		{
			_navigationManager = navigationManager;
			_layoutService = layoutService;
		}

		public FeedViewModelBase GetViewModelFor(LayoutFeedEmptyModel feedModel)
		{
			if (feedModel.Type == FeedType.GAMES_FEED)
			{
				return new GamesFeedViewModel(_navigationManager, _layoutService)
				{
					Id = feedModel.Id,
					Type = feedModel.Type
				};
			}

			if(feedModel.Type == FeedType.COLLECTION_FEED)
			{
				return new CollectionFeedViewModel(_navigationManager, _layoutService)
				{
					Id = feedModel.Id,
					Type = feedModel.Type
				};
			}

			if(feedModel.Type == FeedType.TOP_SPOT_FEED)
			{
				return new TopSpotFeedViewModel(_navigationManager, _layoutService)
				{
					Id = feedModel.Id,
					Type = feedModel.Type
				};
			}

			if(feedModel.Type == FeedType.VIDEO_COLLECTION_FEED)
			{
				return new WideCardFeedViewModel(_navigationManager, _layoutService)
				{
					Id = feedModel.Id,
					Type = feedModel.Type
				};
			}

			if(feedModel.Type == FeedType.WIDE_CARDS_FEED)
			{
				return new WideCardFeedViewModel(_navigationManager, _layoutService)
				{
					Id = feedModel.Id,
					Type = feedModel.Type
				};
			}

			return null;
		}
	}
}
