

namespace BooksUI
{
    public class singleton
    {
        public static singleton Current = new singleton();

        private singleton()
        {

        }

        public string username { get; set; }

        public bool loginOk = false;

        public string categoryAddName { get; set;}

        public string BookCategory { get; set; }
    }
}
