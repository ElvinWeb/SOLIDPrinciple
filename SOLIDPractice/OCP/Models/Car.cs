using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Models
{
    public class Car : Vehicle
    {
        public override int BasePrice { get; } = 1000;

        public override double CalculateInsurancePremium(int count)
        {
           
            return BasePrice * count;
        }
    }
}
