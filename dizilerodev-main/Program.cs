using System;

namespace diziler1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aynı tipteli değişkenleri belllekte arka arkaya tutmak istersek dizileri kullanırız.
            //Dizinin elemanlarının veri tipleri her zaman için aynı olmalıdır.
            //Diziler sıfırıncı indexle başlar.



            //DİZİ TANIMLAMA
            
            string[] günler=new string[7];  //Yedi elemanlı günler isimli bir dizi tanımladık.
            string[] renkler = {"Kırmızı","Mavi","Yeşil","Sarı","Mor"};  //Bu kısımda ise direk elamanları tanımlayarak aynı diziyi oluşturduk.
            string[] hayvanlar={"KEDİ","KÖPEK","MAYMUN","KUŞ"};

            int[] dizi;
            dizi=new int[5];


           //Dizilere Değer Atamak Ve Değişim

           günler[0]="PAZARTESİ"; //Günler dizisinin ilk elemanına pazartesini atamış oldum.
           dizi[3]=10;  //Boş olan dizimizin üçüncü indexteki elemanına 10 değerini atadık;

           Console.WriteLine(hayvanlar[0]);  // Çıktı KEDİ.
           Console.WriteLine(dizi[3]);  // Çıktı 10.
           Console.WriteLine(renkler[0]);  // Çıktı Kırmızı.

           //Diziler Ve Döngüler

           //Klavyeden girilen n tane sayının ortalamasını alan program.

           Console.WriteLine("Dizi uzunluğunu girini0z: ");
           int diziUzunluğu=int.Parse(Console.ReadLine());  //Kullanıcıdan dizinin uzunluğunu aldık.
           int[] sayıdizisi = new int[diziUzunluğu];   

           for (int i = 0; i < diziUzunluğu; i++)
           {
             
              Console.WriteLine("Dizinin "+ (i+1)+". elemanını giriniz ");
              sayıdizisi[i]=int.Parse(Console.ReadLine());

           }
           
           
           int toplam=0;
           foreach (var sayi in sayıdizisi)  //Dizilerde Collection tiplerinde dönmemizi sağlar foreach.
           {
               toplam+=sayi;
            
            }

            Console.WriteLine("Ortalama =" + toplam/diziUzunluğu);   //Burada ortalamayı hesaplayıp çıktı olarak verecek.
        

        }
    }
}
//THE END.