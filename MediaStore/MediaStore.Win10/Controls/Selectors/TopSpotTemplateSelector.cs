using MediaStore.Infrastructure.Items.TopSpot;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Selectors
{
    public class TopSpotTemplateSelector : DataTemplateSelector
	{
		public DataTemplate TopSpotGameTemplate { get; set; }

		protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
		{
			if (item is TopSpotGameModel)
			{
				return TopSpotGameTemplate;
			}

			return null;
		}
	}
}
