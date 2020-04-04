using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    public class Text
    {
        public string Get(string text)
        {
            Console.Write($"Enter your {text}: ");
            string value = Console.ReadLine();

            return value;
        }

        public void PrintToTheFile(int i, string value) 
        {
            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "HomeWork1.txt"),true))
            {
                    outputFile.WriteLine($"Task{i}:  {value}");
            }


        }
    }
}
