using System;

namespace metotoverloadıng
{
    class Program
    {
        static void Main(string[] args)
        {
            //METOT OVERLOADING
            //Out parametreyi sıklıkla tryparse ile birlikte kullanıyoruz.
            //Bir fonksiyona bir iş yaptırdıktan sonra sonucu bir değere atayıp ve bu değeri daha sonra kullanmak istiyorsak o değeri out parametre olarak verebiliriz.
             
            string sayi="999";
            Metotlar instance=new Metotlar();
            instance.Topla(4,5,out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metot Aşırı Yükleme = Bir fonksiyonun imzasının değiştirilerek birden fazla kullanımı olayıdır.

            bool sonuc =int.TryParse(sayi, out int outsayi);
            if (sonuc)

            {
              Console.WriteLine("Başarılı");
              Console.WriteLine(outsayi);
            } 

            else {
               Console.WriteLine("Başarısız");
            }
            int ifade=999;
            instance.Ekranayazdir(Convert.ToString(ifade));
            instance.Ekranayazdir(ifade);
            instance.Ekranayazdir("iBRAHİM","ÇELİK");
   
        } 
    }
    class Metotlar
    {
       public void Topla(int a, int b, out int toplam)
       {
           toplam=a+b; 
       }
      
       public void Ekranayazdir(string veri)
       {
           Console.WriteLine(veri);
       }

       public void Ekranayazdir(int veri)   //Parametrenin türünü değiştirerek bu metodu aşırı yüklemiş olduk.

       {
         Console.WriteLine(veri);
       }
       
       public void Ekranayazdir(string veri1,string veri2) 

       {
         Console.WriteLine(veri1+veri2);
       }


    }
}

//Metot İmzası = Metot Adı + Parametre Sayısı + Parametre 
//Erişim belirteci ve geri dönüşün türü metot imzasını değiştirmez.