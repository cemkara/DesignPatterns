namespace Singleton.SingletonPattern
{
    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private static readonly object _lock = new object();

        private DatabaseConnection() { }

        public static DatabaseConnection Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseConnection();
                    }
                    return _instance;
                }
            }
        }
        public void Connect()
        {
            Console.WriteLine("Connection success.");
        }
    }
}
