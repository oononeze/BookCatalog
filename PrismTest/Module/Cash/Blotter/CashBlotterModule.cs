using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;


namespace Blotter
{
   public class CashBlotterModule : IModule
    {
        private readonly IRegionViewRegistry regionViewRegistry = null;

        public CashBlotterModule(IRegionViewRegistry regionViewRegistry)
        {
            this.regionViewRegistry = regionViewRegistry;
        }
        public void Initialize()
        {
          //  regionViewRegistry.RegisterViewWithRegion("BlotterRegion", typeof(Views.CashBlotterView));
            regionViewRegistry.RegisterViewWithRegion("AlertRegion", typeof(Views.viewcheck));
        }
    }
}
