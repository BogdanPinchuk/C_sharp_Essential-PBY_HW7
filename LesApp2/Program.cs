using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    class Program
    {
        static void Main()
        {
            // Enable Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // створення екземплярів
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();

            // вивід результатів
            Console.WriteLine("\n\tДо внесення змін:");
            Show(myClass, myStruct);

            // вносимо дані в поля
            myClass.change = "Не змінено";
            myStruct.change = "Не змінено";

            // вивід результатів
            Console.WriteLine("\n\n\tПісля внесення 1-х змін:");
            Show(myClass, myStruct);

            // внесення змін
            ClassTaker(myClass);
            StruktTaker(myStruct);

            // вивід результатів
            Console.WriteLine("\n\n\tПісля внесення 2-х змін:");
            Show(myClass, myStruct);

            Console.WriteLine("\n\n\t" + new string('#', 27));

            Console.WriteLine("\n\tВисновки:");
            Console.WriteLine("\tClass - передає ссилку, а тому дані можуть зазнати змін, що є аналогічно використанню \"ref\" і \"out\".");
            Console.WriteLine("\tStruct - передає свою копію і дані не зазнають змін.");
            

            //delay
            Console.ReadKey(true);
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Змінено";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "Змінено";
        }

        public static void Show(MyClass mc, MyStruct ms)
        {
            Console.Write("\n\tClass: " + mc.ToString());
            Console.Write("\n\tStruct: " + ms.ToString());
        }
    }
}
