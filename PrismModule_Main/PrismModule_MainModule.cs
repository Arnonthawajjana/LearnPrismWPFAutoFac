using Prism.Modularity;
using Prism.Regions;
using PrismModule_Main.Views;
using System;
using PrismAutofacApp.Infrastructure;

namespace PrismModule_Main
{
    public class PrismModule_MainModule : IModule
    {
        IRegionManager _regionManager;

        public PrismModule_MainModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion(RegionNames.ToolbarRegion, typeof(PrismToolbar));
            _regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(PrismContent));
        }
    }
}