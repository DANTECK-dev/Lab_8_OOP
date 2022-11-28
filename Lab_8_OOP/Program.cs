using Lab_8_OOP.Task1;

namespace Lab_8_OOP
{
    static class Programm
    {
        static void Main(string[] _)
        {
            Task1();
            Task2();
        }
        private static void Task1()
        {
            Person person = new Person("Иван", "Иванов", 35);
            Company company = new Company("JJJ FFF KKK", person, 1943);
            Product product = new Product("Bread", company, 56);
            List<IClonable> cloneables = new List<IClonable>();
            cloneables.Add(person);
            cloneables.Add(company);
            cloneables.Add(product);

            List<IClonable> cloneables_2 = (List<IClonable>)IClonable.Clone(cloneables);

            cloneables.Add(person);

            for (int i = 0; i < cloneables.Count; i++)
                ((IWriteble)cloneables[i]).Print();
            Console.WriteLine();
            for (int i = 0; i < cloneables_2.Count; i++)
                ((IWriteble)cloneables_2[i]).Print();

            Console.ReadKey();
            return;
        }
        private static void Task2()
        {


            Console.ReadKey();
            return;
        }
    }
}
