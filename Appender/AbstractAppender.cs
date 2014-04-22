using System.ComponentModel;

namespace DynaStudios.Logging.Appender
{
    public abstract class AbstractAppender
    {
        private bool _initiated = false;

        public void Handle(Loglevel loglevel, string message)
        {
            if (!_initiated)
            {
                Initialize();
            }

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

        public virtual void Initialize()
        {
            _initiated = true;
        }

        public abstract void Debug(string message);
        public abstract void Info(string message);
        public abstract void Warn(string message);
        public abstract void Error(string message);
        public abstract void Fatal(string message);
    }
}