using MediaStore.Infrastructure.Items.TopSpot;
using System.Collections.Generic;

namespace MediaStore.Infrastructure.Feeds
{
	public class TopSpotFeedModel : LayoutFeedModelBase
	{
		public IEnumerable<TopSpotModelBase> Items { get; set; }
	}
}
