using System;

namespace MediaStore.Infrastructure.Items.Media
{
	public class MediaModelBase : FeedItemModelBase
	{
		public string Title { get; set; }
		public string[] Genres { get; set; }
		public DateTime ReleaseDate { get; set; }
		public string PosterUrl { get; set; }
		public GamePlatform[] Platforms { get; set; }
		public int Rating { get; set; }
	}
}
