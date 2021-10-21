using System;

namespace arraysinifimetot
{
    class Program
    {
        static void Main(string[] args)
        {
           //ARRAY SINIFI METHOTLARI

           //SORT = Sort komutu dizimizin içerisinde sıralama işlemi yapar.
           
           Console.WriteLine("****Sırasız Dizi****");
           int[] sayidizisi = {12,11,5,8,7,0,2,11};
           foreach (var sayi in sayidizisi)
           Console.WriteLine(sayi);

           
           Console.WriteLine("****Sıralı Dizi****");
           Array.Sort(sayidizisi); //Bu komut sıralama yapmamızı sağlar. 
           foreach (var sayi in sayidizisi)
           Console.WriteLine(sayi); //Çıktı olarak artık bize sıralı dizi gelecek.

           //CLEAR = Clear komutu verdiğimiz indexten başlayarak belirlediğimiz kadar elemanı siler.

           Console.WriteLine("****Array Clear****");

           Array.Clear(sayidizisi,3,2);
            foreach (var sayi in sayidizisi)
           Console.WriteLine(sayi); //Çıktı olarak 3. indexten başlayıp iki elemanı sıfır yapıp diziyi ekran getirecek.

           //REVERSE = Reverse methodu diziyi ortada bulunan elemanı merkez alarak ters çevirir.

           Console.WriteLine("****REVERSE*****");
           Array.Reverse(sayidizisi);
           foreach (var sayi in sayidizisi)
           Console.WriteLine(sayi); //Çıktı olarak aynı dizinin ters çevrilmiş halini verecek.

           //INDEXOF = IndexOf komutu sorduğumuz elemanın hangi indexte olduğunu bize bildirir.
          
           Console.WriteLine("****INDEXOF*****");
           Console.WriteLine(Array.IndexOf(sayidizisi,5)); //Çıktı = 5;

           //RESIZE = Resize komutu yeniden boyutlandırma yapar.

           Console.WriteLine("****RESIZE****");
           Array.Resize<int>(ref sayidizisi,9);
           sayidizisi[8]=17;

        foreach (var sayi in sayidizisi)
           Console.WriteLine(sayi);


        }
    }
}
//The End.