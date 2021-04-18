using System;
using System.IO;
using System.Text;

namespace AutoKonfigurieren
{
    class Program
    {
        static void Main(string[] args)
        {

            Car c1 = new Car();
            c1.Brand = "BMW";
            c1.HorsePower = 218;
            c1.FuelType = Car.FUELTYPE.DIESEL;

            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Config.txt");
           //var filePath = @"C:\\Database\\maxfile.txt";
            var txt = new StringBuilder();
            var newLine = string.Format("{0}, {1}, {2}", c1.Brand, c1.FuelType, c1.HorsePower);
            txt.AppendLine(newLine);
            File.AppendAllText(filePath, txt.ToString());
        }
    }
}
