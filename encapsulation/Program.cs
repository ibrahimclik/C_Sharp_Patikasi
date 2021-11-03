using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
        //CSharp her zaman bahsettiğimiz üzere nesneye yönelik bir programlama dilidir.(Object Oriented)
        //Bir nesnenin bazı özelliklerini ve ya işlevlerini diğer klaslardan ve nesnelerden koruma işlemine encapsulation denir.
        //Koruma işlemini erişim belirteçleri sayesinde yaparız.
        //Propertiler yardımıyla sınıfın üyelerini kapatabiliriz.
        //Propertiler get ve setlerden oluşurlar.

        Ogrenci ogrenci1=new Ogrenci();
        ogrenci1.Isim="İbrahim";         //Burada ogrenci1. dedikten sonra sadece public olan Isim,Soyisim,Ogrenccino propertilerine ulaşabiliyorum çünkü onları set ettim.
        ogrenci1.Soyisim="Çelik";
        ogrenci1.Ogrencino=126;
        ogrenci1.Sinif=4;
        ogrenci1.OgrenciBilgileriniGetir();

        Ogrenci ogrenci2=new Ogrenci("İlker","Ertürk",17,1);
        ogrenci2.Sinifazalt();       
        ogrenci2.OgrenciBilgileriniGetir();
        
        Console.WriteLine("\n");
        ogrenci2.Sinifarttir(); 
        ogrenci2.OgrenciBilgileriniGetir();
       

        Console.WriteLine("\n");
        ogrenci1.Sinifarttir(); 
        ogrenci1.OgrenciBilgileriniGetir();
       
        ogrenci1.Sinifazalt();       
        ogrenci1.OgrenciBilgileriniGetir();

        }      
    }
    class Ogrenci {
    //Bu klasın field ve ya propertilerini tanımlayacağız.  Private değişkenleri küçük harflerle ya da _ ile başlatmak faydalı olabilir.
     
    private string isim;
    private string soyisim;
    private int ogrencino;
    private int sinif;

    //Burada oluşturduğumuz propertilerin bir kısmını paylaşmak için aynısının public propertilerini oluşturuyorum.

        public string Isim { get => isim; set => isim = value; }  
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Ogrencino { get => ogrencino; set => ogrencino = value; }
        public int Sinif {               //Bunu metotun içerisinde yazmak yerine burada yazmak daha mantıklıdır çünkü koda farklı methot eklenmesiyle sınıf birin altına düşürülebilir,ancak işlemi buradan yaparsak sınıf birin altına düşmez.
            get => sinif;
            set {
                if (value<1) {
                    Console.WriteLine("Sınıf birden küçük olamaz");
                    sinif=1;
                }
                else { 
                    sinif=value;
                }
            } 
            } 

        //Şimdi kurucuları oluşturacağız.

        public Ogrenci(string ısim, string soyisim, int ogrencino, int sinif)  //Parametreli olan buradan çalışacak.4 tane propertiyide gönderiyor olmam lazım.
        {
            Isim = ısim;
            Soyisim = soyisim;
            Ogrencino = ogrencino;
            Sinif = sinif;
        }

        public Ogrenci() {}  //Boş olan ise buradan çalışacak.

        //Şimdi öğrenci bilgilerini geri dönderen metot yazalım. 

        public void OgrenciBilgileriniGetir() {

        //Bu kısımda ne yapacak?..  
        Console.WriteLine("******Öğrenci Bilgileri*******\n");
        Console.WriteLine("Öğrencinin Adı=       "+this.Isim);
        Console.WriteLine("Öğrencinin Soyadı=    "+this.Soyisim);
        Console.WriteLine("Öğrencinin No=        "+this.Ogrencino);
        Console.WriteLine("Öğrencinin Sınıfı=    "+this.Sinif);

        }

        public void Sinifarttir() {
            this.Sinif++;
        }

        public void Sinifazalt() {
            this.Sinif--;
            }
    
    }
}
