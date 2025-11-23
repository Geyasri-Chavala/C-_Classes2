using System;

namespace InterfaceInheritanceBasics
{
    interface IDetails
    {
        string EmpName { get; set; }
        string GetLocation();
    }

    interface IJobInfo
    {
        int GetAge();
    }

    // Inheriting both interfaces
    interface IFullInfo : IDetails, IJobInfo
    {
        string GetRole();
    }

    class Employee : IFullInfo
    {
        public string EmpName { get; set; }

        public Employee(string name)
        {
            EmpName = name;
        }

        public string GetLocation() => "Hyderabad";

        public int GetAge() => 22;

        public string GetRole() => "Software Developer";
    }

    class Program
    {
        static void Main()
        {
            Employee emp = new Employee("GeyaSri");

            Console.WriteLine(emp.EmpName);
            Console.WriteLine(emp.GetLocation());
            Console.WriteLine(emp.GetAge());
            Console.WriteLine(emp.GetRole());
        }
    }
}
