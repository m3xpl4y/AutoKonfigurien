
using System;
using System.IO;
using System.Text;

namespace AutoKonfigurieren
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Maximilian";
            var filePath = @"C:\\Database\\maxfile.txt";
            var txt = new StringBuilder();
            var newLine = string.Format("{0}", name);
            txt.AppendLine(newLine);
            File.AppendAllText(filePath, txt.ToString());
        }
    }
}
