using MediaStore.Infrastructure.Categories;
using MediaStore.Win10.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MediaStore.Win10.Views
{
	public sealed partial class ShellView : Page
	{
		public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
		"ViewModelProperty", typeof(ShellViewModel),
		typeof(ShellView), null);

		public ShellViewModel ViewModel
		{
			get => (ShellViewModel)GetValue(ViewModelProperty);
			set => SetValue(ViewModelProperty, value);
		}

		public ShellView()
		{
			InitializeComponent();

			NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;

			DataContextChanged += (s, e) =>
			{
				ViewModel = DataContext as ShellViewModel;
			};
		}

		private void OnShellFrameLoaded(object sender, RoutedEventArgs e)
		{
			ViewModel.InitializeShellNavigationService(sender as Frame);
		}

		private void OnCategoriesListViewItemClick(object sender, ItemClickEventArgs e)
		{
			ViewModel.SelectCategory(e.ClickedItem as LayoutCategoryModel);
		}
	}
}
