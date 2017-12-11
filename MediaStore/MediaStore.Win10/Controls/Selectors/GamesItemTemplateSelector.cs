using MediaStore.Infrastructure.Items.Media;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Selectors
{
	public class GamesItemTemplateSelector : DataTemplateSelector
	{
		public DataTemplate DefaultGamesTemplate { get; set; }
		public DataTemplate DefaultSeriesTemplate { get; set; }

		protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
		{
			if (item is DefaultGamesModel)
			{
				return DefaultGamesTemplate;
			}

			if(item is DefaultSeriesModel)
			{
				return DefaultSeriesTemplate;
			}

			return null;
		}
	}
}
