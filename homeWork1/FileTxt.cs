using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    class FileTxt
    {
        //createFileIfNotExists
        //writeOutPutIntoFile
        public void Create()
        {
            string path = @"C:\Users\Юрій\Desktop\HomeWork.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }

            }
        }


    }
}
