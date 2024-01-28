namespace HomeWork9
{
    internal class Logger
    {
        private static Logger? instance;
        private static string log = "";

        private Logger() { }

        public static Logger Instance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        public void Error(string logMessage)
        {
            Log(logMessage, "error");
        }
        public void Warning(string logMessage)
        {
            Log(logMessage, "warning");
        }
        public void Info(string logMessage)
        {
            Log(logMessage, "info");
        }

        private void Log(string logMessage, string logType)
        {
            var message = $"{DateTime.Now}: {logType}: {logMessage} \n";
            log += message;
            Console.Write(message);
        }

        internal string GetLogs()
        {
            return log;
        }
    }
}
