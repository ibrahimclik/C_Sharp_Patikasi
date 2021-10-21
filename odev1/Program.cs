using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ÖDEV 1


            Console.WriteLine("Bir Pozitif Sayı Giriniz");
            int sayi=int.Parse(Console.ReadLine());
        
            Console.WriteLine("Girdiğiniz sayı kadar pozitif giriniz");
            int[] sayilar=new int[sayi];
            for (int i=0;i<sayi;i++)
            {
                sayilar[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Çift Sayılar");
             for(int a=0;a<sayi;a++)
             if(sayilar[a]%2==0)
             Console.WriteLine(sayilar[a]);

        //ÖDEV2


         Console.WriteLine("Bir Pozitif Sayı Giriniz");
            int sayi=int.Parse(Console.ReadLine());
         Console.WriteLine("Bir pozitif sayı daha giriniz");
            int sayi2=int.Parse(Console.ReadLine())
          Console.WriteLine("Girdiğiniz İlk sayı kadar pozitif sayı giriniz");
          int[] sayilar=new int[sayi];
          for (int i=0;i<sayi;i++)
          {
              sayilar[i]=int.Parse(Console.ReadLine());
          }
          Console.WriteLine("İkinci sayıya eşit olanlar ya da tam bölünenler");
           for(int a=0;a<sayi;a++)
           if(sayilar[a]==0 || sayilar[a]%sayi2==0)
            Console.WriteLine(sayilar[a]);    

        
        //ÖDEV 3

         Console.WriteLine("Bir Pozitif Sayı Giriniz");
         int x=int.Parse(Console.ReadLine());        
         Console.WriteLine("Girdiğiniz sayı kadar kelime giriniz");
         string[] kelimeler =new string[x];
         for (int i=0;i<x;i++)
         {
             kelimeler[i]=Console.ReadLine();
         }
         Console.WriteLine("Yazılan Kelimeler\n");
         for (int a=x-1; a>=0; a--)
             Console.WriteLine(kelimeler[a]);


        //ÖDEV 4
        
        Console.WriteLine("Bir Cümle Yazınız"); 
        string cumle=Console.ReadLine();
        string[] array1=cumle.Split(" ");
        int ksayi=array1.Length;
        string bosluksuz=cumle.Replace(" ","");
        int x=bosluksuz.Length;
        Console.WriteLine("Cümle içerisindeki harf sayısı= "+x);
        Console.WriteLine("Cümle İçerisindeki kelime sayısı= "+ksayi);
        }

    }
}
