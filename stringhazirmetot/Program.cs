using System;

namespace stringhazir
{
    class Program
    {
        static void Main(string[] args)
        {
         //STRING KUTUPHANESI HAZIR METOTLAR
         //Bu kütüphanede bulunan kodlar sayesinde hem kodumuzu daha kısa sürede yazarız hemde okunması daha kolay olur.

         string degisken="Dersimiz CSharp, Hoşgeldiniz!";
         string degisken2="CSharp";
         //Length  = String içerisinde kaç tane karakter olduğunu gösterir.
       
         Console.WriteLine(degisken.Length);  

        //ToUpper,ToLower = Bu komutlar sayesinde string içerisinde bulunan harflerin hepsini küçültebiliriz ya da büyütebiliriz.

        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());
        
        //string.Concat = Stringe ekleme yapmamızı sağlar.

        Console.WriteLine(string.Concat(degisken," Merhaba!"));
        
        //string.Compare,CompareTo = Kıyaslama,karşılaştırma işlemleri yapmamızı sağlar.
        
        Console.WriteLine(degisken.CompareTo(degisken2));
        Console.WriteLine(string.Compare(degisken,degisken2,true));
        Console.WriteLine(string.Compare(degisken,degisken2,false));

        //Contains = Stringin içerisinde aradığımız şeyin olup olmadığını kontrol eder.

        Console.WriteLine(degisken.Contains(degisken2));
        Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
        Console.WriteLine(degisken.StartsWith("Merhaba"));
       
        //IndexOf = Arattığımız harfin ya da karakterin indexini verir.

        Console.WriteLine(degisken.IndexOf("CS"));  //Burada ilk bulunan harfin yani C'nin indexini bize verecek.
        Console.WriteLine(degisken.IndexOf("Cssss"));  //Bulamadığı için -1 dönecek.
        
        //Insert = Ekleme yapmak için kullanırız.
         
        Console.WriteLine(degisken.Insert(0,"Merhaba! ")); // Sıfırıncı indexten başlayarak merhaba kelimesini ekler.
        
        //LastIndexOf = Arattığımız karakter ya da harfin bulunduğu sonuncu indexi getirir.
        
        Console.WriteLine(degisken.LastIndexOf("i"));
       
        //PadLeft,PadRight() = Stingin sağ ve ya sol kısmına girdiğimiz miktara ulaşana kadar boşluk ekler.

        Console.WriteLine(degisken + degisken2.PadLeft(30));    
     
        //Remove = Çıkarma işlemi yapar.

        Console.WriteLine(degisken.Remove(10)); //  10. İndexten sonrasını siler. 
        Console.WriteLine(degisken.Remove(5,3)); //5. indexten başlayarak 3 karakter siler.
        Console.WriteLine(degisken.Remove(0,1)); //İlk harfi silecek.
        

        //Replace = String içersindeki karakterleri farklı karakterlerle değiştirmemizi sağlar.
        
        Console.WriteLine(degisken.Replace("CSharp","C#")); 
        Console.WriteLine(degisken.Replace(" ","*")); 
        
        //Split 
          
        Console.WriteLine(degisken.Split(' ')[1]);
        
        //Substring = İstediğimiz kısmı getirtmemizi sağlar.

        Console.WriteLine(degisken.Substring(4));   //Dörtten başlayarak son kısma kadar bize getirir.
        Console.WriteLine(degisken.Substring(4,6)); //Dört ile altı arasını bize getirir.

        }
    }
}
