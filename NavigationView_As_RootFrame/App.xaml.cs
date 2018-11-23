﻿using System;
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
        Frame contentFrame;
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Создает корневой Frame
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public override UIElement CreateRootElement(IActivatedEventArgs e)
        {
            return new Shell();
        }

        /// <summary>
        /// Вызывается при запуске приложения
        /// </summary>
        /// <param name="startKind"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public override Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            //Shell shell = new Shell();
            //var contentFrame = shell.Frame;
            //TODO: Возникает ошибка в строке 50 - Object reference not set to an instance of an object
            //contentFrame.Navigate(typeof(FirstPage)); 
            contentFrame.Navigate(typeof(FirstPage));

            return Task.CompletedTask;
        }
    }
}
