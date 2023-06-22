using Microsoft.VisualBasic;
using System;
using System.Reflection.Emit;


namespace SimpleLogger
{
    public class SimpleLogger
    { 
        public string LogFilePath { get; set; }

        public enum Severity
        {
            VeryLow,
            Low,
            Mid,
            High,
            ExtremyHigh,
        };

         public bool WriteToLog(DateTime eventTime,string whatHappend, Severity level)
        {
            try
            {
                var logMessage = ($"{DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt")}, {whatHappend}, {level}");
                return false;
            }
            catch 
            {
                return false;
            }
        }
       
    }
}
    