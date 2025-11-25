using System;

namespace CTM

// Polymorphism means one thing in multiple forms.
// same name but different behaviors.

// Two types of polymorphism in C#:
// 1. Compile-time Polymorphism --- before debugging  is achieved by Method Overloading-- same method name with different parameters.
// means 
{
    // Method Overloading (Compile-time Polymorphism)
    class SalaryCalculator
    {
        public double CalculateSalary(double monthlySalary)
        {
            return monthlySalary;
        }

        public double CalculateSalary(int monthlySalary)
        {
            return monthlySalary;
        }

        public double CalculateSalary(int hoursWorked, int hourlyRate)
        {
            return hoursWorked * hourlyRate;
        }

        public double CalculateSalary(double salesAmount, double commissionRate)
        {
            return salesAmount * commissionRate;
        }

        public double CalculateSalary(int hoursWorked, int hourlyRate, double bonus)
        {
            return (hoursWorked * hourlyRate) + bonus;
        }
    }

    class Program
    {
        static void Main()
        {
            SalaryCalculator salaryCalculator = new SalaryCalculator();

            double salary1 = salaryCalculator.CalculateSalary(10000.09);      // double method
            double salary2 = salaryCalculator.CalculateSalary(10000);         // int method
            double salary3 = salaryCalculator.CalculateSalary(9, 4);          // hoursWorked * hourlyRate
            double salary4 = salaryCalculator.CalculateSalary(5000, 0.1);     // salesAmount * commissionRate
            double salary5 = salaryCalculator.CalculateSalary(9, 4, 100);     // (9*4) + bonus

            Console.WriteLine($"Salary 1: {salary1}");
            Console.WriteLine($"Salary 2: {salary2}");
            Console.WriteLine($"Salary 3: {salary3}");
            Console.WriteLine($"Salary 4: {salary4}");
            Console.WriteLine($"Salary 5: {salary5}");
        }
    }
}



