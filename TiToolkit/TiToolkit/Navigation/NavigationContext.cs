using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TiToolkit.Navigation
{
    public static class NavigationContext
    {
        private static MasterDetailPage _shell;

        public static void Initialize(MasterDetailPage shell)
        {
            _shell = shell;
        }

        public static void NavigateTo(Type pageType, Dictionary<string, object> navigationParameters)
        {
            var page = Activator.CreateInstance(pageType) as Page;
            var navigationPage = page as INavigationPage;
            if (navigationPage != null)
            {
                navigationPage.OnNavigatedTo(navigationParameters);
            }
            _shell.Detail = page;
        }
    }
}