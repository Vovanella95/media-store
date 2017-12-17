using MediaStore.Infrastructure.Items.TopSpot;
using System.Collections.Generic;

namespace MediaStore.Infrastructure.Feeds
{
	public class TopSpotFeedModel : LayoutFeedViewModelBase
	{
		public IEnumerable<TopSpotModelBase> Items { get; set; }
	}
}
