using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAdapter
{
    class BookData
    {
        public string GetName(string bookId) 
        {
            switch (bookId) 
            {
                case "1": return "Alice in Wonderlands";
                case "2": return "Harry Poter";
                case "3":return "Pod Igoto";

                default: return "";
            }
        }
        public string GetAuthor(string bookId) 
        {
            switch (bookId) 
            {
                case "1": return "Lewis Carroll";
                case "2": return "Joanne Rowling";
                case "3": return "Ivan Vazov";

                default: return "";
            }
        }

        public string GetYear(string bookId) 
        {
            switch (bookId) 
            {
                case "1": return "1865";
                case "2": return "1885";
                case "3": return "1825";
                default: return "";
            }
        }
        public string GetGenre(string bookId)
        {
            switch (bookId)
            {
                case "1": return "Childrens literature";
                case "2": return "Fantasy";
                case "3": return "Historical";
                default:
                    return "";
            }
        }
    }
}
