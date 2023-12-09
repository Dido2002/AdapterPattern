using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAdapter
{
    class Book : Library   //Adapter
    {
        private BookData data;

        //Constructor 

        public Book(string id) 
            :base (id)  
        {   
            
        }

        public override void Display()
        {
            data = new BookData();

            nameOfBook = data.GetName(BookId);
            author = data.GetAuthor(BookId);
            year = data.GetYear(BookId);
            genre = data.GetGenre(BookId);


            base.Display();
            Console.WriteLine("Name: {0}", nameOfBook);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Year: {0}", year);
            Console.WriteLine("Genre: {0}", genre);
        }
    }
}
