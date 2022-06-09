using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Book : Product
    {

        public string Author;
        public string Genre;
        public override void GetInfo()
        {
            Console.WriteLine($"Name: {Name} Author: {Author}");
        }


    }
}
