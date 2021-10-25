using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array Listler içerisinde birden farklı yapı türünü barındırablilirler ve dinamiktirler.
            //system.Collections kütüphanesinde bulunurlar.

            ArrayList liste=new ArrayList();

            //Eleman Atamak
            liste.Add("iBRAHİM");
            liste.Add(5);
            liste.Add(true);
            liste.Add("A");  //.Add() komutu ile arrayliste ekleme yapabiliriz.

            //ArrayList içerisinde ki verilere erişmek

            Console.WriteLine(liste[0]);  //index yöntemi kullanabiliriz.

            foreach(var item in liste)
             Console.WriteLine(item);     //Foreach yöntemi ile erişebiliriz.

            
            //AddRange birden fazla eleman yazmamıza olanak sağlar.
            Console.WriteLine("******ADD RANGE******");

            string[] renkler={"Sarı","Yeşil","Mor","Turuncu"};
            liste.AddRange(renkler);  //.AddRange komutu sayesinde liste adlı arraylistimize renkler arrayini attık.
          
            int[] sayilar={1,8,4,6,12,0,27};
            liste.AddRange(sayilar);

            foreach (var itemler in liste)
            {
                Console.WriteLine(itemler);
            }

            //.Sort(); = Sıralama yapar ancak arraylistin içerisinde hem string hemde integer ifadeler bir arada olduğu durumlarda hata verir.
            //Sıralama yapabilmek için elemanların aynı türde olması gereklidir.
            
            Console.WriteLine("***SORT****");
            //liste.Sort();

            //.BinarySearch();  = Yazdığımız elemanın indexini bize getirir ancak öncesinde sort işlemi yapılması gereklidir.           
            //liste.BinarySearch(8); //Sekizin indexini bize verir.


            //.Reverse();  Elemanların sıralamasını tersine çevirir.
            Console.WriteLine("*****REVERSE****");

            liste.Reverse();
            foreach (var rev in liste)
            {
                Console.WriteLine(rev);
            }
            

            //.Clear = Bu komut arraylistimizin içerisini temizler.
            liste.Clear();
        }
    }
}
