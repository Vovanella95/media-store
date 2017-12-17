using MediaStore.Infrastructure.Items;
using System.Collections.Generic;

namespace MediaStore.Infrastructure.Feeds
{
	public class CollectionFeedModel : LayoutFeedViewModelBase
	{
		public string Title { get; set; }
		public string SecondTitle { get; set; }
		public string BackgroundImageUrl { get; set; }
		public IEnumerable<FeedItemModelBase> Items { get; set; }
	}
}
