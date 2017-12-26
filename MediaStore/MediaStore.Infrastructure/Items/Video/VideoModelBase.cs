using System;
using System.Collections.Generic;

namespace MediaStore.Infrastructure.Items.Video
{
	public class VideoModelBase : FeedItemModelBase
	{
		public string Id { get; set; }
		public string Title { get; set; }
		public string Source { get; set; }
		public string Url { get; set; }
		public DateTime PublishDate { get; set; }
		public int Views { get; set; }
		public TimeSpan Duration { get; set; }
		public string ImageUrl { get; set; }
		public IEnumerable<VideoCommentDetails> Commentaries { get; set; }
	}
}
