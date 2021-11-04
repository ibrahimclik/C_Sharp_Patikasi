using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Üç tane otomobil klası oluşturacağım,temelde ise özellikleri şöyle:marka,standart renk ve kaç teker.
            //Bu bilgileri Interface üzerinde birleştirip,bu interfaceden kalıtım almayı düşünüyorum.

            focus focus=new focus();    //focusun instance'ını oluşturdum.
            Console.WriteLine(focus.Hangimarkanınaracı().ToString());
            Console.WriteLine(focus.Kactekerlektenolusur().ToString());
            Console.WriteLine(focus.Standartrengine().ToString());       //Bu instance sayesinde metotları çağırdık.
            
            civic civic=new civic();    //civicun instance'ını oluşturdum.
            Console.WriteLine(civic.Hangimarkanınaracı().ToString());
            Console.WriteLine(civic.Kactekerlektenolusur().ToString());
            Console.WriteLine(civic.Standartrengine().ToString());
            
            corolla corolla=new corolla();    //corollaun instance'ını oluşturdum.
            Console.WriteLine(corolla.Hangimarkanınaracı().ToString());
            Console.WriteLine(corolla.Kactekerlektenolusur().ToString());
            Console.WriteLine(corolla.Standartrengine().ToString());

        }
    }
}
