using ISP.Models;

namespace ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            robot.Work();

            Human human = new Human();  
            human.Work();
            human.Sleep();
            human.Eat();
        }
    }
}