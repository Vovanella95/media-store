using MediaStore.Infrastructure.Feeds;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Feeds
{
	public sealed partial class TopSpotFeedTemplate : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(TopSpotFeedModel),
		typeof(TopSpotFeedTemplate), null);

		public TopSpotFeedModel ViewModel
		{
			get => (TopSpotFeedModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public TopSpotFeedTemplate()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as TopSpotFeedModel;
			};
		}
	}
}
