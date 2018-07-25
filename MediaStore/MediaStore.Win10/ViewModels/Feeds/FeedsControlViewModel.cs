using Caliburn.Micro;
using MediaStore.Infrastructure.Feeds;
using MediaStore.Win10.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace MediaStore.Win10.ViewModels.Feeds
{
	public class FeedsControlViewModel : PropertyChangedBase
	{
		private readonly GenericFeedsViewModelFactory _feedsFactory;
		private IEnumerable<LayoutFeedEmptyModel> _feedModels;

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

		public FeedsControlViewModel(GenericFeedsViewModelFactory feedsFactory,
			IEnumerable<LayoutFeedEmptyModel> feedModels)
		{
			_feedsFactory = feedsFactory;
			_feedModels = feedModels;
		}

		public async void InitializeAsync()
		{
			Feeds = new ObservableCollection<FeedViewModelBase>();

			if(_feedModels == null)
			{
				return;
			}

			foreach (var feedItem in _feedModels)
			{
				var item = _feedsFactory.GetViewModelFor(feedItem);
				await item.InitializeAsync();
				Feeds.Add(item);
			}
		}
	}
}
