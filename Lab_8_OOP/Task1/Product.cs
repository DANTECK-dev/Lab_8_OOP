using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_OOP.Task1
{
    internal class Product : IClonable, IWriteble   //данные о товаре: наименование, компания производитель (Company), количество.
    {
        public Product(string name, Company company, int count)
        {
            Name = name;
            Company = company;
            Count = count;
        }

        private string Name { get; set; }
        private Company Company { get; set; }
        private int Count { get; set; }

        public object Clone() => MemberwiseClone();

        public void Print() => Console.WriteLine(ToString());

        public override string ToString()
        {
            return "Product: " + Name + " " + Count + "; " + Company.ToString();
        }
    }
}
