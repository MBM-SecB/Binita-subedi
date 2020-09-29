using System.IO;
public class FileIO
{
  public void LearnFileHandling()
  {
    string filePath = (@"C:\Users\Binita Subedi\Desktop\Binita-subedi-master\README.md");
    string fileWithProject = "Generics.cs";
    
    bool isFileThere = File.Exists(filWithProject);
   if (isFileThere)
   {

   
   var fileContent = File.ReadAllLines(fileWithInProject);
   Console.WriteLine(fileContent);
   }

  }

  public void LearnFileWriting()
  {
    string filePath = "Abc.text";
    File.WriteAllText(filePath, "This is random file content.");
  }

  public void LearnFileInfo()
  {
    string filepath = "Abc.txt";
    FileInfo fileInfo = new FileInfo(filepath);

    var size = fileInfo.Length;
    var created = fileInfo.CreationTime;

    Console.WriteLine(filepath);
    Console.WriteLine($"Size: {size} bytes");
    Console.WriteLine($"Created: {createData}");
  }

  public void LearnDirectory()
  {
    string folderPath = "MBM";
    Directory.CreateDirectory(folderPath);
  }
}   