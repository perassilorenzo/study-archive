using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0824_modulo4_2
{
    internal class Logger
    {
        private static Logger _istanza;
        private static object _lock = new object();

        private Logger()
        {

        }

        public static Logger Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_istanza == null) _istanza = new Logger();
                    return _istanza;

                }
            }
        }
        
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }
}
