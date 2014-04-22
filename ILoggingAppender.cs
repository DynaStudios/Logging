using System;

namespace DynaStudios.Logging
{
    public interface ILoggingAppender
    {
        void Handle(Loglevel loglevel, String message);

        void Debug(string message);

        void Info(string message);

        void Warn(string message);

        void Error(string message);

        void Fatal(string message);
    }
}