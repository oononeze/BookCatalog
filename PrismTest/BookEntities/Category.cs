using System.Collections.ObjectModel;
using System.Data.Entity;

namespace BookEntities
{

    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ObservableCollection<Books> books { get; set; }
    }

    public class CategoryDbContext : DbContext
    {
        public DbSet<Category> categories { get; set; }
    }
        

        
}
