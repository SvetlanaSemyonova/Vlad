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
        public double hp;
        public int countForSale;

        #endregion

        #region Methods

        //Meth-ods
        public int daysLeftForSell()
        {
            // return 15;
            countForSale = age - 5;
            return countForSale;
        }

        #endregion
    }
}

