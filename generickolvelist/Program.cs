using System;
using System.Collections.Generic;

namespace generickolvelist
{
    class Program
    {
        static void Main(string[] args)
        {
            //List <T> class
            //System.Collections.Generic  namespace'i altından geliyor ve bu namespace'i kullanmak bize bir çok kullanılabilir metot sunuyor.
            //T >> T bize bunun generic türünde olduğunu söyler,ve türü objecttir.

            List<int> sayiListesi = new List<int>();   //İnteger türünde bir liste oluşturduk.

            sayiListesi.Add(23);   //.Add() komutu listeye eleman eklememizi sağladı.
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi=new List<string>();  //String türünde bir liste oluşturduk.

            renkListesi.Add("Kırmızı");  //Aynı şekilde eleman eklemek için .Add() komutunu kullandık.
            renkListesi.Add("Mavi"); 
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");
            
            //Count = Liste içerisinde ki eleman sayısını verir.

            Console.WriteLine(sayiListesi.Count);   //listeismi.Count komutu sayesinde listedeki eleman sayısını öğrendim.
            Console.WriteLine(renkListesi.Count);
            
            //Elemanları Ekrana Yazdırmak

            foreach(var sayi in sayiListesi)   //Foreach döngü metotuyla liste içerisindeki elemanları ekran yazdırdık.
             Console.WriteLine(sayi);
            
            foreach(var renk in renkListesi)
             Console.WriteLine(renk);
            
            //Alternatif Foreach Metot

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));
            
            //Listeden Eleman Çıkarmak

            sayiListesi.Remove(23);        //.Remove(); komutu ile listeden eleman çıkarabiliriz.
            renkListesi.Remove("Kırmızı");
            
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //İndex üzerinden eleman çıkarmak

            sayiListesi.RemoveAt(0);   //.RemoveAt() komutu ile istediğimiz indexteki elemanı listeden çıkarabiliriz.
            renkListesi.RemoveAt(1);
            
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));   //10 ve Turuncuyu listeden çıkardık.

            //Liste içerisinde arama yapmak

            if(sayiListesi.Contains(34))   //.Contains komutu ile 34 sayısının bu listede olup olmadığını kontrol ettik.
             Console.WriteLine("34 bu listede mevcut");
            
            //Eleman ile indexe erişmek

            Console.WriteLine(sayiListesi.BinarySearch(92));  //.BinarySearch() komutu ile verdiğimiz elemanın indexine ulaşabiliriz.
            
            //Diziyi Listeye Çevirmek

            int[] sayilar={3,5,7,4,55,6};
            List<int> sayiList=new List<int>(sayilar);       //sayilar adında biz dizi oluşturduk ve bu diziyi listeye atadık.

            //List içerisinde nesne tutmak
            
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim="Ayşe";
            kullanıcı1.Soyisim="Yılmaz";
            kullanıcı1.Yas=26;
            
            Kullanıcılar kullanıcı2 =new Kullanıcılar();
            kullanıcı2.Isim="Özcan";
            kullanıcı2.Soyisim="Çalışkan";
            kullanıcı2.Yas=26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();  //Kullanıcılar türünde yeniListe adında yeni bir liste oluşturduk.

            yeniListe.Add(new Kullanıcılar(){
                Isim="Deniz",
                Soyisim="Arda",
                Yas=24

            });
            
            foreach(Kullanıcılar kullanıcı in kullanıcıListesi) {
              Console.WriteLine("Kullanıcı adı "+ kullanıcı.Isim);
              Console.WriteLine("Kullanıcı soyismi "+ kullanıcı.Soyisim);
              Console.WriteLine("Kullanıcı yaşı "+ kullanıcı.Yas);

              kullanıcıListesi.Clear();

            }

        }
    }

    public class Kullanıcılar{     //Kullanıcılar isminde public bir class oluşturduk.

    private string isim;

    private string soyisim;

    private int yas;
    
    public string Isim {get=> isim;set=>isim=value;}

    public string Soyisim {get=> soyisim;set=>soyisim=value;}
    
    public int Yas {get=> yas;set=>yas=value;}   //Burada encapsule etme işlemi yaptık,yani private kısımda ki isim,soyisim ve yas değişkenlerine erişimi engelledik.


    }                   
}
