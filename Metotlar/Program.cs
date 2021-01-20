using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun product1 = new Urun();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Explanation = "Red Apple";

            Urun product2 = new Urun();
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Explanation = "Diyarbakir Watermelon";

            Urun[] products = new Urun[] { product1, product2 };

            foreach (Urun product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("----------------------");

            }

            Console.WriteLine("---------------Metotlar-----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Yeşil Armut", 12, 5);
            sepetManager.Add2("Elma", "Yeşil elma", 12, 3);
            sepetManager.Add2("Karpuz", "Diyarbakır karpuzu", 12, 1);

        }
    }
}
