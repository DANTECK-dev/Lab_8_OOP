using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_OOP.Task1
{
    public interface IClonable
    {
        public object Clone();

        public static object Clone(List<IClonable> clonables)
        {
            List<IClonable> clone = new List<IClonable>();
            foreach (IClonable clonable in clonables) clone.Add((IClonable)clonable.Clone());
            return clone;
        }
    }
}
