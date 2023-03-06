using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba;

class Fraction
{
    private int Numerator;
    private int Denominator;
    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }
    public void Show(int numerator, int denominator)
    {
        if (denominator == 1)
        {
            Console.WriteLine($"{numerator}");
        }
        else 
        {
            Console.WriteLine($"{numerator}/{denominator}");
        }
    }

    private int Gcd(int a, int b) 
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    public void Reduce()
    {
        int gcd;
        gcd=Gcd(Numerator,Denominator);

        Show(Numerator/gcd, Denominator/gcd);
    }
    public void Proper()
    {
        if(Numerator < Denominator)
        {
            Console.WriteLine("Proper fraction");
        }
        else
        {
            Console.WriteLine("Improper fraction");
        }
    }

    public void Summ(Fraction fraction)
    {

        Numerator *= fraction.Denominator;
        fraction.Numerator *= Denominator;
        Numerator += fraction.Numerator;
        Denominator *= fraction.Denominator;
        Reduce();

    }
    public void Substraction(Fraction fraction)
    {

        Numerator *= fraction.Denominator;
        fraction.Numerator *= Denominator;
        Numerator -= fraction.Numerator;
        Denominator *= fraction.Denominator;
        Reduce();

    }
    public void Multiplication(Fraction fraction)
    {

        Numerator *= fraction.Numerator;
        Denominator *= fraction.Denominator;
        Reduce();

    }
    public void Division(Fraction fraction)
    {
        int temp=fraction.Numerator;
        fraction.Numerator = fraction.Denominator;
        fraction.Denominator = temp;
        Numerator *= fraction.Numerator;
        Denominator *= fraction.Denominator;
        Reduce();

    }

    public void Equality(Fraction fraction)
    {
        fraction.Numerator = Denominator;
        Numerator = fraction.Denominator;
        if (Numerator == fraction.Numerator) 
        {
            Console.WriteLine("Equal fraction");
        }
        else
        {
            Console.WriteLine("Unequale fraction");
        }
    }
    public void SJSON(int numerator,int denominator)
    {
        string json = JsonConvert.SerializeObject(numerator);
        string jsond = JsonConvert.SerializeObject(denominator);
        Console.WriteLine($"{json}/{jsond}");
    }
    public void DJSON(string json, string jsond)
    {
        JsonConvert.DeserializeObject(json);
        JsonConvert.SerializeObject(jsond);
        Console.WriteLine($"{json}/{jsond}");
    }
}
