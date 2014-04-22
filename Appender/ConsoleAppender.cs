using System;

namespace DynaStudios.Logging.Appender
{
    public class ConsoleLogger : AbstractAppender, ILoggingAppender
    {
        public override void Debug(string message)
        {
            Console.WriteLine("[{0}] [DEBUG] {1}", DateTime.Now, message);
        }

        public override void Info(string message)
        {
            Console.WriteLine("[{0}] [INFO] {1}", DateTime.Now, message);
        }

        public override void Warn(string message)
        {
            Console.WriteLine("[{0}] [WARN] {1}", DateTime.Now, message);
        }

        public override void Error(string message)
        {
            Console.WriteLine("[{0}] [ERROR] {1}", DateTime.Now, message);
        }

        public override void Fatal(string message)
        {
            Console.WriteLine("[{0}] [FATAL] {1}", DateTime.Now, message);
        }
    }
}