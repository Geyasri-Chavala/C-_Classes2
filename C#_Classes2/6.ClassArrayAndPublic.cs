using System;

class ImageFile
{
    public string ImageName { get; set; }
    public string ImageLocation { get; set; }
    public string ImageSize { get; set; }
    public string CapturedDate { get; set; }
}

class ImageFileSystem
{
    public void ShowImageFileNamesLength(string[] imageNames)
    {
        Console.WriteLine($"Total images : {imageNames.Length}");
    }

    public void PrintEveryImageFileName(string[] imageNames)
    {
        foreach (string name in imageNames)
        {
            Console.WriteLine($"Image name is : {name}");
        }
    }

    public void PrintEveryImageFileDetails(ImageFile[] images)
    {
        foreach (ImageFile img in images)
        {
            Console.WriteLine($"Image Name    : {img.ImageName}");
            Console.WriteLine($"Image Size    : {img.ImageSize}");
            Console.WriteLine($"Location      : {img.ImageLocation}");
            Console.WriteLine($"Captured Date : {img.CapturedDate}");
            Console.WriteLine();
        }
    }
}

class ImageProgram
{
    static void Main()
    {
        ImageFileSystem imageSystem = new ImageFileSystem();

        string[] imageNames = { "Photo1.jpg", "Photo2.png", "Photo3.jpg" };
        imageSystem.ShowImageFileNamesLength(imageNames);
        imageSystem.PrintEveryImageFileName(imageNames);

        ImageFile img1 = new ImageFile()
        {
            ImageName = "HolidayPic1.jpg",
            ImageSize = "2.5MB",
            CapturedDate = "Jan-10-2025",
            ImageLocation = @"C:/Pictures"
        };

        ImageFile img2 = new ImageFile()
        {
            ImageName = "HolidayPic2.jpg",
            ImageSize = "3MB",
            CapturedDate = "Jan-12-2025",
            ImageLocation = @"C:/Pictures"
        };

        ImageFile img3 = new ImageFile()
        {
            ImageName = "HolidayPic3.jpg",
            ImageSize = "4MB",
            CapturedDate = "Jan-15-2025",
            ImageLocation = @"C:/Pictures"
        };

        ImageFile[] allImages = new ImageFile[]
        {
            img1, img2, img3
        };

        imageSystem.PrintEveryImageFileDetails(allImages);
    }
}
