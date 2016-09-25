using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace BookEntities
{
    public class Books
    {
      
        public string ID { get; set; }       
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Description { get; set; }
        public Uri imageUri { get; set; }
        public BookCategory bookCategory;

    }

        public class BooksDbContext : DbContext
    {
       public  DbSet <Books> Books { get; set; }
    }
}
