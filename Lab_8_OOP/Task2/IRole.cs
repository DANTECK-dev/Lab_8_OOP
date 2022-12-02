using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_OOP.Task2
{
    internal interface IRole
    {
        public int Damage { get; }
        bool Alive { get; }
        void getDamage(int damage);
        static void Battle(IRole irole_1, Role role_1, IRole irole_2, Role role_2)
        {

            do
            {
                Console.WriteLine("Первый игрок ");
                irole_1.getDamage(irole_2.Damage);

                Console.WriteLine("Второй игрок ");
                irole_2.getDamage(irole_1.Damage);

                Console.WriteLine();
            } while (irole_1.Alive && irole_2.Alive);

            if (irole_1.Alive) Console.WriteLine("Первый игрок победил");
            else if (irole_2.Alive) Console.WriteLine("Второй игрок победил");
            else Console.WriteLine("Все погибли");
        }
    }
}
