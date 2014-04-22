using System;
using System.Collections.Generic;

namespace DynaStudios.Logging
{
    public delegate void NewLogReceived(Loglevel loglevel, String message);

    public abstract class AbstractLogger
    {
        private readonly List<ILoggingAppender> _loggingAppender;
        public NewLogReceived LogReceived;

        protected AbstractLogger()
        {
            LogReceived = LogFired;
            _loggingAppender = new List<ILoggingAppender>();
        }

        public Loglevel CurrentLoglevel { get; private set; }

        public void Debug(string msg)
        {
            LogReceived(Loglevel.Debug, msg);
        }

        public void Debug(string format, params object[] args)
        {
            Debug(string.Format(format, args));
        }

        public void Info(string msg)
        {
            LogReceived(Loglevel.Info, msg);
        }

        public void Info(string format, params object[] args)
        {
            Info(string.Format(format, args));
        }

        public void Warn(string msg)
        {
            LogReceived(Loglevel.Warning, msg);
        }

        public void Warn(string format, params object[] args)
        {
            Warn(string.Format(format, args));
        }

        public void Error(string msg)
        {
            LogReceived(Loglevel.Error, msg);
        }

        public void Error(string format, params object[] args)
        {
            Error(string.Format(format, args));
        }

        public void Fatal(string msg)
        {
            LogReceived(Loglevel.Fatal, msg);
        }

        public void Fatal(string format, params object[] args)
        {
            Fatal(string.Format(format, args));
        }

        public void SetLoglevel(Loglevel level)
        {
            CurrentLoglevel = level;
        }

        public void RegisterLoggingAppender(ILoggingAppender loggingAppender)
        {
            if (loggingAppender == null)
                return;
            _loggingAppender.Add(loggingAppender);
            LogReceived += loggingAppender.Handle;
        }

        private void LogFired(Loglevel loglevel, string message)
        {
        }
    }
}