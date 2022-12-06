using Lab_8_OOP.Task1;
using Lab_8_OOP.Task2;

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
            ((Person)cloneables_2[0]).FirstName = "hsdfksjfkewhf";

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
            Random rand = new();
            List<Character> characters = new();


            characters.Add(new Character(rand.Next(100, 500), rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10)));
            characters.Add(new Character(rand.Next(100, 500), rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10)));

            Console.WriteLine();
            for (int i = 0; i < characters.Count; i++)
                Console.WriteLine(characters[i].ToString());
            Console.WriteLine();

            int select1;
            int select2;
            do
            {
                Console.WriteLine("0 - warrior, 1 - arrcher, 2 - mage");
                select1 = ReadInt();
            } while (!(select1 >= 0 && select1 <= 2));

            do
            {
                Console.WriteLine("0 - warrior, 1 - arrcher, 2 - mage");
                select2 = ReadInt();
            } while (!(select2 >= 0 && select2 <= 2));

            characters[0].Role = (Role)select1;
            characters[1].Role = (Role)select2;

            Console.WriteLine();
            for (int i = 0; i < characters.Count; i++)
                Console.WriteLine(characters[i].ToString());
            Console.WriteLine();

            IRole.Battle(characters[0], characters[0].Role, characters[1], characters[1].Role);
            
            Console.ReadKey();
            return;
        }
        public static int ReadInt()
        {
            string str;

            do str = Console.ReadLine();
            while (!int.TryParse(str, out _));

            return int.Parse(str);
        }
    }
}

