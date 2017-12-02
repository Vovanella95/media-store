using MediaStore.Infrastructure.Items.Games;
using System.Collections.Generic;

namespace MediaStore.Infrastructure.Feeds
{
	public class GamesFeedModel : LayoutFeedModelBase
	{
		public string Title { get; set; }
		public IEnumerable<GamesModelBase> Items { get; set; }
	}
}
