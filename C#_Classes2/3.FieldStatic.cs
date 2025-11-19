using System;

class ImageFileDetails
{
    // Fields → store information about the image file
    static string imageName = "SunsetPhoto.png";
    static string imageLocation = @"C:\Pictures\Gallery";
    static string imageSize = "5MB";
    static string createdOn = "Apr-12-2025";

    static DateTime lastOpenedTime = DateTime.Now;

    // Method to display details
    static void ShowImageInfo(string name, string location)
    {
        Console.WriteLine($"Image Name: {name}, Location: {location}");
    }

    static void Main(string[] args)
    {
        // Access static fields using class name
        string name = ImageFileDetails.imageName;
        string location = ImageFileDetails.imageLocation;
        string size = ImageFileDetails.imageSize;
        string createdDate = ImageFileDetails.createdOn;

        DateTime openedTime = ImageFileDetails.lastOpenedTime;

        // Display message
        ImageFileDetails.ShowImageInfo(name, location);
    }
}
