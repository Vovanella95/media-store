﻿using Caliburn.Micro;
using MediaStore.Infrastructure.Feeds;
using MediaStore.Infrastructure.Interfaces;
using MediaStore.Infrastructure.Items.Media;
using MediaStore.Win10.ViewModels.TitleCards;
using System.Threading.Tasks;

namespace MediaStore.Win10.ViewModels.Feeds
{
	public class TopSpotFeedViewModel : FeedViewModelBase
	{
		private readonly INavigationManager _navigationManager;
		private readonly ILayoutService _layoutService;

		private TopSpotFeedModel _data;

		public TopSpotFeedModel Data
		{
			get => _data;
			set
			{
				_data = value;
				NotifyOfPropertyChange(nameof(Data));
			}
		}

		public TopSpotFeedViewModel(
			INavigationManager navigationManager,
			ILayoutService layoutService)
		{
			_navigationManager = navigationManager;
			_layoutService = layoutService;
		}

		public override async Task InitializeAsync()
		{
			Data = await _layoutService.FetchFeedAsync<TopSpotFeedModel>(Id, Type);
		}

		public void NavigateToDetails(MediaModelBase mediaItem)
		{
			_navigationManager.ShellNavigationService.NavigateToViewModel<MediaDetailsViewModel>(mediaItem);
		}
	}
}
