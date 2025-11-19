using System;

//Passing a  parameter to constructor
class Student
{
    string name = "Default Name";

    public Student(string newName)
    {
        Console.WriteLine("Constructor called...");
        Console.WriteLine("Old Name: " + this.name);

        this.name = newName;   // update name
    }

    static void Main()
    {
        Student s1 = new Student("Geya");
        Console.WriteLine("Updated Name: " + s1.name);
    }

    // Output:
    // Constructor called...
    // Old Name: Default Name
    // Updated Name: Geya


    //Passing multiple parameters

    class Student2
    {
        string name;
        int age;
        public Student2(string studentName, int studentAge)
        {
            name = studentName;
            age = studentAge;
        }
        static void Main()
        {
            Student2 s2 = new Student2("Geya", 21);
            Console.WriteLine("Name: " + s2.name);
            Console.WriteLine("Age: " + s2.age);
        }
        // Output:
        // Name: Geya
        // Age: 21


        // Default constructor
        class Car
        {
            string brand;
            int year;

            public Car()   // default constructor
            {
                brand = "Toyota";
                year = 2020;
            }

            static void Main()
            {
                Car c1 = new Car();
                Console.WriteLine(c1.brand); // Toyota
                Console.WriteLine(c1.year);  // 2020
            }
            // Output:
            // Toyota
            // 2020


            //constructor updating a field
            class Employee
            {
                string role = "Intern";

                public Employee(string newRole)
                {
                    Console.WriteLine("Old Role: " + role);
                    role = newRole;
                }

                static void Main()
                {
                    Employee emp1 = new Employee("Software Developer");
                    // Output: Software Developer
                }
            }



        }

    }


}