using MediaStore.Infrastructure.Feeds;
using System.Collections.Generic;

namespace MediaStore.Infrastructure.Items
{
	public class FeedItemModelBase
	{
		public IEnumerable<LayoutFeedEmptyModel> RelatedFeeds { get; set; }
	}
}
