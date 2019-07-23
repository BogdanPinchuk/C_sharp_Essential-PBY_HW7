using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    /// <summary>
    /// Моя структура
    /// </summary>
    struct MyStruct
    {
        public string change;

        public override string ToString()
        {
            return change ?? "null";
        }
    }
}
