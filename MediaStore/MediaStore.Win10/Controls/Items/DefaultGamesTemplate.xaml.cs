﻿using MediaStore.Infrastructure.Items.Media;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace MediaStore.Win10.Controls.Items
{
	public sealed partial class DefaultGamesTemplate : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModel", typeof(DefaultGamesModel),
		typeof(DefaultGamesTemplate), null);

		public DefaultGamesModel ViewModel
		{
			get => (DefaultGamesModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public DefaultGamesTemplate()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as DefaultGamesModel;
			};
		}

		private void OnDefaultGamesPointerEntered(object sender, PointerRoutedEventArgs e)
		{
			PointerEnteredStoryboard.Begin();
		}

		private void OnDefaultGamesPointerExited(object sender, PointerRoutedEventArgs e)
		{
			PointerExitedStoryboard.Begin();
		}
	}
}
