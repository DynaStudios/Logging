using System;
using System.IO;

namespace DynaStudios.Logging.Appender
{
    public class FileLogger : AbstractAppender, IDisposable, ILoggingAppender
    {
        private StreamWriter _streamWriter;
        private readonly String _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public override void Initialize()
        {
            if (_filePath != null)
            {
                _streamWriter = new StreamWriter(_filePath, true) { AutoFlush = true };
            }
            base.Initialize();
        }

        public override void Debug(string message)
        {
            _streamWriter.WriteLine("[{0}] [DEBUG] {1}", DateTime.Now, message);
        }

        public override void Info(string message)
        {
            _streamWriter.WriteLine("[{0}] [INFO] {1}", DateTime.Now, message);
        }

        public override void Warn(string message)
        {
            _streamWriter.WriteLine("[{0}] [WARN] {1}", DateTime.Now, message);
        }

        public override void Error(string message)
        {
            _streamWriter.WriteLine("[{0}] [ERROR] {1}", DateTime.Now, message);
        }

        public override void Fatal(string message)
        {
            _streamWriter.WriteLine("[{0}] [FATAL] {1}", DateTime.Now, message);
        }

        public void Dispose()
        {
            _streamWriter.Flush();
            _streamWriter.Close();
        }
    }
}
