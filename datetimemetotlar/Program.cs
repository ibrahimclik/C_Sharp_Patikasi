using System;

namespace datetimemetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //çıktı tarih ve saat
            Console.WriteLine(DateTime.Now.Date); //çıktı sadece tarih saat görmezden gelindi.
            Console.WriteLine(DateTime.Now.Day); //çıktı gün = 22
            Console.WriteLine(DateTime.Now.Month); // çıktı ay = 10
            Console.WriteLine(DateTime.Now.Year);  //çıktı yıl = 2021
            Console.WriteLine(DateTime.Now.Hour);  //çıktı saat = 16
            Console.WriteLine(DateTime.Now.Minute); //çıktı dakika = 40
            Console.WriteLine(DateTime.Now.Second); //çıktı saniye = 10

            Console.WriteLine(DateTime.Now.DayOfWeek); //haftanın gününü string olarak verecek.
            Console.WriteLine(DateTime.Now.DayOfYear); //yılın gününü string olarak verecek.
            
            Console.WriteLine(DateTime.Now.ToLongDateString()); 
            Console.WriteLine(DateTime.Now.ToShortDateString());  //Arada format farkı var.
            Console.WriteLine(DateTime.Now.ToLongTimeString());  // çıktı 16.50.41
            Console.WriteLine(DateTime.Now.ToShortTimeString());  // çıktı 16.50

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //DateTime Format
            
            Console.WriteLine(DateTime.Now.ToString("dd")); //22
            Console.WriteLine(DateTime.Now.ToString("ddd")); //string karşılığını üç karakter olarak getirir = cum
            Console.WriteLine(DateTime.Now.ToString("dddd")); // çıktı = cuma
            
            Console.WriteLine(DateTime.Now.ToString("MM")); //10
            Console.WriteLine(DateTime.Now.ToString("MMM")); //string karşılığını üç karakter olarak getirir = eki
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // çıktı = friday
            
            Console.WriteLine(DateTime.Now.ToString("yy")); //21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // çıktı = 2021
            
            //MATH KÜTÜPHANESİ

            Console.WriteLine(Math.Abs(-25)); //25
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            //Alttaki üçlü double ya float gibi küsuratlı şeylerde çalışır.                            
            Console.WriteLine(Math.Ceiling(22.3));
            Console.WriteLine(Math.Round(22.7));
            Console.WriteLine(Math.Round(22.1));
            Console.WriteLine(Math.Round(22.5));
            Console.WriteLine(Math.Floor(22.3));

            Console.WriteLine(Math.Max(2,6));  //Çıktı 6.
            Console.WriteLine(Math.Min(2,6));  //Çıktı 2.
            
            Console.WriteLine(Math.Pow(2,6)); //2 üzeri 6
            Console.WriteLine(Math.Sqrt(16));  //çıktı 4
            Console.WriteLine(Math.Log(6));  
            Console.WriteLine(Math.Exp(3));
            Console.WriteLine(Math.Log10(10));
        }
    }
}
