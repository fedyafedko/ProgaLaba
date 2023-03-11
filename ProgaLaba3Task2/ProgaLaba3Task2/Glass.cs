using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2;

class Glass : Sort
{
    public  Glass(int size, string name) : base(size, name)
    {
        base._size = size;
        base._name = name;
    }

    public override void SizeSort(List<Sort> garbage, int input)
    {
        throw new NotImplementedException();
    }

    public override void WasteSort(List<Sort> garbage)
    {
        Console.WriteLine("Glass:");
        var plasticSort = garbage.OfType<Glass>().ToList();
        foreach (Glass obj in plasticSort)
        {
            Console.WriteLine($"Name:{obj._name} Size:{obj._size}");
        }
    }
}
