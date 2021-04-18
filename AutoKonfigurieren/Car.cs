namespace AutoKonfigurieren
{
    class Car
    {
        private string brand;
        private int horesePower;
        private int price;
        public enum FUELTYPE { DIESEL, GAS}

        public Car()
        {
        }
        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }
        public int HorsePower
        {
            get
            {
                return horesePower;
            }
            set
            {
                horesePower = value;
            }
        }
        public FUELTYPE FuelType { get; set; }

    }
}
