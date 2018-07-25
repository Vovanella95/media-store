using System;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using WinRTXamlToolkit.Controls.Extensions;

namespace MediaStore.Win10.Controls.Custom
{
	public sealed partial class SwimmingLane : UserControl
	{
		private bool _isPointerEntered;

		public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register(
		"ItemsSource", typeof(object),
		typeof(SwimmingLane), null);

		public static readonly DependencyProperty SelectionModeProperty = DependencyProperty.Register(
		"SelectionMode", typeof(ListViewSelectionMode),
		typeof(SwimmingLane), new PropertyMetadata(ListViewSelectionMode.None));

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

		public event EventHandler<ItemClickEventArgs> ItemClick;

		public double PosterHeight
		{
			get => (double)GetValue(PosterHeightProperty);
			set => SetValue(PosterHeightProperty, value);
		}

		public ListViewSelectionMode SelectionMode
		{
			get => (ListViewSelectionMode)GetValue(SelectionModeProperty);
			set => SetValue(SelectionModeProperty, value);
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
			var itemsToScroll = (int)(ActualWidth / itemWidth / 2) + 1;
			return itemsToScroll * itemWidth;
		}

		private void OnLeftArrowTapped(object sender, TappedRoutedEventArgs e)
		{
			_rootScrollViewer.ScrollToHorizontalOffsetWithAnimationAsync(_rootScrollViewer.HorizontalOffset - CalculateWidthToScroll(), 0.5);
		}

		private void OnRootScrollViewerLoaded(object sender, RoutedEventArgs e)
		{
			_rootScrollViewer = (ScrollViewer)sender;
			_rootScrollViewer.ViewChanged += OnScrollViewerViewChanged;
			UpdateArrowsVisibility();
		}

		private void OnScrollViewerViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
		{
			UpdateArrowsVisibility();
		}

		private void UpdateArrowsVisibility()
		{
			if(_isPointerEntered)
			{
				var isLeftArrowAvailable = _rootScrollViewer.HorizontalOffset > 0;
				var isRightArrowAvailable = _rootScrollViewer.HorizontalOffset < _rootScrollViewer.ScrollableWidth;

				LeftArrow.Visibility = isLeftArrowAvailable ? Visibility.Visible : Visibility.Collapsed;
				RightArrow.Visibility = isRightArrowAvailable ? Visibility.Visible : Visibility.Collapsed;
			}
			else
			{
				LeftArrow.Visibility = Visibility.Collapsed;
				RightArrow.Visibility = Visibility.Collapsed;
			}
		}

		private void OnListViewItemClick(object sender, ItemClickEventArgs e)
		{
			ItemClick?.Invoke(this, e);
		}

		private void OnPointerEntered(object sender, PointerRoutedEventArgs e)
		{
			_isPointerEntered = true;
			UpdateArrowsVisibility();
		}

		private void OnPointerExited(object sender, PointerRoutedEventArgs e)
		{
			_isPointerEntered = false;
			UpdateArrowsVisibility();
		}
	}
}
