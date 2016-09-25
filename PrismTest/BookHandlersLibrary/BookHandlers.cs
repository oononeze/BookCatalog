using BookInterfaces;
using System.Linq;

namespace BookEntities
{
    public class BookHandlers :  IBookHandlers
    {
        public void DeleteBook(Books book)
        {
           
        }      

        public Books AddBook(string Category, string Name, string Author, string Publisher)
        {
            //var result = from x in bookCategoryList
            //             where x.Name == Category
            //             select x;
            //BookCategory category = result as BookCategory;
            //book.Author = Author;
            //book.Name = Name;
            //book.Publisher = Publisher;
            Books book = new Books();
            return book;
        }

        public Books AddBook()
        {
            Books book = new Books();
            return book;
        }
     
    }
}
