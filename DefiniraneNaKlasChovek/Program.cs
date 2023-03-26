using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneNaKlasChovek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person firstperson = new Person();
            Person secondperson = new Person();
            Person thirdperson = new Person();
            Console.Write("Въведи името на 1вия човек: ");
            firstperson.Name = Console.ReadLine();
            Console.Write("Въведи възраст на 1вия човек: ");
            firstperson.Age = int.Parse(Console.ReadLine());
            Console.Write("Въведи името на 2рия човек: ");
            secondperson.Name = Console.ReadLine();
            Console.Write("Въведи възраст на 2рия човек: ");
            secondperson.Age = int.Parse(Console.ReadLine());
            Console.Write("Въведи името на 3тия човек: ");
            thirdperson.Name = Console.ReadLine();
            Console.Write("Въведи възраст на 3тия човек: ");
            thirdperson.Age = int.Parse(Console.ReadLine());
            firstperson.IntoroduceYourself();
            secondperson.IntoroduceYourself();
            thirdperson.IntoroduceYourself();
        }
    }
}
