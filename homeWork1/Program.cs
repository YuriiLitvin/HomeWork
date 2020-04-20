using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            SpaceCounter mySpace = new SpaceCounter();
            var answer1 = mySpace.GetCount();
            Console.WriteLine(answer1);


            Ticket myTicket = new Ticket();
            var answer2 = myTicket.CheckIfLucky();
            Console.WriteLine(answer2);

            LowerUpperCaseConverter myConverter = new LowerUpperCaseConverter();
            var answer3 = myConverter.ConvertText();
            Console.WriteLine(answer3);

            XmasTree myTree = new XmasTree();
            var answer4 = myTree.GetTree();
            Console.WriteLine(answer4);

            MirrorNumber myNumber = new MirrorNumber();
            var answer5 = myNumber.GetNumber();
            Console.WriteLine(answer5);

        }

    }
    public static class TextForWork 
    {
        public static string Get(string text)
        {
            Console.Write($"Enter your {text}: ");
            string value = Console.ReadLine();

            return value;
        }

        public static void PrintToTheFile(int taskNumber, string value)
        {
            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "HomeWork1.txt"), true))
            {
                outputFile.WriteLine($"Task{taskNumber}:  {value}");
            }
        }
    }
}
