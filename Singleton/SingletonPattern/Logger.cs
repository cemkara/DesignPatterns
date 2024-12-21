using Microsoft.EntityFrameworkCore;
using Singleton.Entities;
using Singleton.Entities.Context;

namespace Singleton.SingletonPattern
{
    public class Logger
    {
        private static Logger _instance;
        private static readonly object _lock = new object();
        private readonly Context _context;

        private Logger(Context context)
        {
            _context = context;
        }

        public static Logger GetInstance(Context context)
        {
            lock (_lock)
            {
                if (_instance == null)
                    _instance = new Logger(context);
            }
            return _instance;
        }

        public void Log(string message)
        {
            var log = new Log
            {
                Message = message,
                CreatedAt = DateTime.UtcNow
            };

            _context.Logs.Add(log);
            _context.SaveChanges();
        }
    }

}
