using MediaStore.Infrastructure.Feeds;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Feeds
{
	public sealed partial class WideCardsFeedTemplate : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(WideCardsFeedModel),
		typeof(WideCardsFeedTemplate), null);

		public WideCardsFeedModel ViewModel
		{
			get => (WideCardsFeedModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public WideCardsFeedTemplate()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as WideCardsFeedModel;
			};
		}
	}
}
