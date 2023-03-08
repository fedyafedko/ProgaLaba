using ProgaLaba3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3;

class Claw:BodySize
{
    public int Claws;
    public Claw(int claws)
    {
        Size = claws;
    }

    public override string ToString()
    {
        return $"Claws (size={Size})";
    }
}
