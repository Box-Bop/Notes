using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DelNote
    {
        string path = Directory.GetCurrentDirectory();
        public void Delete()
        {
            //Siin kirjutab välja kõik failid, mis on directorys
            DirectoryInfo dinfo = new DirectoryInfo(path);
            FileInfo[] Files = dinfo.GetFiles("*.txt");
            Console.WriteLine("Mis faili soovite kustutada? ");
            string input = Console.ReadLine();
            if (File.Exists(Path.Combine(path, input)))
            {
                File.Delete(Path.Combine(path, input));
                Console.WriteLine("Kustutatud!");
            }
            else
            {
                Console.WriteLine("Ei leidnud sellist faili");
            }
        }
    }
}
