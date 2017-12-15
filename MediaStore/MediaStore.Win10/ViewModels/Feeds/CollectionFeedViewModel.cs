using MediaStore.Infrastructure.Feeds;
using MediaStore.Infrastructure.Items.Media;
using System.Threading.Tasks;

namespace MediaStore.Win10.ViewModels.Feeds
{
	public class CollectionFeedViewModel : FeedViewModelBase
	{
		private CollectionFeedModel _data;

		public CollectionFeedModel Data
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
			await Task.Delay(500);
			Data = new CollectionFeedModel
			{
				BackgroundImageUrl = "https://i.ytimg.com/vi/Y_MB6fVg7H4/maxresdefault.jpg",
				SecondTitle = "Some Title",
				Title = "Title",
				Items = new[]
				{
					new DefaultGamesModel
					{
						Title = "Game 1",
						PosterUrl = "https://media.contentapi.ea.com/content/dam/needforspeed-18/ru-ru/packshots/nfsppc2dpftru.jpg"
					}
				}
			};
		}
	}
}
