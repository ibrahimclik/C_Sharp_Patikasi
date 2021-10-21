using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Değişken Tanımlanırken dikkat edilmesi gerekenler;
            // 1  Her zaman değeri olmaz zorunda.(Değer yoksa null atanabilir.)
            // 2  Değişken isimleri büyük ve küçük harf duyarlıdır.
            // 3  Değişken adları rakamla başlayamaz.
            // 4  Özel isimler verilemez.
            // 5  Aynı kod bloğu içerinde bir değişken birden fazla tanımlanamaz. 
            // 6  İsimde sadece _ kullanılabilir.

            int deger=2; // 2 Değerini integar olarak atadık.
            string degiske=null;
            string Degiske=null; //İki farklı string,büyük ve küçük harf duyarlı.
            
            //DEĞİŞKEN TİPLERİ.

            string degisken=null;
            byte b=5;  //Değeri 5 olan bir byte tanımladım. (0-255 arası)
            sbyte c=5;  //Bellekte 1 byte yer kaplar.     (-128 - 127 arası)
            short d=5;  // Bellekte 2 byte yer kaplar. ( -32768 - +32768)
            ushort us=5; //Bellekte 2 byte yer kaplar (0 - 65365)

            //İNTEGERLAR

            Int16 i16=2; // 2 Byte yer kaplar.
            int i=2;     // 4 Byte.
            Int32 i32=2; //4 Byte.
            Int64 i64=2; //8 Byte.
            uint ui=2;   //4 Byte.
            long l=4;    //8 Byte.
            ulong ul=4;  //8 Byte,long ile aynı fakat negatif değer almıyor.
            
            //REEL SAYILAR

            double dl=5;  //8 Byte
            float f=5;    //4 Byte.
            decimal de=5; //16 Byte. 

            char ch='2';  //2 Byte,tek karakter için.
            string st="halilibrahim";  //Sınırsız.

            bool b1=true;
            bool b2=false;  //True,false değerleri tutarlar.

            datetime dt=datetime.now;
            Console.WriteLine(dt);

            //OBJECTS

            object o1="x";
            object o2='y';
            object o3=4;
            object o4=4.3; //Objelerim içerisinde veri tipinden bağımsız bir şeyler tutabiliriz.

            //Stringler

            string str1="";
            string str2=null;
            string str3=string.Empty;
            string ad="ibrahim";
            string soyad="çelik";
            string tamisim=ad + " " + soyad;

            //ıntegerlar

            int integer1=5;
            int integer2=3;
            int integer3=integer1*integer2;

            //boolen

            bool bool1=10<2; //Bu ifade false değer verecek.

            //Değişken Dönüşümleri

            string str20="20";
            int int20=20;

            string yenideger=str20+int20.Tostring();
            Console.WriteLine(yenideger);  //Çıktı 2020

            int int21=int20 + Convert.Toınt32(str20);
            Console.WriteLine(int21);   //Çıktı 40
            
            //Datetime

            string datetime=Datetime.now.Tostring("dd.MM.yyyy");
            Console.WriteLine(datetime);  //Çıktı 10.10.2021

            string datetime2=Datetime.now.Tostring("dd/MM/yyyy");
            Console.WriteLine(datetime2);  //Çıktı 10/10/2021
            



            //The End.





        






        }
    }
}
