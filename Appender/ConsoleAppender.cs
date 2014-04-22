using System;

namespace DynaStudios.Logging.Appender
{
    public class ConsoleLogger : ILoggingAppender
    {
        public void Handle(Loglevel loglevel, string message)
        {
            switch (loglevel)
            {
                case Loglevel.Debug:
                    Debug(message);
                    break;
                case Loglevel.Info:
                    Info(message);
                    break;
                case Loglevel.Warning:
                    Warn(message);
                    break;
                case Loglevel.Error:
                    Error(message);
                    break;
                case Loglevel.Fatal:
                    Fatal(message);
                    break;
            }
        }

        public void Debug(string message)
        {
            Console.WriteLine("[{0}] [DEBUG] {1}", DateTime.Now, message);
        }

        public void Info(string message)
        {
            Console.WriteLine("[{0}] {1}", DateTime.Now, message);
        }

        public void Warn(string message)
        {
            Console.WriteLine("[{0}] [WARN] {1}", DateTime.Now, message);
        }

        public void Error(string message)
        {
            Console.WriteLine("[{0}] [ERROR] {1}", DateTime.Now, message);
        }

        public void Fatal(string message)
        {
            Console.WriteLine("[{0}] [FATAL] {1}", DateTime.Now, message);
        }
    }
}