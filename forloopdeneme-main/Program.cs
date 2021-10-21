using System;

namespace switchcasedeneme
{
    class Program
    {
        static void Main(string[] args)
        {

            //0 İle Girlen Sayı arasındaki çift sayıları ekrana yansıtır. 
            Console.WriteLine("Lütfen Bir Sayı Giriniz");
            int sayac=int.Parse(Console.ReadLine());
            for (int i = 0; i < sayac; i++)
            {
                if(i%2==0)
                Console.WriteLine(i);
            }


            int length=1000;
            int csayı=0;
            int tsayı=0;
            
            //0 ile 1000 arasındaki tep ve çift sayıların toplamı.

            for (int i = 0; i <= length; i++)
            {
                if(i%2==0)
                csayı=csayı+i;
                
            }
            Console.WriteLine("Çift Sayıların Toplamı=" + csayı);
            
             for (int i = 0; i <= length; i++)
            {
                if(i%2!=0)
                tsayı=tsayı+i;
                
            }
            Console.WriteLine("Tek Sayıların Toplamı=" + tsayı);
             
            //Break Ve Continue Keyworldleri

            //Koşula bağlı şekilde döngüden çıkmak istiyorsa break kullanırız.
            //Koşula bağlı kalarak döngüyü o kuşulda es geçmek için kullanırız.

            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                break;
                Console.WriteLine(i);
                //Burada break komutu sayesinde 4 olunca looptan çıktı.
            }
            
                for (int i = 1; i < 10; i++)
            {
                if(i==4)
                continue;
                Console.WriteLine(i);
                //Burada continue komutu sayesinde 4 olunca loopu atladı.
            }
             
        }

    }
}
