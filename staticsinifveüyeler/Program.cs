using System;

namespace staticsinifveüyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            //STATİK SINIFLAR VE STATİK SINIF ÜYELERİ(Metotlar,Üyeler ve Klaslar)

            //Bir sınıf içerisinde statik olmayan fieldlara,metotlara,özelliklere o sınıftan oluşturduğumuz nesne aracılığı ile erişiyoruz.  
            //Statik olan elemanlara ise(field,metot,özellik) o sınıfın adı ile erişiyoruz.
            //Statik olmayan bir sınıfta o sınıf içerisinde ki statik olmayan elemanlar nesneye özgü iken statik üyeler sınıf bazında atanır.
            //Bir sınıfı statik yaparsak içerisinde bulunan bütün propertiler,metotlar ve fieldlar statik olmak zordundadır.


            Console.WriteLine("Çalışan sayısı   "+ Calisan.CalisanSayisi);
            Calisan calisan1=new Calisan("ibrahim","Çelik","Yazılım");                                  //Sadece kurucu üzerinden ulaşabiliriz.
            Console.WriteLine("Çalışan sayısı   "+ Calisan.CalisanSayisi);   //Statik sınıfa erişmek için isim... ,bana private olan propertyi değil public olanı getirecek.
                        
            //Çalışan sınıfından oluşturduğum her nesne için kurucu çalışır ancak statik olan kurucu yalnızca bir defa çalışır,o da çalışan sınıfına ilk erişimde gerçekleşir.
            
            Calisan calisan2=new Calisan("İlker","Çelik","Yazılım");
            Calisan calisan3=new Calisan("Ali","Yılmaz","Yazılım");
            Calisan calisan4=new Calisan("Ökkeş","Baklavacı","Yazılım");
            Console.WriteLine("Çalışan sayısı   "+ Calisan.CalisanSayisi);
            
            Console.WriteLine("Toplama=  "+işlemler.Topla(25,30));
            Console.WriteLine("Çıkarma=  "+işlemler.Çıkar(27,21));

        }
    }
    
    class Calisan {

    private static int calisanSayisi;   //Private ve statik olan bir değişken(field) tanımladım.
    public static int CalisanSayisi { get => calisanSayisi;  }  //calisansayisini burada encapsule ettim.
    
    private string Isim;               //Bunların propertilerini oluşturmadık artık bu degişkenlere(fieldlara) bu sınıf dışında erişelemeyecek,sadece kurucusunda erişilebilecek.
    private string Soyisim;
    private string Departman;
        
        static Calisan() {               //Burada statik bir kurucu oluşturduk.
        calisanSayisi=0;
        } 



        public Calisan(string ısim, string soyisim, string departman) 
        {
            this.Isim=ısim;            //Bu kısımda atama işlemi gerçekleştirdik.
            this.Soyisim=soyisim;
            this.Departman=departman;
            calisanSayisi++;           //Burada her bir çalışan tanımlandığında bu kurucuya gelinecek ve dolayısıyla çalışan sayısı bir arttırılacak.
        }
     
    }

    static class işlemler {
     
     public static int Topla(int sayi1,int sayi2) {

    return sayi1+sayi2;
    }
    
    public static int Çıkar(int sayi1,int sayi2) {
        return sayi1-sayi2;
    }

    //Statik olduğu için hem metotlar hemde değişkenler statik oldu.
     
    }

}
