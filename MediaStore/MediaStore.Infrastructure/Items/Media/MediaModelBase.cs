using System;
using System.Collections.Generic;

namespace MediaStore.Infrastructure.Items.Media
{
	public class MediaModelBase : FeedItemModelBase
	{
		public string Title { get; set; }
		public string[] Genres { get; set; }
		public string Description { get; set; }
		public string PosterUrl { get; set; }
		public string BackgroundUrl { get; set; }
		public int Rating { get; set; }
		public DateTime ReleaseDate { get; set; }
		public string TrailerImageUrl { get; set; }
		public IEnumerable<string> Screenshots { get; set; }
		public string Country { get; set; }
		public string Director { get; set; }
	}
}
