namespace DefaultNamespace
{
    public class OLX
    {
        public void Init()
        {
            var amountOnSale = 21;
            
            var Porsche = new Vehicle
            {
                name = "Cayenne",
                age = 10,
                country = "Italy",
                isCar = true,
                hp = 5.2,
            };
            
            var Horse1 = new Vehicle
            {
                name = "Plotva",
                age = 5,
                country = "Poland",
                hp = .9f,
                isCar = false,
            };

            var horse1LeftForSale = Horse1.daysLeftForSell();
            var PorscheLeftForSale = Porsche.daysLeftForSell();
        }
    }
}