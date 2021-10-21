using System;

namespace recursive
 {
    class Program
    {
        static void Main(string[] args)
        {
        //Rekursif - Özyinelemeli fonksiyon demektir.
         islemler instance=new(); //Burada fonksiyonu farklı bir klas içerisinden çağırdığımız için instance oluşturduk.
         Console.WriteLine(instance.Expo(3,4)); //Çıktı 81.
         
         //Extension Metotlar -Mevcut olan kodu daha kolay yazabilmek,daha hızlı erişebilmek için kullanıyoruz.
        
        string ifade="Halil İbrahim Çelik";
        bool sonuc =ifade.CheckSpaces();
        Console.WriteLine(sonuc);
        if (sonuc)
        {
        Console.WriteLine(ifade.RemoveWhitespaces());
        Console.WriteLine(ifade.Buyukharf());
        }
                 
        int[] dizi={9,3,6,2,1,5,0};
        dizi.SortArray();
        dizi.EkranaYazdır();
       


        }
    }
    public class islemler
    {
    public int Expo(int sayi,int üs)
    {  
        if(üs<2)

       return sayi;
       return Expo(sayi,üs-1)*sayi;
    }
  
    }

    public static class Extension {

     public static bool CheckSpaces(this string param)
    {   
      return param.Contains(" ");  //İfade içerisinde boşluk olup olmadığını kontrol edecek.
    }

     public static string RemoveWhitespaces(this string param) 
    {
     string[] dizi = param.Split(" ");
     return string.Join("",dizi);
    }

    public static string Buyukharf(this string param) {
    return param.ToUpper();
    } 

    public static int[] SortArray(this int[] param){
        Array.Sort(param);
        return param;
    }
   
    public static void EkranaYazdır(this int[] param) 
    {
            foreach (var item in param) {
                Console.WriteLine(item);
            }
    }

    }   
}