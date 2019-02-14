using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleA.ViewModels
{
    public class ViewA1ViewModel : BindableBase, INavigationAware, IRegionMemberLifetime
    {
        bool IRegionMemberLifetime.KeepAlive => true;

        bool INavigationAware.IsNavigationTarget(NavigationContext navigationContext)
        {
           return true;
        }

        void INavigationAware.OnNavigatedFrom(NavigationContext navigationContext)
        {
            //navigationContext.NavigationService.Region.RemoveAll();
        }

        void INavigationAware.OnNavigatedTo(NavigationContext navigationContext)
        {
            //throw new NotImplementedException();
        }
    }
}
