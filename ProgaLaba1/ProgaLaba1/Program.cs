using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace Laba1;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            var t = new Program();
            Console.WriteLine("If you want to see Task1 input (1), Task2 - (2), Task3 - (3)");
            string input = Console.ReadLine()!;
            if (input == "1")
            {
                t.Task1();
            }
            else if (input == "2")
            {
                t.Task2();
            }
            else if (input == "3")
            {
                t.Task3();
            }
            else
            {
                throw new Exception("You input not correct argument");
            }
            Console.WriteLine("Do you want to end?(y/n)");
            if(Console.ReadLine() == "y")
            {
                break;
            }
        }
    }

    public void Task1()
    {
        string file = "C:\\Users\\Feday\\OneDrive\\Рабочий стол\\Laba1.txt";
        string[] array = new string[100];
        List<string> list = new List<string>();
        StreamReader sr = new StreamReader(file);
        string line = sr.ReadLine()!;
        sr.Close();
        array = line.Split(" ");
        list.AddRange(array);
        list.Reverse();
        StreamWriter sw = new StreamWriter(file);
        foreach(string s in list) 
        {
            sw.Write(s + " ");
        }
        sw.Close();
        
    }
    public void Task2()
    {
        Dictionary<char, int> dict1 = new Dictionary<char, int>()
        {
            {'a',100},
            {'b',200},
            {'c',300}
        };
        Dictionary<char, int> dict2 = new Dictionary<char, int>()
        {
            {'b',200},
            {'a',300},
            { 'd', 400}
        };
        foreach(KeyValuePair<char,int> d in dict1)
        {
            if (dict2.ContainsKey(d.Key))
            {
                dict2[d.Key] += dict1[d.Key];
            }
            else
            {
                dict2.Add(d.Key, d.Value);
            }
        }
        var newdict = dict2.OrderBy(i => i.Key);
        foreach (KeyValuePair<char,int> d in newdict )
        {
            Console.WriteLine(d.Key + ": " + d.Value);
        }
        string json =JsonConvert.SerializeObject(dict2);
        Console.WriteLine(json);

    }

    public void Task3()
    {
        List<int> list = new List<int>();
        List<int> listout = new List<int>();
        Random random = new Random();
        Console.WriteLine("List input:");
        for (int i = 0; i < 10; i++)
        {
            list.Add(random.Next(-50,50));
            Console.Write(list[i]+"\t");
        }
        Console.WriteLine("\n" + "List output:");
        var newlist = list.OrderBy(i => i);
        foreach (int i in newlist)
        {
            if(i % 2 == 0 && i > 0)
            {
                listout.Add(i);
            }
        }
        if (listout.Count == 0) 
        {
            Console.WriteLine("List do not have pairs of non-negative numbers");
        }
        var newlist2 = listout.OrderByDescending(i => i);
        foreach (int i in newlist2)
        {
            Console.WriteLine(i + "\t");
        }
    }
}