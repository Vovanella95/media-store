using System.Threading.Tasks;
using MediaStore.Infrastructure.Feeds;
using MediaStore.Infrastructure.Items.Media;
using MediaStore.Infrastructure.Interfaces;
using Caliburn.Micro;
using MediaStore.Win10.ViewModels.TitleCards;

namespace MediaStore.Win10.ViewModels.Feeds
{
	public class GamesFeedViewModel : FeedViewModelBase
	{
		private readonly INavigationManager _navigationManager;
		private readonly ILayoutService _layoutService;

		public GamesFeedViewModel(
			INavigationManager navigationManager,
			ILayoutService layoutService)
		{
			_navigationManager = navigationManager;
			_layoutService = layoutService;
		}

		private GamesFeedModel _data;

		public GamesFeedModel Data
		{
			get => _data;
			set
			{
				_data = value;
				NotifyOfPropertyChange(nameof(Data));
			}
		}

		public override async Task InitializeAsync()
		{
			Data = await _layoutService.FetchFeedAsync<GamesFeedModel>(Id, Type);
		}

		public void NavigateToDetails(MediaModelBase mediaItem)
		{
			_navigationManager.ShellNavigationService.NavigateToViewModel<MediaDetailsViewModel>(mediaItem);
		}
	}
}
