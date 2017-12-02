using MediaStore.Infrastructure.Feeds;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Feeds
{
	public sealed partial class GamesFeedTemplate : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(GamesFeedModel),
		typeof(GamesFeedTemplate), null);

		public GamesFeedModel ViewModel
		{
			get => (GamesFeedModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public GamesFeedTemplate()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as GamesFeedModel;
			};
		}
	}
}
