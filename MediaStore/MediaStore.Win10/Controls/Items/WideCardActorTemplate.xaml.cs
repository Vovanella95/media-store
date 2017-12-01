using MediaStore.Infrastructure.Items.WideCard;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Controls.Items
{
	public sealed partial class WideCardActorTemplate : UserControl
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(WideCardActorModel),
		typeof(WideCardActorTemplate), null);

		public WideCardActorModel ViewModel
		{
			get => (WideCardActorModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public WideCardActorTemplate()
		{
			InitializeComponent();

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as WideCardActorModel;
			};
		}
	}
}
