using MediaStore.Infrastructure.Feeds;
using System.Threading.Tasks;

namespace MediaStore.Win10.ViewModels.Feeds
{
	public class VideosFeedViewModel : FeedViewModelBase
	{
		private VideoCollectionFeedModel _data;

		public VideoCollectionFeedModel Data
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
			
		}
	}
}
