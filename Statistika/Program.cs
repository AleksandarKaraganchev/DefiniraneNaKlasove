using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи брой хора: ");
            int n = int.Parse(Console.ReadLine());
            Family persons = new Family();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Добави името на човека и възрастта му разделени със (space): ");
                string[] string1 = Console.ReadLine().Split();
                string name = string1[0];
                int age = int.Parse(string1[1]);
                Person person = new Person(name, age);
                persons.MemberAdd(person);
            }
            Console.WriteLine("Хората над 30 години, с техните имена подредени по азбучен ред: ");
            Console.WriteLine("-----------------------------------------------------------------");
            persons.Print();
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}

