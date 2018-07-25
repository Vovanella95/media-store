using MediaStore.Win10.ViewModels.TitleCards;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace MediaStore.Win10.Views.TitleCards
{
	public sealed partial class MediaDetailsView : Page
	{
		public MediaDetailsViewModel ViewModel { get; set; }

		public MediaDetailsView()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as MediaDetailsViewModel;
			};
		}

		private void OnScreenshotsItemClick(object sender, ItemClickEventArgs e)
		{
			ViewModel.OpenScreenshot(e.ClickedItem as string);
		}

		private void OnTrailerControlTapped(object sender, TappedRoutedEventArgs e)
		{
			ViewModel.OpenVideo();
		}
	}
}
