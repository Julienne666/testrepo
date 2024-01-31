using HomeWork10.Config;
using HomeWork10.Models;
using HomeWork10.Services.Abstractions;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace HomeWork10.Services;

public class LoggerService : ILoggerService
{
    private readonly LoggerOption _loggerOptions;

    public LoggerService(IOptions<LoggerOption> loggerOptions)
    {
        _loggerOptions = loggerOptions.Value;
    }

    public void Log(LogType logType, string massage)
    {
        var log = $"{DateTime.UtcNow} {logType} {massage}";
        Console.WriteLine(log);
        Debug.WriteLine($"write log to {_loggerOptions.Path}");
    }
}