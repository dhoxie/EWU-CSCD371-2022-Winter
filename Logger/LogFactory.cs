namespace Logger
{
    public class LogFactory
    {
        private string LogFile {get; set;}

        public void ConfigureFileLogger(string logFile)
        {
            LogFile = logFile;
        }

        public BaseLogger CreateLogger(string className)
        {
            return new FileLogger(LogFile){ClassName = className};
        }
    }
}
