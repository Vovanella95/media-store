using MediaStore.Infrastructure.Items.Video;
using System.Collections.Generic;

namespace MediaStore.Infrastructure.Feeds
{
	public class VideoCollectionFeedModel : LayoutFeedViewModelBase
	{
		public string Title { get; set; }
		public IEnumerable<VideoModelBase> Items { get; set; }
	}
}
