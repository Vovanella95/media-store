using MediaStore.Infrastructure.Items.Media;
using MediaStore.Win10.ViewModels.Feeds;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Feeds
{
	public sealed partial class GamesFeedTemplate : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(GamesFeedViewModel),
		typeof(GamesFeedTemplate), null);

		public GamesFeedViewModel ViewModel
		{
			get => (GamesFeedViewModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public GamesFeedTemplate()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as GamesFeedViewModel;
			};
		}

		private void OnSwimmingLaneItemClick(object sender, ItemClickEventArgs e)
		{
			ViewModel.NavigateToDetails(e.ClickedItem as MediaModelBase);
		}
	}
}
