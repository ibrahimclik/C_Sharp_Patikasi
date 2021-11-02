using System;

namespace sinifkavrami1
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
        
        Calisan calisan1=new Calisan();

        calisan1.ad="İbrahim";
        calisan1.soyad="Çelik";
        calisan1.no=45;
        calisan1.departman="Yazılım";
        
        calisan1.calisanbilgileri();  //Bu kısımda atama yaptığımız bilgileri alıp calisanbilgiler metoduna gönderecek.
        
        Calisan calisan2=new Calisan();
        
        calisan2.ad="İlker";
        calisan2.soyad="Ertürk";
        calisan2.no=31;
        calisan2.departman="Arge";

        calisan2.calisanbilgileri();  //Nesne aracılığıyla hem propertilere hemde metota erişim sağlamış olduk.


        }    
    }
    class Calisan {

      public string ad;

      public string soyad;
      
      public int no;

      public string departman;

      public void calisanbilgileri() {
       
      Console.WriteLine("Çalışan Adı= "+ad);   
  
      Console.WriteLine("Çalışan Soyad= "+soyad);
   
      Console.WriteLine("Çalışan No= "+no); 

      Console.WriteLine("Çalışan Departmanı= "+departman);   //Şimdi diğer klasta bu metotu kullanmak istediğimiz için bir örnek bir instance oluşturacağız. 

      }
    }
} 