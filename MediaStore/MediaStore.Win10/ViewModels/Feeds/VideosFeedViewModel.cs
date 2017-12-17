using Caliburn.Micro;
using MediaStore.Infrastructure.Feeds;
using MediaStore.Infrastructure.Interfaces;
using MediaStore.Infrastructure.Items.Media;
using MediaStore.Win10.ViewModels.TitleCards;
using System.Threading.Tasks;

namespace MediaStore.Win10.ViewModels.Feeds
{
	public class VideosFeedViewModel : FeedViewModelBase
	{
		private VideoCollectionFeedModel _data;
		private readonly INavigationManager _navigationManager;
		private readonly ILayoutService _layoutService;

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
			ILayoutService layoutService)
		{
			_navigationManager = navigationManager;
			_layoutService = layoutService;
		}

		public override async Task InitializeAsync()
		{
			Data = await _layoutService.FetchFeedAsync<VideoCollectionFeedModel>(Id, Type);
		}

		public void NavigateToDetails(MediaModelBase mediaItem)
		{
			_navigationManager.ShellNavigationService.NavigateToViewModel<MediaDetailsViewModel>(mediaItem);
		}
	}
}
