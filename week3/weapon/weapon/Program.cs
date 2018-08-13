using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weapon
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog t = new Dog("Lab");

            Console.WriteLine(t.Name);

            Console.ReadKey();
            Cat a = new Cat("tabby cat");

            Console.WriteLine(t.Name);

            Console.ReadKey();
            Snake c = new Snake("tigher");

            Console.WriteLine(t.Name);

            Console.ReadKey();
        }
    }
}
