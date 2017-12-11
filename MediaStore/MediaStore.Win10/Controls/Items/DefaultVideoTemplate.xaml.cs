using MediaStore.Infrastructure.Items.Video;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Items
{
	public sealed partial class DefaultVideoTemplate : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(DefaultVideoModel),
		typeof(DefaultVideoTemplate), null);

		public DefaultVideoModel ViewModel
		{
			get => (DefaultVideoModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public DefaultVideoTemplate()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as DefaultVideoModel;
			};
		}
	}
}
