using MediaStore.Infrastructure.Feeds;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Feeds
{
	public sealed partial class CollectionFeedTemplate : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(CollectionFeedModel),
		typeof(CollectionFeedTemplate), null);

		public CollectionFeedModel ViewModel
		{
			get => (CollectionFeedModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public CollectionFeedTemplate()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as CollectionFeedModel;
			};
		}
	}
}
