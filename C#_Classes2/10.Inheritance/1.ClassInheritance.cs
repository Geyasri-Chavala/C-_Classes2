using System;
using System.Xml.Linq;

namespace InheritanceExample
{
    // Base class
    class Animal
    {
        public void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }
    // Derived class
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("The dog barks.");
        }
    }
    // Another derived class
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("The cat meows.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Speak(); // Inherited method
            dog.Bark();  // Dog's own method
            Cat cat = new Cat();
            cat.Speak(); // Inherited method
            cat.Meow();  // Cat's own method
        }
    }
}

namespace Family
{
    class Father
    {
        public string Name { get; set; }

        public Father()
        {
            Name = "Pavan";
            Console.WriteLine($"Father constructor: My name is {Name}");
        }

        public Father(string kidName)
        {
            Name = "Pavan";
            Console.WriteLine($"Father constructor: My name is {Name}, my kid name is {kidName}");
        }
    }

    class Child : Father
    {
        public Child()
        {
            Console.WriteLine($"Child constructor: My father is {Name}");
        }

        public Child(string childName) : base(childName)
        {
            Console.WriteLine($"Child constructor: My father is {Name}, and I am {childName}");
            Console.WriteLine(this);  // this = Child object
        }
    }

    class Program
    {
        static void Main()
        {
            Child child = new Child("GeyaSri");
        }
    }
}

