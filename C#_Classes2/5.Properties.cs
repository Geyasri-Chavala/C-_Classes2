using System;

class ProductInfo
{
    // Properties → store product details
    string ProductName { get; set; }
    string ProductBrand { get; set; }
    string ProductPrice { get; set; }
    string ManufacturedDate { get; set; }
    DateTime AddedToStore { get; set; }

    static void Main()
    {
        ProductInfo p = new ProductInfo();

        p.ProductName = "Bluetooth Speaker";
        p.ProductBrand = "Boat";
        p.ProductPrice = "1499 INR";
        p.ManufacturedDate = "Nov-20-2024";
        p.AddedToStore = DateTime.Now;
    }
}
