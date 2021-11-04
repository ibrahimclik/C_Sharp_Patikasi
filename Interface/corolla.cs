namespace Interface  //Bu kısım interface'e bağlı olduğu için namespace'i oradan aldık.
{
    public class corolla : IOtomobil
    {
        public Marka Hangimarkanınaracı()
        {
            return Marka.Toyota;
        }

        public int Kactekerlektenolusur()
        {
            return 4;        }

        public Renkler Standartrengine()
        {
            return Renkler.Gri;
        }
    }

}    