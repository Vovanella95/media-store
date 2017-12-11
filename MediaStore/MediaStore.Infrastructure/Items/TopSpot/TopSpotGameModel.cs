using MediaStore.Infrastructure.Items.Media;

namespace MediaStore.Infrastructure.Items.TopSpot
{
	public class TopSpotGameModel : TopSpotModelBase
	{
		public string Id { get; set; }
		public string Title { get; set; }
		public int Raiting { get; set; }
		public string[] Genres { get; set; }
		public string ImageUrl { get; set; }
		public string PosterUrl { get; set; }
		public string Descriptopn { get; set; }
		public GamePlatform[] Platforms { get; set; }
	}
}
