using System;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Claims;


namespace Laba3;
class Predator
{
    private Tooth teeth;
    private Claw claws;

    public Predator(Tooth teeth, Claw claws)
    {
        this.teeth = teeth;
        this.claws = claws;
    }

    public void Growl()
    {
        Console.WriteLine($"Predator is growling with {claws} and {teeth}");
    }

    public void Eat()
    {
        Console.WriteLine($"Predator is eating with {teeth}");
    }

    public void Sleep()
    {
        Console.WriteLine("Predator is sleeping");
    }

    public void Run()
    {
        Console.WriteLine($"Predator is running with {claws}");
    }

    public override string ToString()
    {
        return $"Predator with {claws} and {teeth}";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Predator predator = (Predator)obj;
        return teeth.Equals(predator.teeth) && claws.Equals(predator.claws);
    }

    public override int GetHashCode()
    {
        return teeth.GetHashCode() ^ claws.GetHashCode();
    }
}
