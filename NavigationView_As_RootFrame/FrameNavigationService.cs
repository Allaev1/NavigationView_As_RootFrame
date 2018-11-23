using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace NavigationView_As_RootFrame
{
    public class FrameNavigationService : IFrameNavigationService
    {
        public void NavigateTo(Frame frame, Type page)
        {
            frame.Navigate(page.GetType()); //TODO: Возникает исключение Attempted to read or write protected memory. This is often an indication that other memory is corrupt.'
        }
    }
}
