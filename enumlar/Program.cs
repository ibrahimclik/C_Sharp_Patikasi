using System;

namespace enumlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enumlar enumarationun kısaltılmasıdır.Sıralama anlamına gelir.
            //Ardışık indekslerle çalışacağımız durumlarda işe yararlar.
            //Birden fazla sabite aynı anda ihtiyacımız olduğunda kullanabiliriz.
            
            Console.WriteLine(Gunler.pazar);
            Console.WriteLine((int)Gunler.çarşamba);

            int sıcaklık=32;
            if (sıcaklık <= (int)HavaSicakliği.normal) {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim");
            }
            else if (sıcaklık >= (int)HavaSicakliği.sıcak) {
                Console.WriteLine("Dışarıya çıkmak için sıcak bir gün");
            }
            else if(sıcaklık >= (int)HavaSicakliği.normal && sıcaklık< (int)HavaSicakliği.coksıcak)
            {
                Console.WriteLine("Hadi dışarı çıkalım");
            }      
            //Enum kullanarak okunurluğu yüksek ve ne olacağını anladığımız bir kod yazdık.
            }
    }

    enum Gunler {
        pazartesi,
        salı,
        çarşamba,
        perşembe=17,   //Burayı 17 yaptı artık 18,19,20 şeklinde devam eder.
        cuma,
        cumartesi,
        pazar
    }

    enum HavaSicakliği {
    
    soguk =5,

    normal =20,

    sıcak =20,

    coksıcak =30
    
    }           
}