using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Models
{
    public class Human : IWorker, IEater, ISleeper
    {
        public void Work()
        {
            Console.WriteLine("can be work");
        }

        public void Eat()
        {
            Console.WriteLine("can be eat");
        }

        public void Sleep()
        {
            Console.WriteLine("can be sleep");
        }
    }
}
