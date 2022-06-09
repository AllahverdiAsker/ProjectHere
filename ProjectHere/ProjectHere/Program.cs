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
            Journal journal1 = new Journal
            {
                Company = "City",
                Name = "Home"
            };

            Product[] products = { book1, book2 };
            Library library = new Library
            {
                products = products

            };
            library.GetBooksCount();

            Product[] myProducts =  library.BorJ(false);
            foreach (var item in myProducts)
            {
                Console.WriteLine(item.Name);
            }


        }
    }
}
