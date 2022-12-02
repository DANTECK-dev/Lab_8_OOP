using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_OOP.Task2
{
    internal interface IArcher : IRole    // Лучник
    {
        new public int Damage { get; }

    }
}
