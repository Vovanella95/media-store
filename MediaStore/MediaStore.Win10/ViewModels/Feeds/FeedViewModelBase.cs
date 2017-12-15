using Caliburn.Micro;
using MediaStore.Infrastructure.Feeds;
using System.Threading.Tasks;

namespace MediaStore.Win10.ViewModels.Feeds
{
	public abstract class FeedViewModelBase : PropertyChangedBase
	{
		public string Id { get; set; }
		public FeedType Type { get; set; }

		public abstract Task InitializeAsync();
	}
}
