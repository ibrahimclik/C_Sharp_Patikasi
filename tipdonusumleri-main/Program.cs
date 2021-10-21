using System;

namespace tipdonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //IMPLICIT CONVERSION 
            //Bu dönüşümler veri tipleri kendi kapasitesinden daha büyük kapasiteye sahip bir veri tipine dönüştürülürken kullanılır.
            //Bunları program otomatik olarak yapar.

            byte a=5;
            sbyte b=30;
            short c=10;

            int d=a+b+c;
            Console.WriteLine("d="+d); //Çıktı 45.

            long h=d;
            Console.WriteLine("h="+h); //Çıktı 45.
            
            float i=h;
            Console.WriteLine("i="+i); //Çıktı 45.
            
            string e="ibrahim";  
            char f='k';
            object g=e+f+d;

            Console.WriteLine("g"+g); //Çıktı gibrahimk45.


            //EXPLICIT CONVERSION
            //C#'ta bizim komutlarla yaptığımız dönüşümler.

            int x=4;
            byte y=(byte)x; 
            Console.WriteLine("y="+y);  //Çıktı 4.

            int z=100;
            byte t=(byte)z;
            Console.WriteLine("t="+t);  //Çıktı 100.
             
            float w=10.3f;
            byte v=(byte)w;
            Console.WriteLine("v="+v);  //Çıktı 10.

            //ToString Methodu

            int xx=6;
            string yy=xx.ToString();
            Console.WriteLine(yy);    //Çıktı 6.

            string zz=12.5f.ToString();
            Console.WriteLine("zz:"+zz);  //Çıktı 12.5.


            //System.Convert

            string s1="10",s2="20";
            int sayi1,sayi2;
            int toplam;

            sayi1=Convert.ToInt32(s1);
            sayi2=Convert.ToInt32(s2);
            toplam=sayi1+sayi2;

            Console.WriteLine("toplam="+toplam);  //Çıktı toplam=30.

            //Parse

            ParseMethod();

        }

        public static void ParseMethod()
        {
           string metin1="10";
           string metin2="10.25";
           int rakam1;
           double double1;

           rakam1=Int32.Parse(metin1); 
           double1=double.Parse(metin2);

           Console.WriteLine(rakam1);   //Çıktı 10.
           Console.WriteLine(double1);  //Çıktı 1025;
        }
    }   
}
//The End.  