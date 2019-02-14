using System;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : BindableBase, INavigationAware, IRegionMemberLifetime
    {
        RegionManager _regionManager;
        public ViewAViewModel(RegionManager regionManager)
        {
            _regionManager = regionManager;

            GoToView1Command = new DelegateCommand(GoToView1);
            GoToView2Command = new DelegateCommand(GoToView2);
        }

        public DelegateCommand GoToView1Command { get; set; }
        private void GoToView1()
        {
            _regionManager.RequestNavigate("RegionA", "ViewA");
            _regionManager.RequestNavigate("RegionA12", "ViewA1");
        }

        public DelegateCommand GoToView2Command { get; set; }
        private void GoToView2()
        {
            _regionManager.RequestNavigate("RegionA", "ViewA");

            _regionManager.RequestNavigate("RegionA12", "ViewA2");
        }


        bool IRegionMemberLifetime.KeepAlive => true;

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            
        }

    }
}
