using ProgaLaba3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3;

class Tooth:BodySize
{
    public int Teeth;

    public Tooth(int teeth)
    {
        Size = teeth;
    }

    public override string ToString()
    {
        return $"Teeth (size={Size})";
    }

}
