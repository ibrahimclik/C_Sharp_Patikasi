namespace Interface {
    public class focus : IOtomobil
    {
        public Marka Hangimarkanınaracı()
        {
            return Marka.Ford;
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