using MediaStore.Infrastructure.Categories;
using MediaStore.Infrastructure.Feeds;
using MediaStore.Infrastructure.Interfaces;
using MediaStore.Infrastructure.Items.TopSpot;
using MediaStore.Win10.Common;
using MediaStore.Win10.ViewModels.Feeds;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MediaStore.Win10.ViewModels
{
	public class FeedsViewModel : ViewModelBase
	{
		private readonly ILayoutService _layoutService;
		private readonly GenericFeedsViewModelFactory _feedsFactory;

		private ObservableCollection<FeedViewModelBase> _feeds;

		public ObservableCollection<FeedViewModelBase> Feeds
		{
			get => _feeds;
			set
			{
				_feeds = value;
				NotifyOfPropertyChange(nameof(Feeds));
			}
		}

		//public string BackgroundImageUrl => ((Feeds?.FirstOrDefault() as TopSpotFeedModel)?.Items?.FirstOrDefault() as TopSpotModelBase)?.ImageUrl;

		public FeedsViewModel(
			ILayoutService layoutService,
			GenericFeedsViewModelFactory feedsFactory)
		{
			_layoutService = layoutService;
			_feedsFactory = feedsFactory;
		}

		protected override async void PrepareForActivate()
		{
			var feedModels = (Parameter as LayoutCategoryModel).Feeds;

			if(feedModels == null)
			{
				return;
			}

			Feeds = new ObservableCollection<FeedViewModelBase>();

			foreach (var feedItem in feedModels)
			{
				var item = _feedsFactory.GetViewModelFor(feedItem);
				await item.InitializeAsync();
				Feeds.Add(item);
			}
		}

		protected override void PrepareForDeactivate()
		{

		}
	}
}
