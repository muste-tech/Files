// See https://aka.ms/new-console-template for more information
try
{
   Console.WriteLine("Hello, World!");
var desktopPath =  @"C:\Users\OWNER\OneDrive\Desktop";
var txtFilePath = $"{desktopPath}\\MGQSFile.txt";
var folderPath = $"{desktopPath}\\MGQSFolder";
var docxFilePath = $"{desktopPath}\\MGQSFile.docx";
var CopiedFolder = $"{folderPath}\\MGQSFile.txt";
string fullName = "Olowoyo Mustakim Abiodun";
// Create File
File.WriteAllText(txtFilePath, string.Empty);
Console.WriteLine("File Created Successfully");
// Create Folder
Directory.CreateDirectory(folderPath);
Console.WriteLine("Folder Created Successfully");

File.Copy (txtFilePath,CopiedFolder, true);
Console.WriteLine("File Copied Successfully");

Directory.Delete(folderPath);
Console.WriteLine("Folder Deleted Successfully");



int i;

do
{
   i =0;

  File.AppendAllText(txtFilePath, fullName +Environment.NewLine);
   i++;
    
} while (i < 10);
string content =File.ReadAllText(txtFilePath);
File.WriteAllText(docxFilePath , content);
}
catch (Exception ex)
{
   
   Console.WriteLine($"An error occurred : {ex.Message} ");
}


