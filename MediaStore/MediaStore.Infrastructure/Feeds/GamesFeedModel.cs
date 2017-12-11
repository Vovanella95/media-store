using MediaStore.Infrastructure.Items.Media;
using System.Collections.Generic;

namespace MediaStore.Infrastructure.Feeds
{
	public class GamesFeedModel : LayoutFeedModelBase
	{
		public string Title { get; set; }
		public IEnumerable<MediaModelBase> Items { get; set; }
	}
}
