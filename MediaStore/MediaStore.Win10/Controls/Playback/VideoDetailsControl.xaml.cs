using MediaStore.Win10.ViewModels.TitleCards;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
namespace MediaStore.Win10.Controls.Playback
{
	public sealed partial class VideoDetailsControl : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(VideoDetailsViewModel),
		typeof(VideoDetailsViewModel), null);

		public VideoDetailsViewModel ViewModel
		{
			get => (VideoDetailsViewModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public VideoDetailsControl()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as VideoDetailsViewModel;
			};
		}

		public void ClosePlayback()
		{
			ViewModel.Close();
		}
	}

	class MyProperties
	{
		public static readonly DependencyProperty HtmlStringProperty =
		   DependencyProperty.RegisterAttached("HtmlString", typeof(string), typeof(MyProperties), new PropertyMetadata("", OnHtmlStringChanged));

		public static string GetHtmlString(DependencyObject obj) { return (string)obj.GetValue(HtmlStringProperty); }
		public static void SetHtmlString(DependencyObject obj, string value) { obj.SetValue(HtmlStringProperty, value); }

		private static void OnHtmlStringChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			WebView wv = d as WebView;
			if (wv != null && !string.IsNullOrEmpty(e.NewValue as string))
			{
				wv.NavigateToString((string)e.NewValue);
			}
		}
	}
}
