using Caliburn.Micro;
using MediaStore.Infrastructure.Feeds;
using MediaStore.Infrastructure.Interfaces;
using MediaStore.Infrastructure.Items.Video;
using MediaStore.Win10.ViewModels.Messages;
using MediaStore.Win10.ViewModels.TitleCards;
using System.Threading.Tasks;

namespace MediaStore.Win10.ViewModels.Feeds
{
	public class VideosFeedViewModel : FeedViewModelBase
	{
		private VideoCollectionFeedModel _data;
		private readonly INavigationManager _navigationManager;
		private readonly ILayoutService _layoutService;
		private readonly IMessageRoot _messageRoot;

		public VideoCollectionFeedModel Data
		{
			get => _data;
			set
			{
				_data = value;
				NotifyOfPropertyChange(nameof(Data));
			}
		}

		public VideosFeedViewModel(
			INavigationManager navigationManager,
			IMessageRoot messageRoot,
			ILayoutService layoutService)
		{
			_navigationManager = navigationManager;
			_layoutService = layoutService;
			_messageRoot = messageRoot;
		}

		public override async Task InitializeAsync()
		{
			Data = await _layoutService.FetchFeedAsync<VideoCollectionFeedModel>(Id, Type);
		}

		public void NavigateToDetails(VideoModelBase mediaItem)
		{
			_messageRoot.Raise(new VideoDetailsOpenedMessage
			{
				Data = mediaItem
			});
		}
	}
}
