using MediaStore.Win10.ViewModels.TitleCards;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Images
{
	public sealed partial class ImageDetailsControl : Page
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(ImageDetailsViewModel),
		typeof(ImageDetailsControl), null);

		public ImageDetailsViewModel ViewModel
		{
			get => (ImageDetailsViewModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public ImageDetailsControl()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as ImageDetailsViewModel;
			};
		}

		public void CloseImage()
		{
			ViewModel.Close();
		}
	}
}
