using System;
using System.IO;

public class FileIO
{

    public void LearnFileReading()
    {
        string filePath = "../README.md";
        if (File.Exists(filePath))
        {
            string fileContent = File.ReadAllText(filePath);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(fileContent);
            Console.ResetColor();
            return;
        }
        Console.WriteLine("File doesnot exist");
    }

    public void LearnFileWriting()
    {
        string filePath = "test.txt";
        string fileContent = "ajhdajdhjas asdjasgd ajsgdhasda jsgda sdajshgd ashd ";
        File.WriteAllText(filePath, fileContent);
    }

    public void LearnFileInfo()
    {
        string filePath = "test.txt";
        FileInfo fileInfo = new FileInfo(filePath);
        var size = fileInfo.Length;
        var createDate = fileInfo.CreationTime;

        Console.WriteLine(filePath);
        Console.WriteLine($"Size: {size}");
        Console.WriteLine($"Created date: {createDate}");

    }

    public void LearnDirectory()
    {
        string folderPath = "MBM";
        Directory.CreateDirectory(folderPath);
        Console.WriteLine("Do you want to delete the MBM folder? Press y to delete");
        string confirm = Console.ReadLine();
        if (confirm == "y")
        {
            Directory.Delete(folderPath);
        }
    }

    //HW: Create a folder "Nepal" within that create 10 sufolders
    // Every subfolders should contain a file Test.txt with subfolder name as a content


}