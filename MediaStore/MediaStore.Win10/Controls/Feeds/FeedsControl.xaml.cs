using MediaStore.Win10.ViewModels.Feeds;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Feeds
{
	public sealed partial class FeedsControl : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(FeedsControlViewModel),
		typeof(CollectionFeedTemplate), new PropertyMetadata(default(FeedsControlViewModel), new PropertyChangedCallback(OnViewModelPropertyChanged)));

		public FeedsControlViewModel ViewModel
		{
			get => (FeedsControlViewModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		private static void OnViewModelPropertyChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			var control = (FeedsControl)sender;
			control.InitializeFeeds();
		}

		public FeedsControl()
		{
			InitializeComponent();
		}

		public void InitializeFeeds()
		{
			ViewModel?.InitializeAsync();
		}
	}
}
