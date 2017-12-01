using MediaStore.Infrastructure.Categories;
using System.Collections.Generic;

namespace MediaStore.Infrastructure.Layout
{
	public class FeedsLayoutModel
	{
		public IEnumerable<LayoutCategoryModel> Categories { get; set; }
	}
}
