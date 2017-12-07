using System;

namespace MediaStore.Infrastructure.Items.Games
{
	public class GamesModelBase
	{
		public string Title { get; set; }
		public string[] Genres { get; set; }
		public double Raiting { get; set; }
		public DateTime ReleaseDate { get; set; }
		public string PosterUrl { get; set; }
		public GamePlatform[] Platforms { get; set; }
		public int Rating { get; set; }
	}
}
