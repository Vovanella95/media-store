using System;
using Windows.UI.Xaml.Data;

namespace MediaStore.Win10.Converters
{
	public class ParallaxValueConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			var data = (double)value;
			double parallax;
			double.TryParse(parameter as string, out parallax);

			return -(data * (parallax > 0? parallax : 0.4));
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotImplementedException();
		}
	}
}
