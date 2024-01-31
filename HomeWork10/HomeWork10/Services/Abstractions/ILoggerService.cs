using HomeWork10.Models;

namespace HomeWork10.Services.Abstractions;

public interface ILoggerService
{
    void Log(LogType logType, string massage);
}