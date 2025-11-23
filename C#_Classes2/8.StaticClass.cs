using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class Demo
{
    static int age = 20;

    static string[] GetNames()
    {
        return new string[] { "Geya", "Sri", "Chavala" };
    }

    static void Main()
    {
        Console.WriteLine("Names:");

        string[] names = Demo.GetNames();
        foreach (var n in names)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("Age: " + age);
    }
}