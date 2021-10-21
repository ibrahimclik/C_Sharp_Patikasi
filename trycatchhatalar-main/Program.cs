using System;

namespace trycatchhatalar
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            //Burada hata verme ihitmali olan kod bloğunu try catch bloğuna alıyoruz.

           try
           {
                //Try bölümüne hatalı kodu yazdık.
                //İnteger girersek hatasız,farklı string gibi bir şey girersek hata verecek.
            Console.WriteLine("Bir Sayı Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girilen Sayı" + sayi);
        
            }
               catch (Exception ex)
               {
               
               //Catch kısmında hatayı yakalıyoruz ve kullanıcaya geri bildirim veriyoruz.
               Console.WriteLine("Hata:" + ex.Message.ToString());
               
               }
            
            // finally
            // {
            //Finally kısmına bir kod bloğunda hata olup olmamasından bağımsız bir şekilde çalışmasını istediğimiz diğer kod bloklarını yazıyoruz.
            //Bu kısım zorunlu değil.
            //   Console.WriteLine("işlem Tamamlandı");
            // }    



            try
            {
                //Burada ArgumentNullException hatası alacağız.
                //int a = int.Parse(null);
                dint a=int.Parse("test");   //Bu kısımda format exception hatası verecek.
                int a=int.Parse("-100000000"); //Aralık dışında girdi olduğu için hata verecek.
            }
            catch (ArgumentNullException ex)
            {
            
                Console.WriteLine("Hata:" + ex.Message.ToString());
                Console.WriteLine(ex);
                Console.WriteLine("Boş değer girdiniz");


            }

            catch (FormatException ex)

            {
            
            Console.WriteLine("Hata:" + ex.Message.ToString());
                Console.WriteLine(ex);
                Console.WriteLine("Hatalı format girdiniz");

            }

            catch (OverflowException ex)

            {

              
                Console.WriteLine(ex);
                Console.WriteLine("Aralık dışında bir değer girdiniz");

            }

        }
    }
}
 
 //THE END.