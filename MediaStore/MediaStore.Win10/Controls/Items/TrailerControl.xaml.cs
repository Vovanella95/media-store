using MediaStore.Infrastructure.Items.Video;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace MediaStore.Win10.Controls.Items
{
	public sealed partial class TrailerControl : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModel", typeof(VideoModelBase),
		typeof(TrailerControl), null);

		public VideoModelBase ViewModel
		{
			get => (VideoModelBase)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public TrailerControl()
		{
			InitializeComponent();

			DataContextChanged += (s, e) => ViewModel = DataContext as DefaultVideoModel;
		}

		private void OnPointerEntered(object sender, PointerRoutedEventArgs e)
		{
			RootBorder.Visibility = Visibility.Visible;
		}

		private void OnPointerExited(object sender, PointerRoutedEventArgs e)
		{
			RootBorder.Visibility = Visibility.Collapsed;
		}
	}
}
