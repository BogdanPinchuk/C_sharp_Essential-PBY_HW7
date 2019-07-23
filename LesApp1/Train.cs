using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{
    /// <summary>
    /// Потяг
    /// </summary>
    struct Train
    {
        /// <summary>
        /// Пункт призначення
        /// </summary>
        public string Destination { get; set; }
        /// <summary>
        /// Номер потяга
        /// </summary>
        public byte TrainNumber { get; set; }
        /// <summary>
        /// Час відправлення
        /// </summary>
        public DateTime DepartureTime { get; set; }

        public override string ToString()
        {
            string s = new StringBuilder()
                .Append($"\n\tПотяг №{TrainNumber} ")
                .Append($"прямує в {Destination} ")
                .Append($"о " + DepartureTime.ToString())
                .ToString();

            return s;
        }
    } 
}
