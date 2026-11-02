using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1101_modulo7_2
{
    public class Logger
    {
        private static Logger _istanza;
        private static readonly object _lock = new object();

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                if (_istanza == null)
                    lock (_lock)
                        if (_istanza == null)
                            _istanza = new Logger();

                return _istanza;
            }
        }

        public void Log(string messaggio)
        {
            Console.WriteLine("LOG: " + messaggio);
        }
    }
}
