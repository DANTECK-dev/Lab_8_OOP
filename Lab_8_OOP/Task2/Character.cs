using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_OOP.Task2
{
    /* 
     *  Количество здоровья (HP) – сколько повреждений выдержит персонаж. 
     *  Интеллект (Intellect) – показатель, особенно важный для Мага. 
     *  Ловкость (Agility) – показатель, особенно важный для Лучника. 
     *  Сила (Strength) – показатель, особенно важный для Войн
     */
    internal class Character : IArcher, IWarrior, IMage
    {
        public int HP { get; private set; }
        public int Intellect { get; private set; }
        public int Agility { get; private set; }   // Ловкость
        public int Strength { get; private set; }  // Сила
        public Role Role { get; set; }
        public Character(int hP, int intellect, int agility, int strength)
        {
            HP = hP;
            Intellect = intellect;
            Agility = agility;
            Strength = strength;
        }
        int IMage.Damage => 3 * Intellect + 2 * Agility + 1 * Strength;

        int IWarrior.Damage => 1 * Intellect + 2 * Agility + 3 * Strength;

        int IArcher.Damage => 2 * Intellect + 3 * Agility + 1 * Strength;

        bool IRole.Alive => HP > 0;

        void IRole.getDamage(int damage)
        {
            this.HP -= damage;
            Console.WriteLine("  Получил " + damage + " урона, осатвшееся хп " + HP);
        }
        public override string ToString()
        {
            return "Здоровье - " + HP
                + " Интелект - " + Intellect
                + " Ловкость - " + Agility
                + " Сила - " + Strength
                + " Роль - " + Role;
        }
    }
}
