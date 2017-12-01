using MediaStore.Infrastructure.Layout;
using System.Threading.Tasks;

namespace MediaStore.Infrastructure.Interfaces
{
	public interface ILayoutService
	{
		Task<FeedsLayoutModel> FetchLayoutAsync();
	}
}
