using BookEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInterfaces
{
    public interface IBookHandlers
    {
        Books AddBook(string Category, string Name, string Author, string Publisher);
        Books AddBook();
        void DeleteBook(Books book);
       
    }
}
