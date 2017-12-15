using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MediaStore.Win10.ViewModels.Feeds;

namespace MediaStore.Win10.Controls.Selectors
{
	public class FeedsItemTemplateSelector : DataTemplateSelector
	{
		public DataTemplate WideCardsFeedTemplate { get; set; }
		public DataTemplate GamesFeedTemplate { get; set; }
		public DataTemplate TopSpotFeedTemplate { get; set; }
		public DataTemplate CollectionFeedTemplate { get; set; }
		public DataTemplate VideoFeedTemplate { get; set; }

		protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
		{
			if (item is GamesFeedViewModel)
			{
				return GamesFeedTemplate;
			}

			if(item is WideCardFeedViewModel)
			{
				return WideCardsFeedTemplate;
			}

			if(item is TopSpotFeedViewModel)
			{
				return TopSpotFeedTemplate;
			}

			if(item is CollectionFeedViewModel)
			{
				return CollectionFeedTemplate;
			}

			if(item is VideosFeedViewModel)
			{
				return VideoFeedTemplate;
			}

			return null;
		}
	}
}
