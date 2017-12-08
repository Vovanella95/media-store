using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WinRTXamlToolkit.AwaitableUI;
using WinRTXamlToolkit.Controls.Extensions;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace MediaStore.Win10.Controls.Custom
{
	public sealed partial class SwimmingLane : UserControl
	{
		public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register(
		"ItemsSource", typeof(object),
		typeof(SwimmingLane), null);

		public static readonly DependencyProperty ItemTemplateProperty = DependencyProperty.Register(
		"ItemTemplate", typeof(DataTemplate),
		typeof(SwimmingLane), null);

		public static readonly DependencyProperty ItemContainerStyleProperty = DependencyProperty.Register(
		"ItemContainerStyle", typeof(Style),
		typeof(SwimmingLane), null);

		public static readonly DependencyProperty ItemTemplateSelectorProperty = DependencyProperty.Register(
		"ItemTemplateSelector", typeof(DataTemplateSelector),
		typeof(SwimmingLane), null);

		public static readonly DependencyProperty PosterHeightProperty = DependencyProperty.Register(
		"PosterHeight", typeof(double),
		typeof(SwimmingLane), new PropertyMetadata(double.NaN));

		public double PosterHeight
		{
			get => (double)GetValue(PosterHeightProperty);
			set => SetValue(PosterHeightProperty, value);
		}

		public DataTemplateSelector ItemTemplateSelector
		{
			get => (DataTemplateSelector)GetValue(ItemTemplateSelectorProperty);
			set => SetValue(ItemTemplateSelectorProperty, value);
		}

		public object ItemsSource
		{
			get => GetValue(ItemsSourceProperty);
			set => SetValue(ItemsSourceProperty, value);
		}

		public DataTemplate ItemTemplate
		{
			get => (DataTemplate)GetValue(ItemTemplateProperty);
			set => SetValue(ItemTemplateProperty, value);
		}

		public Style ItemContainerStyle
		{
			get => (Style)GetValue(ItemContainerStyleProperty);
			set => SetValue(ItemContainerStyleProperty, value);
		}

		private ScrollViewer _rootScrollViewer;

		public SwimmingLane()
		{
			InitializeComponent();
		}

		private void OnRightArrowTapped(object sender, TappedRoutedEventArgs e)
		{
			_rootScrollViewer.ScrollToHorizontalOffsetWithAnimationAsync(_rootScrollViewer.HorizontalOffset + CalculateWidthToScroll(), 0.5);
		}

		private double CalculateWidthToScroll()
		{
			var firstItem = RootListView.ItemsPanelRoot.Children.First() as FrameworkElement;
			var itemWidth = firstItem.ActualWidth + firstItem.Margin.Left + firstItem.Margin.Right;
			var itemsToScroll = (int)(ActualWidth / itemWidth / 2);
			return itemsToScroll * itemWidth;
		}

		private void OnLeftArrowTapped(object sender, TappedRoutedEventArgs e)
		{
			_rootScrollViewer.ScrollToHorizontalOffsetWithAnimationAsync(_rootScrollViewer.HorizontalOffset - CalculateWidthToScroll(), 0.5);
		}

		private void OnRootScrollViewerLoaded(object sender, RoutedEventArgs e)
		{
			_rootScrollViewer = (ScrollViewer)sender;
		}
	}
}
