using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCP.Models
{
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("can be eat");
        }

        public override void MakeSound()
        {
           Console.WriteLine("can be make spesific sound");
        }
    }
}
