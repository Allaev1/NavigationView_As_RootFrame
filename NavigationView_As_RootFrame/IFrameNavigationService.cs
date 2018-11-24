using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace NavigationView_As_RootFrame
{
    //TODO: Нужны ли вообще этот интерфейс ?
    /// <summary>
    /// Предоставляет метод для навигаций фрейма который находится в NavigationView
    /// </summary>
    public interface IFrameNavigationService
    {
        /// <summary>
        /// Делает навигацию на страницу 
        /// </summary>
        /// <param name="page">
        /// Страница на которую нужно сделать навигацию
        /// </param>
        void NavigateTo(Page page);
    }
}
