using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Models
{
    public abstract class Vehicle
    {
        public abstract int BasePrice { get; }
        public abstract double CalculateInsurancePremium(int count);
    }
}
