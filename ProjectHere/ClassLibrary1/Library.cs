using System;

namespace ClassLibrary1
{
    public class Library
    {

        public Product[] products = new Product[0];
        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;

        }


        public int GetJournalsCount()
        {
            var count = 0;

            foreach (var item in products)
            {

                if (item is Journal)
                {
                    count++;
                }

            }
            return count;
        }
        public int GetBooksCount()
        {
            var count2 = 0;

            foreach (var item in products)
            {

                if (item is Book)
                {
                    count2++;
                    
                }
               
            }
            Console.WriteLine(count2);
            return count2;
        }

        public void BookorJournal(Product isBook)
        {
            Product[] onlybooks = new Product[0];
            Product[] onlyjournals = new Product[0];

            if (isBook is Book)
            {
                Array.Resize(ref onlybooks, onlybooks.Length + 1);
                onlybooks[onlybooks.Length - 1] = isBook;
            }

            else if (isBook is Journal)
            {
                Array.Resize(ref onlybooks, onlybooks.Length + 1);
                onlyjournals[onlyjournals.Length - 1] = isBook;

            }
            else
            {
                Console.WriteLine("No info found");
            }


        }
    }
}
