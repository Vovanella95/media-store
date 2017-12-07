using MediaStore.Infrastructure.Items.TopSpot;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Items
{
	public sealed partial class TopSpotGameTemplate : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(TopSpotGameModel),
		typeof(TopSpotGameTemplate), null);

		public TopSpotGameModel ViewModel
		{
			get => (TopSpotGameModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}
		public TopSpotGameTemplate()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as TopSpotGameModel;
			};
		}

		private void OnTopSpotGameTemplatePointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
		{
			ImageTransform.CenterX = ActualWidth / 2;
			PointerEnteredStoryboard.Begin();
		}

		private void OnTopSpotGameTemplatePointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
		{
			ImageTransform.CenterX = ActualWidth / 2;
			PointerExitedStoryboard.Begin();
		}
	}
}
