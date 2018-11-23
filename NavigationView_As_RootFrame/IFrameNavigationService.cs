using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace NavigationView_As_RootFrame
{
    /// <summary>
    /// Предоставляет метод для навигаций фрейма который находится в NavigationView
    /// </summary>
    public interface IFrameNavigationService
    {
        /// <summary>
        /// Делает навигацию на страницу 
        /// </summary>
        /// <param name="frame">
        /// Фрейм который делает навигацию
        /// </param>
        /// <param name="page">
        /// Страница на которую нужно сделать навигацию
        /// </param>
        void NavigateTo(Frame frame,Type page);
    }
}
