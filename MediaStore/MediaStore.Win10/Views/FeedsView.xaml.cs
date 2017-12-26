using MediaStore.Win10.Controls.Feeds;
using MediaStore.Win10.ViewModels;
using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.ViewManagement;
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

			HideAppBar();
		}

		private void HideAppBar()
		{
			/*ApplicationViewTitleBar formattableTitleBar = ApplicationView.GetForCurrentView().TitleBar;
			formattableTitleBar.ButtonBackgroundColor = Colors.Transparent;
			CoreApplicationViewTitleBar coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
			coreTitleBar.ExtendViewIntoTitleBar = true;*/
		}
	}
}
