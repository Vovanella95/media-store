﻿using Windows.UI.Xaml;
using MediaStore.Infrastructure.Feeds;
using Windows.UI.Xaml.Controls;

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
			if (item is WideCardsFeedModel)
			{
				return WideCardsFeedTemplate;
			}

			if (item is GamesFeedModel)
			{
				return GamesFeedTemplate;
			}

			if (item is TopSpotFeedModel)
			{
				return TopSpotFeedTemplate;
			}

			if (item is CollectionFeedModel)
			{
				return CollectionFeedTemplate;
			}

			if(item is VideoCollectionFeedModel)
			{
				return VideoFeedTemplate;
			}

			return null;
		}
	}
}
