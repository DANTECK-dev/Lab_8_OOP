using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_OOP.Task1
{
    internal class Company : IClonable, IWriteble   //данные о компании: название, директор (Person), год основания
    {
        public Company(string name, Person person, int yearOfFoundation)
        {
            Name = name;
            Person = person;
            YearOfFoundation = yearOfFoundation;
        }

        private string Name { get; set; }
        private Person Person { get; set; }
        private int YearOfFoundation { get; set; }

        public object Clone() => MemberwiseClone();
        //{
        //    return new Company(Name, (Person)Person.Clone(), YearOfFoundation);
        //}

        public void Print() => Console.WriteLine(ToString());

        public override string ToString()
        {
            return "Company: " + Name + " " + YearOfFoundation + "; " + Person.ToString();
        }
    }
}
