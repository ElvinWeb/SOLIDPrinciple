using OCP.Models;

namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle CarVehicle = new Car();
            CarVehicle.CalculateInsurancePremium(2);

            Vehicle MotorCyclevehicle = new Motorcycle();
            MotorCyclevehicle.CalculateInsurancePremium(3);

        }
    }
}