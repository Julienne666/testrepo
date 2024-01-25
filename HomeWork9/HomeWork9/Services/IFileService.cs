namespace HomeWork9.Services
{
    internal interface IFileService
    {
        public void WriteFile(string directoryPath);
        public void DeleteFourthOldestFile();
    }
}
