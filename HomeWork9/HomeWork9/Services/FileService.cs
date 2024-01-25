using Microsoft.VisualBasic;

namespace HomeWork9.Services
{
    internal class FileService : IFileService
    {
        public void WriteFile(string directoryPath)
        {
            string formattedDateTime = DateTime.Now.ToString("MM.dd.yyyy hh.mm.ss.fff tt");
            string filePath = Path.Combine(directoryPath, $"{formattedDateTime}.txt");
            File.WriteAllText(filePath, Logger.Instance().GetLogs());
        }

        public void DeleteFourthOldestFile()
        {
            string directoryPath = "C:\\Users\\julie.medkova\\Desktop\\ProjectC\\testrepo\\HomeWork9\\HomeWork9\\bin\\Debug\\net8.0\\logs";

            if (Directory.Exists(directoryPath))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
                FileInfo[] files = directoryInfo.GetFiles();

                if (files.Length > 3)
                {
                    var oldestFiles = files.OrderBy(f => f.CreationTime);

                    int filesToDeleteCount = files.Length - 3;

                    foreach (var fileToDelete in oldestFiles.Take(filesToDeleteCount))
                    {
                        try
                        {
                            File.Delete(fileToDelete.FullName);
                            Console.WriteLine($"Deleted file: {fileToDelete.FullName}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error deleting file {fileToDelete.FullName}: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine($"Directory not found: {directoryPath}");
            }
        }
    }
}
