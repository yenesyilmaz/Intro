using System;

namespace Dongulerr
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi  

            string[] kurslar = new string[] { 
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Giriş Kampı",
                "Java",
                "Python"
            };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");




            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            
            
            Console.WriteLine("Sayfa Sonu");
        }
    }
}
