using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Add(Urun product) 
        {
            Console.WriteLine("Sepete eklendi: " + product.Name);


        }
        

        public void Add2(string name,string explanation, double price, int stock)
        {
            Console.WriteLine("Sepete eklendi: " + name);
        }
    }
}
