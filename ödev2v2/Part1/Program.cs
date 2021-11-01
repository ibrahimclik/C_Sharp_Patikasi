using System;
using System.Collections.Generic;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ÖDEV 1

        Console.WriteLine("20 Adet Sayı Giriniz");
        int[] sayilar=new int[20];
        int sayac=0;

        List<int> asal=new List<int>();
        List<int> asaldegil=new List<int>();
        
        try
        {
        for(int i=0;i<20;i++){
            sayilar[i]=int.Parse(Console.ReadLine());     
        }
        }
        catch (System.Exception)
        {
             Console.WriteLine("Hatalı giriş yaptınız,Lütfen pozitif sayı giriniz!");
        }
        for(int i=0;i<20;i++){
            sayilar[i]=int.Parse(Console.ReadLine());
        }
         
        Console.WriteLine("\n");
        Console.WriteLine("\n");

        foreach (var item in sayilar)
        {
            Console.Write(item+" ");
        } 
        
        for(int b=0;b<20;b++) {
        for(int a=2; a<sayilar[b]; a++){
        if(sayilar[b]%a==0)
            sayac++;
        }
        if(sayac != 0 || sayilar[b]==1){
        asaldegil.Add(sayilar[b]); }
        else {
        asal.Add(sayilar[b]); }
        sayac=0;
        }

        Console.WriteLine("\n");
        
        asal.Sort();
        asal.Reverse();

        asaldegil.Sort();
        asaldegil.Reverse();

        foreach (var item1 in asal)
        {   Console.Write(item1+" ");} 
         
        Console.WriteLine("\n");


        foreach (var item2 in asaldegil)
        { Console.Write(item2+" ");     }
        
        Console.WriteLine("\n");
        
        int asaltoplam=0;
        int asalolmayantoplam=0;
        int ab=0;
        int aob=0;

        for(int z=0;z<asal.Count;z++) {
        asaltoplam=asaltoplam+asal[ab];
        ab++;
        }

        for(int q=0;q<asaldegil.Count;q++) {
        asalolmayantoplam=asalolmayantoplam+asaldegil[aob];
        aob++;
        }

        Console.WriteLine("Asal eleman sayısı= "+asal.Count+" Asal Sayıların ortalaması= "+ asaltoplam/asal.Count);
        Console.WriteLine("Asal olmayan elemanların sayısı= "+asaldegil.Count+" Asal olmayan sayıların ortalaması= "+asalolmayantoplam/asaldegil.Count);
        }
    }
}
