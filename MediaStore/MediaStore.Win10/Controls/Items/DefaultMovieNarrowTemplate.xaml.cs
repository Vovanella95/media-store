using MediaStore.Infrastructure.Items.Media;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace MediaStore.Win10.Controls.Items
{
	public sealed partial class DefaultMovieNarrowTemplate : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(DefaultMovieModel),
		typeof(DefaultMovieNarrowTemplate), null);

		public DefaultMovieModel ViewModel
		{
			get => (DefaultMovieModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public DefaultMovieNarrowTemplate()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as DefaultMovieModel;
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
