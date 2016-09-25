using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;


namespace BooksUI.ModuleDefinition
{
   public class BookUIModule: IModule
    {

        IRegionManager regionManager;

        public BookUIModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("CategorySelectRegion", typeof(Views.BookView));
            regionManager.RegisterViewWithRegion("BookDetailsRegion", typeof(Views.BookDetailsView));
            regionManager.RegisterViewWithRegion("AdminRegion", typeof(Views.AdminView));
        }
    }
}
