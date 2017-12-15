using MediaStore.Win10.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
namespace MediaStore.Win10.Views
{
    public sealed partial class TitleCardView : Page
    {
		public TitleCardViewModel ViewModel { get; set; }

		public TitleCardView()
        {
            InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as TitleCardViewModel;
			};
        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			ViewModel.GoBack();
		}
	}
}
