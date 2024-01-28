using HomeWork9.Models;
using HomeWork9.Services;

namespace HomeWork9
{
    internal class App
    {
        public void Run()
        {
            Actions actions = new Actions();

            for (int i = 0; i < 100; i++)
            {
                int randomNumber = new Random().Next(0, 3);

                try
                {
                    switch (randomNumber)
                    {
                        case 0:
                            actions.Start();
                            break;
                        case 1:
                            actions.Skip();
                            break;
                        default:
                            actions.Break();
                            break;
                    }
                }
                catch (BusinessException businessException)
                {
                    Logger.Instance().Warning($"Action got this custom Exception : {businessException.Message}");
                }
                catch (Exception exception)
                {
                    Logger.Instance().Error($"Action failed by a reason: {exception.Message}");
                }
            }

            FileService fileService = new FileService();
            string directoryPath = "C:\\Users\\julie.medkova\\Desktop\\ProjectC\\testrepo\\HomeWork9\\HomeWork9\\bin\\Debug\\net8.0\\logs";
            fileService.WriteFile(directoryPath);
            fileService.DeleteFourthOldestFile();
        }
    }
}
