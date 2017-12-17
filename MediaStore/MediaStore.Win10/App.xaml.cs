using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Controls;
using Caliburn.Micro;
using MediaStore.Win10.ViewModels;
using MediaStore.Win10.Views;
using MediaStore.Infrastructure.Interfaces;
using MediaStore.Services;
using MediaStore.Win10.Common;
using MediaStore.Win10.ViewModels.TitleCards;

namespace MediaStore.Win10
{
	public sealed partial class App
	{
		private WinRTContainer container;

		public App()
		{
			Initialize();
			InitializeComponent();
		}

		protected override void Configure()
		{
			container = new WinRTContainer();

			container.RegisterWinRTServices();

			container.Singleton<ILayoutService, LayoutService>();
			container.Singleton<INavigationManager, NavigationManager>();
			container.Singleton<GenericFeedsViewModelFactory>();

			container.PerRequest<FeedsViewModel>();
			container.PerRequest<ShellViewModel>();
			container.PerRequest<TitleCardViewModel>();
			container.PerRequest<MediaDetailsViewModel>();
		}

		protected override void PrepareViewFirst(Frame rootFrame)
		{
			container.RegisterNavigationService(rootFrame);
		}

		protected override void OnLaunched(LaunchActivatedEventArgs args)
		{
			if (args.PreviousExecutionState == ApplicationExecutionState.Running)
				return;

			DisplayRootView<ShellView>();
		}

		protected override object GetInstance(Type service, string key)
		{
			return container.GetInstance(service, key);
		}

		protected override IEnumerable<object> GetAllInstances(Type service)
		{
			return container.GetAllInstances(service);
		}

		protected override void BuildUp(object instance)
		{
			container.BuildUp(instance);
		}
	}
}
