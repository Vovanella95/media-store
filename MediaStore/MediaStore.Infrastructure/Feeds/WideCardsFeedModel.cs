using MediaStore.Infrastructure.Items;
using System.Collections.Generic;

namespace MediaStore.Infrastructure.Feeds
{
	public class WideCardsFeedModel : LayoutFeedModelBase
	{
		public string Title { get; set; }
		public IEnumerable<WideCardModelBase> Items { get; set; }
	}
}
