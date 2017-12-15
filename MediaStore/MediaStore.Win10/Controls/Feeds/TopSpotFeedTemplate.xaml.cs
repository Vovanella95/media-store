using MediaStore.Win10.ViewModels.Feeds;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Feeds
{
	public sealed partial class TopSpotFeedTemplate : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(TopSpotFeedViewModel),
		typeof(TopSpotFeedTemplate), null);

		public TopSpotFeedViewModel ViewModel
		{
			get => (TopSpotFeedViewModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public TopSpotFeedTemplate()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as TopSpotFeedViewModel;
			};
		}
	}
}
