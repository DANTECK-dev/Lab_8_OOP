﻿using System;
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
    internal class Character
    {
        private int HP { get; set; }
        private int Intellect { get; set; }
        private int Agility { get; set; }
        private int Strength { get; set; }
        private Role Role { get; set; }

    }
}
