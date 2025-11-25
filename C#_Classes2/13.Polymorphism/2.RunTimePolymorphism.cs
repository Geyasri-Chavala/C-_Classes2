using System;

namespace RuntimePolyContainer

//Run time Polymorphism 
// Runtime Polymorphism (Method Overriding)

    // Runtime polymorphism ( After debugging)

    // same method name -- different behaviour in child class (using virtual + override)
{

    // Base Class
    class Employee
    {
        public string Name { get; set; }
        public int HoursWorked { get; set; }
        public double HourlyRate { get; set; }

        // Virtual Method
        public virtual double CalculateSalary()
        {
            return HoursWorked * HourlyRate;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Hours Worked: {HoursWorked}");
            Console.WriteLine($"Hourly Rate: {HourlyRate}");
        }
    }

    // Derived Class 1
    class PermanentEmployee : Employee
    {
        public override double CalculateSalary()
        {
            double baseSalary = HoursWorked * HourlyRate;
            double bonus = baseSalary * 0.2; // 20% bonus
            return baseSalary + bonus;
        }
    }

    // Derived Class 2
    class ContractEmployee : Employee
    {
        public override double CalculateSalary()
        {
            double baseSalary = HoursWorked * HourlyRate;
            double deductions = baseSalary * 0.1; // 10% deduction
            return baseSalary - deductions;
        }
    }

    // Main Program
    class Program
    {
        static void Main()
        {
            // Permanent Employee
            Employee employee1 = new PermanentEmployee()
            {
                Name = "Alice",
                HoursWorked = 160,
                HourlyRate = 50
            };
            double aliceSalary = employee1.CalculateSalary();
            Console.WriteLine("Permanent Employee Salary: " + aliceSalary);

            // Contract Employee
            Employee employee2 = new ContractEmployee()
            {
                Name = "Bob",
                HoursWorked = 140,
                HourlyRate = 40
            };
            double bobSalary = employee2.CalculateSalary();
            Console.WriteLine("Contract Employee Salary: " + bobSalary);
        }
    }
}
