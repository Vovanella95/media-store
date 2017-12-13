using System;
using Windows.UI.Xaml.Data;

namespace MediaStore.Win10.Converters
{
	public class DateTimeConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			var formatter = string.IsNullOrEmpty(parameter as string) ? "dd.MM.yyyy" : parameter as string;
			return ((DateTime)value).ToString(formatter);
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotImplementedException();
		}
	}
}
