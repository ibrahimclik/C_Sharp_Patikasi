using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
        //öDEV - PART 3
   
         int w=0;
         Console.WriteLine("Bir Cümle Giriniz");
         string a=Console.ReadLine();
         string removed=a.Replace(" ","");
         string[] sesli=new string[removed.Length];
         
         for(int i=0;i<removed.Length;i++){
              if(removed[w]=='a' || removed[w]=='e' || removed[w]=='ı' || removed[w]=='i' || removed[w]=='o' || removed[w]=='ö' || removed[w]=='u' || removed[w]=='ü' )      
              sesli[i]=removed[w].ToString(); 
              w++;
          }
          
         Array.Sort(sesli);
         foreach (var eleman in sesli)
         {   
             Console.Write(eleman+" ");
         }
        }
    }
}
