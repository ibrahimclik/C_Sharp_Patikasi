using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ÖDEV - 2
        
        Console.WriteLine("20 Adet pozitif sayı giriniz");
        int[] sayilar=new int[20];
        
        for (int i=0;i<20;i++)
        {
            sayilar[i]=int.Parse(Console.ReadLine());
        }
        
        Array.Sort(sayilar);
        
        int[] enkucuk=new int[3];
        int b=0;
        for(int a=0;a<3;a++) {
            enkucuk[a]=sayilar[b];
                   b++;
        }
        
        
        int[] enbuyuk=new int[3];
        int c=19;
        for(int a=0;a<3;a++) {
            enbuyuk[a]=sayilar[c];
                   c--;
        }
        
        float ort1=(enkucuk[0]+enkucuk[1]+enkucuk[2])/3;
        float ort2=(enbuyuk[0]+enbuyuk[1]+enbuyuk[2])/3;
        float toplam=ort1+ort2;
        Console.WriteLine("En küçük 3 sayının ortalaması= "+ort1+"  En büyük üç sayının ortalaması= "+ort2 +"   Toplam= "+toplam);
        }
    }
}
