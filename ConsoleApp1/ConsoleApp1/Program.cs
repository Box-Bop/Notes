using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //"C:\Users\opilane\Desktop\Notes", "*.txt"
            Start:



            Console.WriteLine("Kõik tehtud .txt failid: ");
            Console.WriteLine();
            foreach (string file in Directory.EnumerateFiles(@"C:\Users\opilane\Desktop\Notes", "*.txt"))
            {
                Console.WriteLine(file);
            }
            Console.WriteLine();
            Console.WriteLine("Kas soovite lugeda faili? (Read)\nKustutada faili? (Delete)\nVõi teha uue faili? (New)\nSaate programmi lahkuda kirjutades Exit");
            string answer1 = Convert.ToString(Console.ReadLine());
            if (answer1 == "New")
            {
                newNote new1 = new newNote();
                Console.WriteLine("Mis soovite et faili nimi oleks?");
                new1.FileName = Convert.ToString(Console.ReadLine());
                File.Create(@"C:\Users\opilane\Desktop\Notes\" + new1.FileName + ".txt");
                Console.WriteLine("Fail tehtud!");
                Console.WriteLine("Kirjutage märkus: ");
                string Note = Convert.ToString(Console.ReadLine());
                new1.New();
                goto Start;
            }
            if (answer1 == "Read")
            {
                Console.WriteLine("Mis faili soovite lugeda?");
                string vastus = Console.ReadLine();
                if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), vastus)))
                {
                    string text = File.ReadAllText((Path.Combine(Directory.GetCurrentDirectory(), vastus)));
                    Console.WriteLine(text);
                    goto Start;
                }
                else
                {
                    Console.WriteLine("Fail sellise nimega ei eksisteeri");
                    goto Start;
                }
            }
            if (answer1 == "Delete")
            {
                DelNote delete = new DelNote();
                delete.Delete();
                goto Start;
            }
            if (answer1 == "Exit")
            {
                Environment.Exit(0);
            }
        }
    }
}
