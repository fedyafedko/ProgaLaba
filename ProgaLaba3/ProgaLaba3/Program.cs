using System;


namespace Laba3;
class Program 
{
    static void Main(string[] args)
    {
        Predator predator = new Predator(new Tooth(32), new Claw(5));
        Console.WriteLine(predator);
        predator.Sleep();
        predator.Growl();
        predator.Eat();
        predator.Run();
        Console.ReadKey();
    }
}