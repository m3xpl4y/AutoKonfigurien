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
            gas = car.TypeSelection(gas);
            horsePower = car.PsSelection(horsePower);
            color = car.ColorSelection(color);

            SaveToFile(brand, gas, horsePower, color); //SAVE TO FILE
            
        }
        //FUNCTIONS
        static void SaveToFile(string brand, string fuelType, int horsePower, string color)
        {
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Config.txt");
            var txt = new StringBuilder();
            var newLine = string.Format("{0}, {1}, {2}, {3}", brand, fuelType, horsePower, color);
            txt.AppendLine(newLine);
            File.AppendAllText(filePath, txt.ToString());
            Console.WriteLine("Saved to File Config.txt in My Documents");
        }
    }
}
