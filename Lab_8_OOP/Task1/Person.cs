using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_OOP.Task1
{
    internal class Person : IClonable, IWriteble    // данные о человеке: имя, фамилия, возраст.
    {
        public string FirstName { get; set; }
        private string LastName { get; set; }
        private int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public object Clone() => MemberwiseClone();
        //{
        //    return new Person(FirstName, LastName, Age);
        //}

        public void Print() => Console.WriteLine(ToString());

        public override string ToString()
        {
            return "Person: " + FirstName + " " + LastName + " " + Age;
        }
    }
}
