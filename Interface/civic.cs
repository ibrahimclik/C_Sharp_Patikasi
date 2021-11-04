namespace Interface  //Bu kısım interface'e bağlı olduğu için namespace'i oradan aldık.
{
    public class civic : IOtomobil
    {   //IOtomobilden kalıtım aldığı için notsayon bu şekilde.
        public Marka Hangimarkanınaracı()
        {
            return Marka.Honda;
        }

        public int Kactekerlektenolusur()
        {
            return 4;
        }

        public Renkler Standartrengine()
        {
            return Renkler.Beyaz;
        }
    }











}