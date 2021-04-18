using System;
using System.IO;
using System.Text;

namespace AutoKonfigurieren
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car car = new Car();
            string brand = "";
            string gas = "";
            int horsePower = 0;
            string color = "";   
            
            car.BrandSelectionMenu();
            brand = car.BrandSelection(brand);
            car.TypeSelectionMenu();
            gas = car.TypeSelection(gas);
            horsePower = car.PsSelection(horsePower);
            color = car.ColorSelection(color);

            int brandPrice = PriceCalc.BrandPrice(brand);
            int fuelPrice = PriceCalc.FuelPrice(gas);
            int psPrice = PriceCalc.PsPrice(horsePower);
            int colorPrice = PriceCalc.ColorPrice(color);

            int endPrice = brandPrice + fuelPrice + psPrice + colorPrice;


            SaveToFile(brand, gas, horsePower, color, endPrice); //SAVE TO FILE
            
        }
        //FUNCTIONS
        static void SaveToFile(string brand, string fuelType, int horsePower, string color, int endPrice)
        {
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Config.txt");
            var txt = new StringBuilder();
            var newLine = string.Format("{0}, {1}, {2}, {3}, {4}", brand, fuelType, horsePower + "PS", color, endPrice + "€");
            txt.AppendLine(newLine);
            File.AppendAllText(filePath, txt.ToString());
            Console.WriteLine("Saved to File Config.txt in My Documents");
        }
    }
}
