using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Template10.Common;
using Template10.Services.NavigationService;
using System.Threading.Tasks;
using NavigationView_As_RootFrame.Views;
using GalaSoft.MvvmLight.Ioc;

namespace NavigationView_As_RootFrame
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : BootStrapper
    {
        private INavigationService navigationService;

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }

        public override UIElement CreateRootElement(IActivatedEventArgs e)
        {
            navigationService = NavigationServiceFactory(BackButton.Attach, ExistingContent.Include);

            return new Shell();
        }

        public override Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            SimpleIoc.Default.Register<ShellViewModel>();

            navigationService.Navigate(typeof(FirstPage));

            return Task.CompletedTask;
        }

        public override INavigable ResolveForPage(Page page, NavigationService navigationService)
        {
            if (page is Shell)
                return SimpleIoc.Default.GetInstance<ShellViewModel>();
            else
                return base.ResolveForPage(page, navigationService);
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        //protected override void OnLaunched(LaunchActivatedEventArgs e)
        //{
        //    Frame rootFrame = Window.Current.Content as Frame;

        //    // Do not repeat app initialization when the Window already has content,
        //    // just ensure that the window is active
        //    if (rootFrame == null)
        //    {
        //        // Create a Frame to act as the navigation context and navigate to the first page
        //        rootFrame = new Frame();

        //        rootFrame.NavigationFailed += OnNavigationFailed;

        //        if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
        //        {
        //            //TODO: Load state from previously suspended application
        //        }

        //        // Place the frame in the current Window
        //        Window.Current.Content = rootFrame;
        //    }

        //    if (e.PrelaunchActivated == false)
        //    {
        //        if (rootFrame.Content == null)
        //        {
        //            // When the navigation stack isn't restored navigate to the first page,
        //            // configuring the new page by passing required information as a navigation
        //            // parameter
        //            rootFrame.Navigate(typeof(MainPage), e.Arguments);
        //        }
        //        // Ensure the current window is active
        //        Window.Current.Activate();
        //    }
        //}
    }
}
