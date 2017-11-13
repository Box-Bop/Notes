using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class newNote
    {
        public string filePath = Directory.GetCurrentDirectory();
        public string FileName { get; set; }
        public string Note { get; set; }
        public void New()
        {
            using (StreamWriter sw = File.CreateText(Path.Combine(filePath + FileName + ".txt")))
            {
                sw.WriteLine(Note);
            }
        }
    }
}
