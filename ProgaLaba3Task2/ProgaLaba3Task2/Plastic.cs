using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2;

class Plastic : Sort
{
    public Plastic(int size, string name) : base(size, name)
    {
        base._size = size;
        base._name = name;
    }
    public override void SizeSort(List<Sort> garbage, int size)
    {
        var sortSize = garbage.Where(x => x.Size > size).ToList();
        foreach (Sort obj in sortSize)
        {
            Console.WriteLine($"Name:{obj.Name} Size:{obj.Size}");
        }

    }

    public override void WasteSort(List<Sort> garbage)
    {
        Console.WriteLine("Plastic:");
        var plasticSort = garbage.OfType<Plastic>().ToList();
        foreach (Plastic obj in plasticSort)
        {
            Console.WriteLine($"Name:{ obj._name} Size:{obj._size}");
        }
    }
}
