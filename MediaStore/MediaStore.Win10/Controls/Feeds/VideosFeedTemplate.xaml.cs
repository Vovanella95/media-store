using MediaStore.Infrastructure.Items.Video;
using MediaStore.Win10.ViewModels.Feeds;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Feeds
{
	public sealed partial class VideosFeedTemplate : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(VideosFeedViewModel),
		typeof(VideosFeedTemplate), null);

		public VideosFeedViewModel ViewModel
		{
			get => (VideosFeedViewModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public VideosFeedTemplate()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as VideosFeedViewModel;
			};
		}

		private void OnSwimmingLaneItemClick(object sender, ItemClickEventArgs e)
		{
			ViewModel.NavigateToDetails(e.ClickedItem as VideoModelBase);
		}
	}
}
