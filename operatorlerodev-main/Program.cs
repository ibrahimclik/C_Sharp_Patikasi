using System;

namespace operatorlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //ATAMA VE İŞLEMLİ ATAMA
            int x=5;
            int y=6;
            y=y+4;
            Console.WriteLine(y);
            y+=4; //Bu ifade ile bir üstteki ifade aynı işlemi yapmakta.(Bu olaya işemli atama denir.)
            Console.WriteLine(y); 
            y=y/2;
            Console.WriteLine(y);
            y/=7;  //Yine bu iki ifade aynı işlemi yapmaktadır.
            Console.WriteLine(y);
            x=x*6;
            Console.WriteLine(x);
            x*=6;
            Console.WriteLine(x);

            //MANTIKSAL OPERATÖRLER(&&,||,!)

            bool başarılı=true;
            bool tamamlanmış=false;

            if(başarılı && tamamlanmış) {
                Console.WriteLine("başarılı ve tamamlanmış");
            }

            if(başarılı || tamamlanmış) {
                Console.WriteLine("en az bir durum sağlanmış");
            }

            if(başarılı && !tamamlanmış) {
                Console.WriteLine("başarılı ve tamamlanmamış");  //Bu if döngüsünün çıktısı; en az bir durum sağlanmış ve başarışı ve tamamlanmış.
                                                                             
            }

            //İLİŞKİSEL OPERATÖRLER
            
            int a=9;
            int b=2;

            bool sonuc=a<b;
            Console.WriteLine(sonuc);  //Çıktı False
            sonuc=a>b;             
            Console.WriteLine(sonuc);  //Çıktı True
            sonuc=b<=a;
            Console.WriteLine(sonuc);  //Çıktı True
            sonuc=b==a;
            Console.WriteLine(sonuc);  //Çıktı False
            sonuc=b!=a;
            Console.WriteLine(sonuc);  //Çıktı True
        
           //ARİTMETİK OPERATÖRLER

           int sayı1=10;
           int sayı2=5;
           int sonuc1=sayı1/sayı2;
           Console.WriteLine(sonuc1);  //Çıktı 2
           sonuc1=sayı1*sayı2;         
           Console.WriteLine(sonuc1);  //Çıktı 50
           sonuc1=sayı1+sayı2;
           Console.WriteLine(sonuc1);  //Çıktı 15
           sonuc1=sayı1++;
           Console.WriteLine(sonuc1);  //Çıktı 11
           
           int sonuc2=117%5;
           Console.WriteLine(sonuc2);  //Çıktı 2

        } 


    }
}
//The End.