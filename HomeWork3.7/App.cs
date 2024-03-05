namespace HomeWork3._7;

public class App
{
    private readonly ILoggerService _loggerService;
    private int counter = 0;

    public App(ILoggerService loggerService)
    {
        _loggerService =  loggerService;
        _loggerService.OnBackupRequired += LoggerServiceOnBackupRequired;
    }
    
    public void Run()
    {
        var thread1 = new Thread(DoWork);
        var thread2 = new Thread(DoWork);
        
        thread1.Start(1);
        thread2.Start(2);

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Logging completed.");
    }

    private void DoWork(object number)
    {
        var taskNumber = (int) number;
        for (int i = 1; i <= 50; i++)
        {
            _loggerService.Log($"Log entry {i} from Task {taskNumber}");
            Thread.Sleep(new Random().Next(0, 500));
        }
    }

    private void LoggerServiceOnBackupRequired()
    {
        Console.WriteLine("Backup created");
    }
}
