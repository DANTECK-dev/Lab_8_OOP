using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_OOP.Task2
{
    internal interface IRole
    {
        public int Damage { get => 0; }
        bool Alive { get; }
        void getDamage(int damage);
        static void Battle(IRole irole_1, Role role_1, IRole irole_2, Role role_2)
        {
            int role_1_damage = role_1 switch
            {
                Role.warrior => ((IWarrior)irole_1).Damage,
                Role.arrcher => ((IArcher)irole_1).Damage,
                Role.mage => ((IMage)irole_1).Damage,
                _ => 0
            };

            int role_2_damage = role_2 switch
            {
                Role.warrior => ((IWarrior)irole_2).Damage,
                Role.arrcher => ((IArcher)irole_2).Damage,
                Role.mage => ((IMage)irole_2).Damage,
                _ => 0
            };

            do
            {
                Console.WriteLine("Первый игрок ");
                irole_1.getDamage(role_2_damage);

                Console.WriteLine("Второй игрок ");
                irole_2.getDamage(role_1_damage);

                Console.WriteLine();
            } while (irole_1.Alive && irole_2.Alive);

            if (irole_1.Alive) Console.WriteLine("Первый игрок победил");
            else if (irole_2.Alive) Console.WriteLine("Второй игрок победил");
            else Console.WriteLine("Все погибли");
        }
    }
}
