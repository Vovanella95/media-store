using MediaStore.Infrastructure.Items.Media;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace MediaStore.Win10.Controls.Items
{
    public sealed partial class CollectionDefaultSeriesTemplate : UserControl
    {
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(DefaultSeriesModel),
		typeof(DefaultSeriesTemplate), null);

		public DefaultSeriesModel ViewModel
		{
			get => (DefaultSeriesModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public CollectionDefaultSeriesTemplate()
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
