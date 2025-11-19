using System;

class ProductDetails
{
    // Fields → variables inside the class that store values
    string productName = "Wireless Mouse";
    string productBrand = "LogiTech";
    string productPrice = "899 INR";
    string productManufacturedDate = "Jan-10-2025";

    DateTime productAddedTime = DateTime.Now;

    // Method to show message
    void ShowMessage(string name, string brand)
    {
        Console.WriteLine(this); // current instance
        Console.WriteLine($"Product: {this.productName}, Brand: {brand}");
    }

    // Method 1: passing multiple parameters
    void FullProductDetails(string name, string brand, string price, string mfgDate, DateTime addedTime)
    {
        // Not printing anything (same as your original code)
    }

    // Method 2: method expecting entire object
    void FullProductDetails2(ProductDetails details)
    {
        // Not printing anything (same as your code)
    }

    static void Main(string[] args)
    {
        // non-static members → accessed using instance (object)
        ProductDetails product1 = new ProductDetails();

        string name = product1.productName;
        string brand = product1.productBrand;

        product1.ShowMessage(name, brand);

        // Creating another object using object initializers
        ProductDetails product2 = new ProductDetails()
        {
            productName = "Bluetooth Keyboard",
            productBrand = "HP",
            productPrice = "1299 INR",
            productManufacturedDate = "Feb-20-2025",
            productAddedTime = DateTime.Now
        };

        // Call methods
        product2.FullProductDetails(product2.productName, product2.productBrand,
                                    product2.productPrice, product2.productManufacturedDate,
                                    product2.productAddedTime);

        product2.FullProductDetails2(product2);

        Console.WriteLine("Program Completed");
    }
}
