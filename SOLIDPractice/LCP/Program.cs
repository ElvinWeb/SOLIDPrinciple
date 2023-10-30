using LCP.Models;

namespace LCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bat bat = new Bat();
            bat.MakeSound();
            bat.Fly();

            Animal lion = new Lion();
            lion.MakeSound();
            lion.Eat();
        
        }
    }
}