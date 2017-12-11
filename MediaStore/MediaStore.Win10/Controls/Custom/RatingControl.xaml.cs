using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Custom
{
	public sealed partial class RatingControl : UserControl
	{
		private const string EMPTY_STAR = "☆";
		private const string FILLED_STAR = "★";

		public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
		"Value", typeof(object),
		typeof(RatingControl), new PropertyMetadata(default(int), UpdateValueProperty));

		public int Value
		{
			get => (int)GetValue(ValueProperty);
			set => SetValue(ValueProperty, value);
		}

		public RatingControl()
		{
			InitializeComponent();
		}

		private static void UpdateValueProperty(object sender, DependencyPropertyChangedEventArgs e)
		{
			var control = (RatingControl)sender;
			control.RootTextBlock.Text = GenerateStars(control.Value);
		}

		private static string GenerateStars(int value)
		{
			var result = string.Empty;
			for (int i = 0; i < value; i++)
			{
				result += FILLED_STAR;
			}

			for (int i = 0; i < 5 - value; i++)
			{
				result += EMPTY_STAR;
			}

			return result;
		}
	}
}
