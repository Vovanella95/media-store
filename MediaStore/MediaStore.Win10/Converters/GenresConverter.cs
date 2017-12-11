using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Data;

namespace MediaStore.Win10.Converters
{
	public class GenresConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			var genres = value as IEnumerable<string>;
			return value == null? null : string.Join((parameter as string) ?? " • ", genres);
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotImplementedException();
		}
	}
}
