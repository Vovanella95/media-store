using MediaStore.Infrastructure.Items.Media;
using MediaStore.Win10.Common;
using MediaStore.Win10.ViewModels.Feeds;

namespace MediaStore.Win10.ViewModels.TitleCards
{
	public class MediaDetailsViewModel : ViewModelBase
	{
		private readonly GenericFeedsViewModelFactory _feedsFactory;

		public MediaModelBase _data;
		private FeedsControlViewModel _feedsControlViewModel;

		public MediaDetailsViewModel(GenericFeedsViewModelFactory feedsFactory)
		{
			_feedsFactory = feedsFactory;
		}

		public MediaModelBase Data
		{
			get => _data;
			set
			{
				_data = value;
				NotifyOfPropertyChange(nameof(Data));
			}
		}

		public FeedsControlViewModel FeedsControlViewModel
		{
			get => _feedsControlViewModel;
			set
			{
				_feedsControlViewModel = value;
				NotifyOfPropertyChange(nameof(FeedsControlViewModel));
			}
		}

		protected override void PrepareForActivate()
		{
			Data = Parameter as MediaModelBase;

			FeedsControlViewModel = new FeedsControlViewModel(_feedsFactory, Data.RelatedFeeds);
		}

		protected override void PrepareForDeactivate()
		{
			
		}
	}
}
