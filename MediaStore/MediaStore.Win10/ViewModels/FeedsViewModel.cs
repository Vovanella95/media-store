using MediaStore.Infrastructure.Feeds;
using MediaStore.Infrastructure.Interfaces;
using MediaStore.Infrastructure.Items.TopSpot;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaStore.Win10.ViewModels
{
	public class FeedsViewModel : ViewModelBase
	{
		private readonly ILayoutService _layoutService;

		private IEnumerable<LayoutFeedModelBase> _feeds;

		public IEnumerable<LayoutFeedModelBase> Feeds
		{
			get => _feeds;
			set
			{
				_feeds = value;
				NotifyOfPropertyChange(nameof(Feeds));
				NotifyOfPropertyChange(nameof(BackgroundImageUrl));
			}
		}

		public string BackgroundImageUrl => ((Feeds?.FirstOrDefault() as TopSpotFeedModel)?.Items?.FirstOrDefault() as TopSpotModelBase)?.ImageUrl;

		public FeedsViewModel(ILayoutService layoutService)
		{
			_layoutService = layoutService;
		}

		public async Task LoadFeedsAsync()
		{
			Feeds = (await _layoutService.FetchLayoutAsync()).Categories.First().Feeds;
		}

		protected override async void PrepareForActivate()
		{
			await LoadFeedsAsync();
		}

		protected override void PrepareForDeactivate()
		{

		}
	}
}
