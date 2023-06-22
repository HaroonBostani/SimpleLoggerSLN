using System;

namespace SimpleLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var loggerObj = new SimpleLogger { LogFilePath = @"C:\LogfileDir\" };

            loggerObj.WriteToLog(DateTime.Now, "xxxxx", SimpleLogger.Severity.High);
        }
    }
}
