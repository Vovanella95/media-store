using MediaStore.Win10.ViewModels.Feeds;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Feeds
{
	public sealed partial class WideCardsFeedTemplate : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(WideCardFeedViewModel),
		typeof(WideCardsFeedTemplate), null);

		public WideCardFeedViewModel ViewModel
		{
			get => (WideCardFeedViewModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public WideCardsFeedTemplate()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as WideCardFeedViewModel;
			};
		}
	}
}
