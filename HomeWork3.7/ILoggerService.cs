namespace HomeWork3._7;

public interface ILoggerService
{
    public void Log(string message);
    event LoggerService.LoggerEventHandler OnBackupRequired;
}