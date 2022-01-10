var salesFiles = FindFiles("stores");
    
foreach (var files in salesFiles)
{
    Console.WriteLine(files);
    

}


string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
Console.WriteLine("Current directory is: "+ Directory.GetCurrentDirectory()+"\n "+ docPath);

Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");
Console.WriteLine(Path.Combine("Store","Open","yalla"));

string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";

FileInfo info = new FileInfo(fileName);
Console.WriteLine($"Full Name: {info.FullName}\nDirectory: {info.Directory}{Environment.NewLine}Extenction: {info.Extension}{Environment.NewLine}Create DATE: {info.CreationTime}");



IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        // The file name will contain the full path, so only check the end of it
        if (file.EndsWith("sales.json"))
        {
            salesFiles.Add(file);
        }
    }
    
    return salesFiles;
}