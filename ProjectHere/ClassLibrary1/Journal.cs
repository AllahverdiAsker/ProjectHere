using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
   public class Journal : Product
    {

        public string Company;
        public override void GetInfo()
        {
            Console.WriteLine($"Name: {Name} ");
        }


    }
}
