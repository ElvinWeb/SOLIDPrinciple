using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Models
{
    public class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("can be work");
        }
    }
}
