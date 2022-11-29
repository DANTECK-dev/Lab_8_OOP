using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_OOP.Task2
{
    internal interface IRole
    {
        int Damage { get => 1; }
        bool Alive { get; }
        void getDamage(int damage);
        static void Battle(IRole irole_1, Role role_1, IRole irole_2, Role role_2)
        {
            if (role_1 == Role.arrcher) irole_1 = (IArcher)irole_1;
            else if (role_1 == Role.mage) irole_1 = (IMage)irole_1;
            else if (role_1 == Role.warrior) irole_1 = (IWarrior)irole_1;

            if (role_2 == Role.arrcher) irole_2 = (IArcher)irole_2;
            else if (role_2 == Role.mage) irole_2 = (IMage)irole_2;
            else if (role_2 == Role.warrior) irole_2 = (IWarrior)irole_2;
        }
    }
}
