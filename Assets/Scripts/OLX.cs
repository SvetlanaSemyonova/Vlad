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
                hp = 5.2f,
                price = 10900.50,
            };
            
            var Horse1 = new Vehicle
            {
                name = "Plotva",
                age = 5,
                country = "Poland",
                hp = .9f,
                isCar = false,
                price = 1499.99,
            };

            var horse1LeftForSale = Horse1.DaysLeftForSell();
            var porscheLeftForSale = Porsche.DaysLeftForSell();

            var horse1PriceOnSite = Horse1.SalePrice();
            var porschePriceOnSite = Porsche.SalePrice();
        }
    }
}