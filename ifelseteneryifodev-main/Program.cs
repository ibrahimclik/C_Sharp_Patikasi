using System;

namespace ifelsealıştırma
{
    class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.Hour<=18)
            
            { 
                Console.WriteLine("İyi Günler");   
            
             }

            else if (DateTime.Now.Hour <=11 && DateTime.Now.Hour >=06)
            
            { 
                Console.WriteLine("Günaydın");
                 }

            else 

            { 
                Console.WriteLine("İyi Geceler"); 
                } 
            
            //Burada aynı işlemi yapan kodu farklı bir şekilde de yazabilir.
              

            //Sadece iki durum olan için

            string sonuc1=DateTime.Now.Hour <=18 ? "iyi Günler":"İyi Geceler";
            Console.WriteLine(sonuc1);
            
            //İkiden fazla durum için.

            string sonuc=DateTime.Now.Hour >=06 && DateTime.Now.Hour <=11 ? "Günaydın" :DateTime.Now.Hour>=18 ? "İyi Geceler":"İyi Günler";
            Console.WriteLine(sonuc);
        }
    }
}
