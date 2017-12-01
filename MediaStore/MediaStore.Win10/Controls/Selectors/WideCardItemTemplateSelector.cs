using MediaStore.Infrastructure.Items.WideCard;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Selectors
{
	public class WideCardItemTemplateSelector : DataTemplateSelector
	{
		public DataTemplate WideCardActorTemplate { get; set; }

		protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
		{
			if (item is WideCardActorModel)
			{
				return WideCardActorTemplate;
			}

			return null;
		}
	}
}
