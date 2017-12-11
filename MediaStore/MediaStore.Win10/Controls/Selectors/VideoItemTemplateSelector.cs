using MediaStore.Infrastructure.Items.Video;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Selectors
{
    public class VideoItemTemplateSelector: DataTemplateSelector
	{
		public DataTemplate DefaultVideoTemplate { get; set; }

		protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
		{
			if (item is DefaultVideoModel)
			{
				return DefaultVideoTemplate;
			}

			return null;
		}
	}
}
