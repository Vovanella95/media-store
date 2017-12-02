using MediaStore.Infrastructure.Items.Games;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Selectors
{
	public class GamesItemTemplateSelector : DataTemplateSelector
	{
		public DataTemplate DefaultGamesTemplate { get; set; }

		protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
		{
			if (item is DefaultGamesModel)
			{
				return DefaultGamesTemplate;
			}

			return null;
		}
	}
}
