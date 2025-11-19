using System;


class ConstAndReadOnly
{
    // const  compile-time constant (value fixed forever)
    const string appVersion = "1.0.0";

    // readonly  runtime constant (value fixed only after constructor)
    readonly string launchDate = "Jan-01-2025";

    public ConstAndReadOnly()   //  Constructor name must match class name
    {
        // Changing readonly value in constructor  ALLOWED
        launchDate = "Feb-01-2025";

        // appVersion = "2.0";  //  NOT allowed (const cannot be changed)
    }

    public void Display()
    {
        Console.WriteLine("App Version: " + appVersion);   // 1.0.0
        Console.WriteLine("Launch Date: " + launchDate);   // Feb-01-2025
    }

    static void Main()
    {
        ConstAndReadOnly obj = new ConstAndReadOnly();
        obj.Display();
    }
}



// read only can only change in constructor....
    class Employee
    {
        readonly int employeeId;

        public Employee(int id)
        {
            employeeId = id;  // allowed
        }

        public void Update()
        {
            // employeeId = 200;   NOT allowed outside constructor
        }

        static void Main()
        {
            Employee emp = new Employee(101);
            Console.WriteLine(emp.employeeId); // 101
        }
    }


//const used for fixed values

class MathConstants
{
    const double PI = 3.14159;
    const string CompanyName = "TechWorld";

    static void Main()
    {
        Console.WriteLine(MathConstants.PI);
        Console.WriteLine(MathConstants.CompanyName);
    }
}


