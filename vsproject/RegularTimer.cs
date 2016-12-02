using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace VkPoster
{
    class RegularTimer : ITimer
    {
        public event TimerHandler onTimer;

        private Timer _timer;
        private Double _interval;

        public RegularTimer(Double everyHour)
        {
            _interval = everyHour;
        }

        public void start()
        {
            _timer = new Timer();
            _timer.Elapsed += new ElapsedEventHandler(this.tick);
            _timer.Interval = _interval * 60 * 60 * 1000;                                            // hour -> minutes -> seconds -> milliseconds 
            _timer.Enabled = true;
        }

        public void stop()
        {
            _timer.Enabled = false;
        }

        private void tick(object sender, System.EventArgs e)
        {
            TimerHandler handler = onTimer;
            if (handler != null)
            {
                handler();
            }
        }
    }
}
