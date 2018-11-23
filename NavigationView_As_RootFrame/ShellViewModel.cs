using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template10.Services.NavigationService;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using NavigationView_As_RootFrame.Views;
using Template10.Common;
using Template10.Mvvm;

namespace NavigationView_As_RootFrame
{
    public class ShellViewModel : ViewModelBase
    {
        //INavigationService navigationService; // Закоментирована т.к. не используется навигация от Template10
        //FrameNavigationService frameNavigationService; //Закоментирована т.к. методы класса во время работы генерируют исключения 
        public ShellViewModel()
        {
            //navigationService = WindowWrapper.Current().NavigationServices.FirstOrDefault(); 
            //frameNavigationService = new FrameNavigationService();  
        }

        public void OnSelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            Frame contentFrame = sender.Content as Frame;
            NavigationViewItem selectedItem = ((NavigationViewItem)args.SelectedItem);
            switch (selectedItem.Tag)
            {
                case "FirstPage":
                    contentFrame.Navigate(typeof(FirstPage));
                    //frameNavigationService.NavigateTo(contentFrame, typeof(FirstPage));
                    break;
                case "SecondPage":
                    contentFrame.Navigate(typeof(SecondPage));
                    //frameNavigationService.NavigateTo(contentFrame,typeof(SecondPage));
                    break;
            }
        }
    }
}
