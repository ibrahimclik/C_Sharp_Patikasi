using System;

namespace switchcasedeneme
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Switch Case If Else yapısı ile benzer mantıkta çalışmakta ancak yazılımı ve okunması daha kolay.

            int month=DateTime.Now.Month;
            switch(month)
            {

            case 1:
            Console.WriteLine("OCAK AYINDASINIZ");       
            break;

            case 2:
            Console.WriteLine("ŞUBAT AYINDASINIZ");       
            break;

            case 3:
            Console.WriteLine("MART AYINDASINIZ");       
            break;

            case 4:
            Console.WriteLine("NİSAN AYINDASINIZ");       
            break;

            case 5:
            Console.WriteLine("MAYIS AYINDASINIZ");       
            break;

            case 6:
            Console.WriteLine("HAZİRAN AYINDASINIZ");       
            break;

            case 7:
            Console.WriteLine("TEMMUZ AYINDASINIZ");       
            break;

            case 8:
            Console.WriteLine("AĞUSTOS AYINDASINIZ");       
            break;

            case 9:
            Console.WriteLine("EYLÜL AYINDASINIZ");       
            break;
            
            case 10:
            Console.WriteLine("EKİM AYINDASINIZ");       
            break;

            case 11:
            Console.WriteLine("KASIM AYINDASINIZ");       
            break;

            case 12:
            Console.WriteLine("ARALIK AYINDASINIZ");       
            break;

                default:
                break; //Caselerden ya da defaulttan çıkmak için muhakkak break ifadesini kullanmamız gerekir.
            }

            switch (month)
            { 
                case 1:
                case 2:
                case 3:

                Console.WriteLine("Yılın İlk Çeyreğindesiniz");
                break;
                
                case 4:  
                case 5:
                case 6:
                
                Console.WriteLine("Yılın İkinci Çeyreğindesiniz");
                break;

                case 7:
                case 8:
                case 9:
                Console.WriteLine("Yılın Üçüncü Çeyreğindesiniz");
                break;

                case 10:
                case 11:
                case 12:
                Console.WriteLine("Yılın Son Çeyreğindesiniz");
                break;

                default:
                break;

            }

            

        }
    }
}
//The End.