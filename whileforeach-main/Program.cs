using System;

namespace whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
           
        //1 den başlayarak konsola girilen sayıya kadar olan sayıların toplamının hesaplanması ve çıktı olarak gösterilmesi.
           
           int sayi=int.Parse(Readline());  //Konsoldan alınan sayıyı stringden integera çevirip kullanacak.
           int sayac= 1;
           int toplam;

           while (sayac <=sayi)
           {
             toplam=toplam+sayac;
             sayac++;     
           }
           Console.WriteLine(toplam/sayi);   //5 verirse çıktı olarak 3 verecek.
            
           char character='a';
           while (character <'z')
           
           {
           Console.Write(character);
           character++;     
           }

           Console.WriteLine("******* Foreach **** ");
           string[] arabalar = {"bmw","ford","mercedes","audi"};      
           foreach (var item in arabalar}
           {
               Console.WriteLine(araba);
           }

        }
    }
}
