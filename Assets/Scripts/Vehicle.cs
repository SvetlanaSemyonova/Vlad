namespace DefaultNamespace
{
    public class Vehicle
    {
        #region Properties

        //Properties

        public string name;
        public int age;
        public string country;
        public bool isCar;
        public float hp;
        public int countForSale;
        public double price;

        #endregion

        #region Methods

        //Meth-ods
        public int DaysLeftForSell()
        {
            // return 15;
            countForSale = age - 5;
            return countForSale;
        }

        private double Discount()
        {
            if (age <= 10)
            {
                price = price * 0.2f;
            }

            return price;
        }

        public double SalePrice()
        {
            return Discount();
        }
        
        #endregion
    }
}

