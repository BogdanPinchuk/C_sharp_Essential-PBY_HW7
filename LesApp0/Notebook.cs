using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    /// <summary>
    /// Записник, блокнот
    /// </summary>
    struct Notebook
    {
        /// <summary>
        /// Назва
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Модель
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Ціна
        /// </summary>
        // так як про тип нічого не сказано і щоб убрати
        // код з приводу перевірки <0 швидше використати відходящий тип
        public ushort Price { get; set; }

        /// <summary>
        /// Ініціалазація структури
        /// </summary>
        /// <param name="name">Назва</param>
        /// <param name="model">Модель</param>
        /// <param name="price">Ціна</param>
        public Notebook(string name, string model, ushort price)
        {
            Name = name;
            Model = model;
            Price = price;
        }

        public override string ToString()
        {
            string s = new StringBuilder()
                .Append($"\n\tName: {Name}\n")
                .Append($"\tModel: {Model}\n")
                .Append($"\tPrice: {Price:N0}")
                .ToString();

            return s;
        }
    }
}
