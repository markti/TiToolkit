using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiToolkit.Navigation
{
    public interface INavigationPage
    {
        void OnNavigatedTo(Dictionary<string, object> navigationParameters);
    }
}