using MediaStore.Infrastructure.Items.WideCard;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Items
{
	public sealed partial class WideCardGameTemplate : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(WideCardGameModel),
		typeof(WideCardGameTemplate), null);

		public WideCardGameModel ViewModel
		{
			get => (WideCardGameModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public WideCardGameTemplate()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as WideCardGameModel;
			};
		}
	}
}
