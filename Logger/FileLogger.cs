using System;
using System.IO;

namespace Logger
{
    /*
    FileLogger class should take in a path to a file to write the log message to. When its Log method is called, 
    it should append messages on their own line in the file. The output should include all of the following:
    The current date/time ❌✔
    The name of the class that created the logger ❌✔
    The log level ❌✔
    The message ❌✔
    The format may vary, but an example might look like this "10/7/2019 12:38:59 AM FileLoggerTests Warning: Test message
    */
    
    public class FileLogger : BaseLogger {

        private string Path {get;}

        public FileLogger(string path) {
            if (path == null) throw new ArgumentNullException(nameof(path));

            Path = path;
        }

        public override void Log(LogLevel logLevel, string message)
        {
            // TODO: implement Log method

            File.AppendAllText(Path, DateTime.Now.ToString("MM'/'dd'/'yyyy HH':'mm':'ss tt" + nameof(ClassName) + " " + logLevel + ": " + message + Environment.NewLine));
        } 
    }
}