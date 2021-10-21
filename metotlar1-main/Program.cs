using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //METOTLAR (FONKSİYONLAR)
            
            //Metotları kodları daha küçük kodlara ayırmak için kullanıyoruz,daha küçük kodlar sayesinde hem tekrardan kurtuluyor,hemde daha okunabilir bir koda yazmış oluyoruz.

            //Metotlar tek başlarına yazılabilen yapılar değildir,bir klas içerisinde olmaları gerekir.

            //Methot kullanırken Başka bir klas içerisinde ki ile eşleşmek istiyorsak o klasın bir instansını,bir örneğini oluşturmak gerekiyor. 

            //erisim_belirteci geridönüs_tipi metot_adi(parametreler/arg)

            //erisim_belirteci = Metota nereden erişilebilceğini gösterir.(Public ya da private)

            //geri_dönüştipi = Metotun geriye ne dönderdiği bilgisini tutar,eğer geriye dönülen bir şey yoksa void kullanılır.

            //parametreler =Metotun iş yaparken kullanacağı parametreler.
            
            //Erişim belirtecleri default olarak privatedır.

            int a=2;
            int b=3;
            Console.WriteLine(a+b);

          
            int sonuc =Topla(a,b);
            Console.WriteLine(sonuc);
           
            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdır(Convert.ToString(sonuc));
            
            int sonuc2=ornek.Arttırvetopla(ref a,ref b);
            ornek.EkranaYazdır(Convert.ToString(sonuc2));
            ornek.EkranaYazdır(Convert.ToString(a+b));


        } 
        //Aynı klas içerisinde bir methot;

        public static int Topla(int deger1,int deger2)
         
        {
            //Staic bir klas içerisinde sadece statik methotlara erişilebilir.
            return (deger1+deger2);
            //Fonksiyona gönderilen parametrelere sadece buradan erişilebilir,burada işlem tamamlandıktan sonra bellekten silinir.

        }
      

    }

    class Metotlar 
    {
   
      public void EkranaYazdır(string veri)
      {

       Console.WriteLine(veri);

      }
     public int Arttırvetopla(ref int deger1,ref int deger2)

        
          {
         deger1++;
         deger2++;
               return deger1+deger2;

               //Referan olarak çalıştığımızda artık kopyalarla değil a ve b nin adresteki yerleri üzerinde değişiklik yapıyor,bu işlemden sonra en başta tanımladığımız a ve bnin değerleri değişecek.
          }
         
        

    }
}
