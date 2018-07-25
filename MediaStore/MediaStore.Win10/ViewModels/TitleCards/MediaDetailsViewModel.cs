using MediaStore.Infrastructure.Interfaces;
using MediaStore.Infrastructure.Items.Media;
using MediaStore.Infrastructure.Items.Video;
using MediaStore.Win10.Common;
using MediaStore.Win10.ViewModels.Feeds;
using MediaStore.Win10.ViewModels.Messages;

namespace MediaStore.Win10.ViewModels.TitleCards
{
	public class MediaDetailsViewModel : ViewModelBase
	{
		private readonly GenericFeedsViewModelFactory _feedsFactory;

		public MediaModelBase _data;
		private FeedsControlViewModel _feedsControlViewModel;
		private readonly IMessageRoot _messageRoot;

		public MediaDetailsViewModel(GenericFeedsViewModelFactory feedsFactory, INavigationManager navigationManager, IMessageRoot messageRoot) : base(navigationManager)
		{
			_feedsFactory = feedsFactory;
			_messageRoot = messageRoot;
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

		public void OpenScreenshot(string url)
		{
			_messageRoot.Raise(new ImageDetailsOpenedMessage
			{
				ImageUrl = url
			});
		}

		public void OpenVideo()
		{
			_messageRoot.Raise(new VideoDetailsOpenedMessage
			{
				Data = Data.Trailer
			});
		}
	}
}
