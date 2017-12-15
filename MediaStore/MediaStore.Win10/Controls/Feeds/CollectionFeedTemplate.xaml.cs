using MediaStore.Win10.ViewModels.Feeds;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Feeds
{
	public sealed partial class CollectionFeedTemplate : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(CollectionFeedViewModel),
		typeof(CollectionFeedTemplate), null);

		public CollectionFeedViewModel ViewModel
		{
			get => (CollectionFeedViewModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public CollectionFeedTemplate()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as CollectionFeedViewModel;
			};
		}
	}
}
