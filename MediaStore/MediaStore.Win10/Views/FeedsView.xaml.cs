using MediaStore.Win10.ViewModels;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Views
{
	public sealed partial class FeedsView : Page
	{
		public FeedsViewModel ViewModel { get; set; }

		public FeedsView()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as FeedsViewModel;
			};
		}
	}
}
