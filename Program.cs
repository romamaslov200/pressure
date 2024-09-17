using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pressure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int month = 01;

            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string[] terms = new string[400];

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
            {
                for (int day = 1; day < 29; day++)
                {
                    terms[day] = $"{day}.{month}.2024\n{r.Next(105, 135)}/{r.Next(70, 87)}/{r.Next(70, 97)}\n{r.Next(105, 135)}/{r.Next(70, 87)}/{r.Next(70, 97)}\n";
                }

                foreach (string line in terms)
                    outputFile.WriteLine(line);
            }
        }
    }
}
