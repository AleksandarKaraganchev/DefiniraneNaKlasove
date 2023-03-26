using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneNaKlasChovek
{
    internal class Person
    {
        public string Name;
        public int Age;
        public void IntoroduceYourself()
        {
            Console.WriteLine($"{Name} is {Age} years old");
        }
    }
}
