using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Stopwatch
    {
        private DateTime _startTime;
        private bool _isRunning;

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is already running.");

            _startTime = DateTime.Now;
            _isRunning = true;
            Console.WriteLine("Stopwatch started.");
        }

        public TimeSpan Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch is not running.");

            TimeSpan duration = DateTime.Now - _startTime;
            _isRunning = false;
            Console.WriteLine("Stopwatch stopped. Duration: " + duration);
            return duration;
        }
    }
}
