namespace AutoKonfigurieren
{
    public class PriceCalc
    {
        
        private static int endPrice = Car.BASE_PRICE;
        public static int BrandPrice(string brand)
        {   
            Car car = new Car();

            endPrice = Car.BASE_PRICE;

            if(brand == "BMW" || brand == "Audi")
            {
                endPrice = (int)(endPrice * (135.0f / 100.0f));
            } 
            else if(brand == "Volkswagen")
            {
                endPrice = (int)(endPrice * (115.0f / 100.0f));
            }
            else if(brand == "Skoda")
            {
                endPrice = (int)(endPrice * (95.0f / 100.0f));
            }

            return endPrice;
        }
        public static int FuelPrice(string fuelType)
        {
            int fuelPrice = endPrice;
            string diesel = Car.FUELTYPE.DIESEL.ToString();
            string benzin = Car.FUELTYPE.BENZIN.ToString();
            if(diesel == "DIESEL")
            {
                fuelPrice = (int)(fuelPrice * (8.0f/100.0f));
            }    
            else if(benzin == "BENZIN")
            {
                fuelPrice = (int)(fuelPrice * (5.0f / 100.0f));
            }
            return fuelPrice; 
        }
        public static int PsPrice(int horsePower)
        {
            int psPrice = endPrice;
            if(horsePower == 100)
            {
                psPrice = (int)(psPrice * (8.0f / 100.0f));
            }
            else if(horsePower == 200)
            {
                psPrice = (int)(psPrice * (13.0f / 100.0f));
            }
            return psPrice;
        }
        public static int ColorPrice(string color)
        {
            int colorPrice = endPrice;

            if(color == "Schwarz")
            {
                colorPrice = (int)(colorPrice * (3.0f / 100.0f));
            }
            else if(color == "Blau")
            {
                colorPrice = (int)(colorPrice * (2.0f / 100.0f));
            }
            else if(color == "Silber")
            {
                colorPrice = (int)(colorPrice * (1.0f / 100.0f));
            }
            return colorPrice;
        }
    }
}
