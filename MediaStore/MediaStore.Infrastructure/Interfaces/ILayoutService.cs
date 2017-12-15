using MediaStore.Infrastructure.Feeds;
using MediaStore.Infrastructure.Layout;
using System.Threading.Tasks;

namespace MediaStore.Infrastructure.Interfaces
{
	public interface ILayoutService
	{
		Task<FeedsLayoutModel> FetchLayoutAsync();
		Task<T> FetchFeedAsync<T>(string id, FeedType type) where T : LayoutFeedModelBase;
	}
}
