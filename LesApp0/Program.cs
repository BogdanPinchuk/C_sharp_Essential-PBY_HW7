using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    class Program
    {
        static void Main()
        {
            // Enable Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // випадкові числа
            Random rnd = new Random();

            // створення структури
            // https://en.wikipedia.org/wiki/Notebook
            Notebook[] notebooks = new Notebook[]
            {
                new Notebook("Notepad", "5s", (ushort)rnd.Next(1, short.MaxValue)),
                new Notebook("Writing pad", "3d", (ushort)rnd.Next(1, short.MaxValue)),
                new Notebook("Drawing pad", "7a", (ushort)rnd.Next(1, short.MaxValue)),
                new Notebook("Legal pad", "1b", (ushort)rnd.Next(1, short.MaxValue)),
            };

            // Вивід інформації на екран
            for (int i = 0; i < notebooks.Length; i++)
            {
                Console.WriteLine(notebooks[i].ToString());
            }

            // delay
            Console.ReadKey(true);
        }
    }
}
