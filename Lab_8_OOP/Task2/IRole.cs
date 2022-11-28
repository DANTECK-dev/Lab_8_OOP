using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_OOP.Task2
{
    internal interface IRole
    {
        int Damage { get; }
        bool Alive { get; }
        void getDamage(int damage);
        static void Battle(IRole role_1, IRole role_2)
        {

        }
    }
}
