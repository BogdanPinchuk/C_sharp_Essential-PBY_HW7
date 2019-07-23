using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{
    class Program
    {
        static void Main()
        {
            // Enable Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // вагонне депо
            Train[] depot = new Train[2];
            // ініціалізація
            for (int i = 0; i < depot.Length; i++)
            {
                depot[i] = new Train();
            }

            // введення інформації
            Console.WriteLine("\n\tЗаповніть базу даних потягів:\n");

            for (int i = 0; i < depot.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\n\tВведіть номер потяга: ");
                depot[i].TrainNumber = byte.Parse(Console.ReadLine());
                Console.ResetColor();
                Console.Write($"\n\tВведіть пункт призначення для потяга: ");
                depot[i].Destination = Console.ReadLine();
                Console.Write($"\n\tВведіть дату відбуття: ");
                depot[i].DepartureTime = DateTime.Parse(Console.ReadLine());
            }

            // сортувати можна так? чи необхідно вручну переписати
            // як зроблено було в попередніх варіантах ДЗ
            depot = depot.OrderBy(train => train.TrainNumber).ToArray();

            Console.Write("\n\tЩоб отримати інформацію про потяг, " +
                "введіть його номер: ");
            byte num = byte.Parse(Console.ReadLine());

            // чи найдений потяг
            bool findTrain = false;

            // пошук потяга
            for (int i = 0; i < depot.Length; i++)
            {
                if (num == depot[i].TrainNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(depot[i].ToString());
                    Console.ResetColor();
                    findTrain = true;
                }
            }

            if (!findTrain)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tВказаний Вами потяг відсутній в базі даних.");
                Console.ResetColor();
            }

            // repeat
            DoExitOrRepeat();
        }

        /// <summary>
        /// Метод виходу або повторення методу Main()
        /// </summary>
        static void DoExitOrRepeat()
        {
            Console.WriteLine("\n\nСпробувати ще раз: [т, н]");
            Console.Write("\t");
            var button = Console.ReadKey(true);

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n")) // можливо забули переключити розкладку клавіатури
            {
                Console.Clear();
                Main();
                // без використання рекурсії
                //Process.Start(Assembly.GetExecutingAssembly().Location);
                //Environment.Exit(0);
            }
            else
            {
                // закриває консоль
                Environment.Exit(0);
            }
        }
    }
}
