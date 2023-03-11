using Task2;
using System;

namespace Task3;

class Program 
{
    static void Main(string[] args)
    {
        Sort bottle = new Plastic(10,"bottle");
        Sort box = new Paper(20, "box");
        Sort glassJar = new Glass(3, "glass jar");
        Sort newspaper = new Paper(5, "newspaper");
        Sort bag = new Plastic(7, "cellophane bag");
        Sort vase = new Glass(9, "vase");
        List<Sort> garbage = new List<Sort>(); 
        garbage.Add(bottle);
        garbage.Add(box);
        garbage.Add(glassJar);
        garbage.Add(newspaper);
        garbage.Add(bag);
        garbage.Add(vase);
        Console.WriteLine("Input (0) for sort Plastic, Paper-(1), Glass-(2), All-(3), Size-(4)");
        string input = Console.ReadLine()!;
        if (input == "0")
        {
            bottle.WasteSort(garbage);
        }
        else if (input == "1")
        {
            box.WasteSort(garbage);
        }
        else if (input == "2")
        {
            vase.WasteSort(garbage);
        }
        else if(input == "3")
        {
            bottle.WasteSort(garbage);
            box.WasteSort(garbage);
            vase.WasteSort(garbage);
        }
        else if(input == "4")
        {
            Console.WriteLine("Input size");
            int size = int.Parse(Console.ReadLine()!);
            bottle.SizeSort(garbage, size);
            
        }
        
    }
}
