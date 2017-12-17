using MediaStore.Win10.ViewModels.TitleCards;
using Windows.UI.Xaml.Controls;

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
	}
}
