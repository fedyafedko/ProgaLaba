using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task2;

abstract class Sort
{
    protected int _size;

    protected string _name;

    private List<object> garbage = new List<object>();

    public Sort(int size, string name) 
    {
        _size = size;
        _name = name;
    }
    public string Name
    {
        get { return _name; }
    }

    public int Size
    {
        get { return _size; }
    }
    public abstract void WasteSort(List<Sort> garbage);
    public abstract void SizeSort(List<Sort> garbage, int input);
    
}
