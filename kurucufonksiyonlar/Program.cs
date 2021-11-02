using System;

namespace kurucufonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
                //SINIF KAVRAMI = Sınıfları nesneye yönelik programlamanın en temel öğesi olarak düşünebiliriz. C# yüzde yüz nesneye yönelik bir programlama dilidir.
            //Kodu tek sınıfın ve ya tek metotun içiresinde yazmak yerine ayrı ayrı her biri farklı işlevleri yerine getirem metotlar kullanarak yazmak daha doğru bir yaklaşımdır.
        //  Örnek Söz Dizimi
        //  class sinif adi   
        //  {
        //  [Erişim Belirteci] [Veri Tipi] Özellik Adı                           =>Property Tanımı       
        //  [Erişim Belirteci]  [Geri dönüş tipi] metotadi(parametre listesi)    =>Metot Tanımı
        //   {  
        //    metot komutları
        //   }
        //
        //   Not: Metot adını düzgün tanımlamak oldukca önemlidir,isminden metodun ne yaptığını bizim anlayabilmemiz gereki

        //Erişim Belirteçleri
        // Public = Her yerden erişilebilir.   
        // Private = Sadece tanımlandığı sınıf içerisinde erişilebilen erişilebilir. 
        // Internal = Sadece kendi bulunduğı proje içerisinde erişilebilir.
        // Protected = Sadece tanımlandığı sınıfta ya da o sınıftan kalıtım alan diğer sınıflardan erişilebilir.
        
        

        Calisan calisan3=new Calisan("Ozan","Aydın",21,"IT");
        calisan3.calisanbilgileri();

        Calisan calisan4=new Calisan("Emre","Kaya");
        calisan4.calisanbilgileri();     //Burada diğer iki değeri boş çevirecek. String ise null,int ise 0,boolen ise false atıyor.
            
        }
            
    }
    class Calisan {
      public string Ad;
      public string Soyad;
      public int No;
      public string Departman;

      public Calisan (string ad,string soyad,int no,string departman) {  //Daha okunabilir,daha basit.
        
        this.Ad=ad;
        this.Soyad=soyad;
        this.No=no;
        this.Departman=departman;
      }

      public Calisan (string ad,string soyad) {  //Daha okunabilir,daha basit.
        
        this.Ad=ad;
        this.Soyad=soyad;
       
      }

      public void calisanbilgileri() {
      Console.WriteLine("Çalışan Adı= "+Ad);   
      Console.WriteLine("Çalışan Soyad= "+Soyad);
      Console.WriteLine("Çalışan No= "+No); 
      Console.WriteLine("Çalışan Departmanı= "+Departman);   //Şimdi diğer klasta bu metotu kullanmak istediğimiz için bir örnek bir instance oluşturacağız. 
        }
    }
}

//Kurucu metotlar new komutu ile bir sınıfın nesnesi oluşturulduğunda arka planda otomatik çalışan metotlardır.
//Aynı zamanda yapıcı metotlar ve ya constructorlar olarak adlandırılırlar.
//Kurucu metodun adı sınıf adı ile aynı olmak zorundadır.Mesela yukarıda sınıf adım Calisan bu yüzden kurucu metot adımda Calisan olmalıdır.
//Erişim belirteçleri muhakkak public olmak zorundadır.
//Kurucu metotların geri dönüş tipi yoktur,boş ve ya void olarak düşünmemeliyiz direk yoktur.
