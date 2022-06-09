using System;
using ClassLibrary1;

namespace ProjectHere
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book
            {
                Name = "Life",
                Author = "Hasan",
                Genre = "Love"
                
            };

            Book book2 = new Book
 
              {
               Name = "Money",
               Author = "Mahir",
               Genre = "Action"

               };

            Product[] products = { book1, book2 };
            Library library = new Library
            {
                products = products

            };
            library.GetBooksCount();
            
        }
    }
}
