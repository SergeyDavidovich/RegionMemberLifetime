using Microsoft.Practices.Unity;
using ModuleA.Views;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using System;

namespace FirstModuleProject
{
    public class FirstModule : IModule
    {
        IRegionManager _regionManager;
        IUnityContainer _container;

        public FirstModule(RegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }

        public void Initialize()
        {
            _container.RegisterTypeForNavigation<ViewA>();
            _container.RegisterTypeForNavigation<ViewB>();

            _container.RegisterTypeForNavigation<ViewA1>();
            _container.RegisterTypeForNavigation<ViewA2>();

            _regionManager.RequestNavigate("ContentRegion", "ViewA");
        }
    }
}