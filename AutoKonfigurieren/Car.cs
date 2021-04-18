using System;
using System.Collections.Generic;

namespace AutoKonfigurieren
{
    public class Car
    {
        private List<string> brand = new List<string>();
        private List<string> color = new List<string>();
        private List<string> horesePower = new List<string>();
        public enum FUELTYPE { DIESEL, BENZIN}
        private int price = 50000;

        //CONSTRUCTOR
        public Car()
        {
        }
        //GETTER & SETTER
        public List<string> Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public List<string> HorsePower
        {
            get { return horesePower; }
            set { horesePower = value; }
        }
        public FUELTYPE FuelType { get; set; }
        public List<string> Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Price
        {
            get { return price;  }
            set { price = value; }
        }

        public void BrandSelectionMenu()
        {
            Car car = new Car();
            car.Brand.Add("1. BMW");
            car.Brand.Add("2. Audi");
            car.Brand.Add("3. Volkswagen");
            car.Brand.Add("4. Skoda");
            Console.WriteLine("Wählen Sie aus folgenden Möglichkeiten:");
            foreach (string i in car.Brand)
            {
                Console.WriteLine(i);
            }
        }
        public string BrandSelection(string c)
        {
            int mySelection = Convert.ToInt32(Console.ReadLine());
            switch (mySelection)
            {
                case 1:
                    c = "BMW";
                    Console.WriteLine("Sie haben BMW gewählt!");
                    break;
                case 2:
                    c = "Audi";
                    Console.WriteLine("Sie haben Audi gewählt!");
                    break;
                case 3:
                    c = "Volkswagen";
                    Console.WriteLine("Sie haben Volkswagen gewählt!");
                    break;
                case 4:
                    c = "Skoda";
                    Console.WriteLine("Sie haben Skoda gewählt!");
                    break;
                default: 
                    Console.WriteLine("Bitte eine gültige Wahl treffen!");
                    break;
            }
            return c;
        }
        public string TypeSelection(string gas)
        {
            Console.WriteLine("Wählen Sie aus folgenden Möglichkeiten: mit 1 oder 2");
            foreach (FUELTYPE i in (FUELTYPE[])Enum.GetValues(typeof(FUELTYPE)))
            {
                Console.WriteLine(i);
            }
            int mySelection = Convert.ToInt32(Console.ReadLine());
            switch (mySelection)
            {
                case 1:
                    
                    FUELTYPE fuelTypeGas = FUELTYPE.BENZIN;
                    gas = fuelTypeGas.ToString();
                    Console.WriteLine("Sie haben Treibstoffart: " + fuelTypeGas + " gewählt");
                    break;
                case 2:
                    FUELTYPE fuelTypeDiesel = FUELTYPE.DIESEL;
                    gas = fuelTypeDiesel.ToString();
                    Console.WriteLine("Sie haben Treibstoffart: " + fuelTypeDiesel + " gewählt");
                    break;
                default:
                    Console.WriteLine("Bitte eine gültige Wahl treffen!");
                    break;
            }
            return gas;
        }
        public int PsSelection(int i)
        {
            Car car = new Car();
            car.HorsePower.Add("1. 100 PS");
            car.HorsePower.Add("2. 200 PS");
            foreach (string j in car.HorsePower)
            {
                Console.WriteLine(j);
            }
            int mySelection = Convert.ToInt32(Console.ReadLine());
            switch (mySelection)
            {
                case 1:
                    i = 100;
                    Console.WriteLine("Sie haben die " + i + " Version gewählt");
                    break;
                case 2:
                    i = 200;
                    Console.WriteLine("Sie haben die " + i + " Version gewählt");
                    break;
                default:
                    Console.WriteLine("Bitte mit 1 und 2 wählen");
                    break;        
            }
            return i;
        }
        public string ColorSelection(string color)
        {
            Car car = new Car();
            car.Color.Add("1. Schwarz");
            car.Color.Add("2. Blau");
            car.Color.Add("3. Silber");
            foreach (string i in car.Color)
            {
                Console.WriteLine(i);
            }
            int mySelection = Convert.ToInt32(Console.ReadLine());
            switch (mySelection)
            {
                case 1:
                    color = "Schwarz";
                    Console.WriteLine("Sie haben die " + color + "  gewählt");
                    break;
                case 2:
                    color = "Blau";
                    Console.WriteLine("Sie haben die " + color + "  gewählt");
                    break;
                case 3:
                    color = "Silber";
                    Console.WriteLine("Sie haben die " + color + "  gewählt");
                    break;
                default:
                    Console.WriteLine("Bitte Farbe wählen");
                    break;
            }
            return color;
        }
    }

}
