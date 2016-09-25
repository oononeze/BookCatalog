using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismUi.ModuleDefinition
{
    public class Module : IModule
    {
        IRegionManager regionManager;
        
        public Module(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("CategorySelectRegion", typeof(Views.PrismView));
        }
    }
}
