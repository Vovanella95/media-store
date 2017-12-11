using MediaStore.Infrastructure.Feeds;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Feeds
{
	public sealed partial class VideosFeedTemplate : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(VideoCollectionFeedModel),
		typeof(VideosFeedTemplate), null);

		public VideoCollectionFeedModel ViewModel
		{
			get => (VideoCollectionFeedModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public VideosFeedTemplate()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as VideoCollectionFeedModel;
			};
		}
	}
}
