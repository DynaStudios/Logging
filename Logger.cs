namespace DynaStudios.Logging
{
    public class Logger : AbstractLogger
    {
        private static Logger _instance;

        private Logger()
        {
            SetLoglevel(Loglevel.Debug);
        }

        public static Logger Instance
        {
            get { return _instance ?? (_instance = new Logger()); }
        }
    }
}