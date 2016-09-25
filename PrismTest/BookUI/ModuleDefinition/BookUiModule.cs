using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace BookUI.ModuleDefinition
{
   public class BookUiModule : IModule
    {
        IRegionManager regionManager;

        public BookUiModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("CategorySelectRegion", typeof(Views.BookView));
            regionManager.RegisterViewWithRegion("BookDetailsRegion", typeof(Views.BookDetails));
            regionManager.RegisterViewWithRegion("AdminRegion", typeof(Views.Admin));
        }
    }
}
