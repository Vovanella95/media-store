using MediaStore.Infrastructure.Feeds;
using System.Collections.Generic;

namespace MediaStore.Infrastructure.Categories
{
	public class LayoutCategoryModel
	{
		public string Id { get; set; }

		public string Name { get; set; }

		public string Icon { get; set; }

		public IEnumerable<LayoutFeedEmptyModel> Feeds { get; set; }
	}
}
