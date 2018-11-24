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
        INavigationService navigationService;
        public ShellViewModel()
        {
            navigationService = WindowWrapper.Current().NavigationServices.FirstOrDefault();
        }

        public void OnSelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            NavigationViewItem selectedItem = ((NavigationViewItem)args.SelectedItem);
            switch (selectedItem.Tag)
            {
                case "FirstPage":
                    NavigationService.Navigate(typeof(FirstPage));
                    break;
                case "SecondPage":
                    NavigationService.Navigate(typeof(SecondPage));
                    break;
            }
        }
    }
}
