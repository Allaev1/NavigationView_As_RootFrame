using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using NavigationView_As_RootFrame.Views;
using Windows.UI.Xaml;

namespace NavigationView_As_RootFrame
{
    public class FrameNavigationService : IFrameNavigationService
    {
        //public FrameNavigationService(Shell shell = null)
        //{
        //    ContentFrame = shell.ContentFrame;
        //}

        /// <summary>
        /// Назначает фрейм в котором будет происходить навигация
        /// </summary>
        /// <param name="frame"></param>
        public void SetContentFrame(Frame frame)
        {
            _contentFrame = frame;
        }

        static Frame _contentFrame;
        /// <summary>
        /// Фрейм в элементе управления NavigationView
        /// </summary>
        static Frame ContentFrame
        {
            set { _contentFrame = value; }
            get { return _contentFrame; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        public void NavigateTo(Page page)
        {
            ContentFrame.Navigate(page.GetType());
        }
    }
}
