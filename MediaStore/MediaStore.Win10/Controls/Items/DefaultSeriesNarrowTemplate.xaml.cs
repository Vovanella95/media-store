using MediaStore.Infrastructure.Items.Media;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace MediaStore.Win10.Controls.Items
{
	public sealed partial class DefaultSeriesNarrowTemplate : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModel", typeof(DefaultSeriesModel),
		typeof(DefaultSeriesNarrowTemplate), null);

		public DefaultSeriesModel ViewModel
		{
			get => (DefaultSeriesModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public DefaultSeriesNarrowTemplate()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as DefaultSeriesModel;
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
