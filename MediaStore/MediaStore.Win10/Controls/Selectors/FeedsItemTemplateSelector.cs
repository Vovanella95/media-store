﻿using Windows.UI.Xaml;
using MediaStore.Infrastructure.Feeds;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Selectors
{
	public class FeedsItemTemplateSelector : DataTemplateSelector
	{
		public DataTemplate WideCardsFeedTemplate { get; set; }

		protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
		{
			if(item is WideCardsFeedModel)
			{
				return WideCardsFeedTemplate;
			}

			return null;
		}
	}
}