using Microsoft.Extensions.Options;

namespace HomeWork3._7;

using System;
using System.IO;
using System.Text;

public class LoggerService : ILoggerService
{
    public delegate void LoggerEventHandler();
    public event LoggerEventHandler OnBackupRequired;
    
    private int _logCount;
    private readonly LoggerOptions _loggerOptions;

    private readonly StringBuilder _tempLogs = new();

    public LoggerService(IOptions<LoggerOptions> loggerOptions)
    {
        _loggerOptions = loggerOptions.Value;
    }

    public void Log(string message)
    {
        lock (this)
        {
            _logCount++;
            _tempLogs.Append(message);
            _tempLogs.Append("\n");

            if (_logCount % _loggerOptions.BackupCounter == 0)
            {
                var data = _tempLogs.ToString();
                _tempLogs.Clear();

                var thread1 = new Thread(() => { WriteToFile(data); });
                thread1.Start();
            }
        }
    }

    private void WriteToFile(string message)
    {
        string backupFileName = $"Backup_{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.txt";
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string backupDirectory = _loggerOptions.Path;
        
        string backupPath = Path.Combine(baseDirectory, backupDirectory);

        if (!Directory.Exists(backupPath))
        {
            Directory.CreateDirectory(backupPath);
        }

        string filePath = Path.Combine(baseDirectory, backupDirectory, backupFileName);
        
        File.WriteAllText(filePath, message);
        OnBackupRequired();
    }
}