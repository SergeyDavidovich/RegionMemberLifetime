using Prism.Mvvm;
using Prism.Regions;

namespace ModuleA.ViewModels
{
    public class ViewBViewModel : BindableBase, INavigationAware, IRegionMemberLifetime
    {
        public ViewBViewModel()
        {

        }
        bool IRegionMemberLifetime.KeepAlive => true;
        public bool IsNavigationTarget(NavigationContext navigationContext) => true;
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            
        }
    }
}
