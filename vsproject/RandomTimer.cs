using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace VkPoster
{
    class RandomTimer : ITimer
    {
        public event TimerHandler onTimer;

        private Timer _timer;
        Random rand;

        public RandomTimer()
        {
            rand = new Random();
        }

        public void start()
        {
            _timer = new Timer();
            _timer.Elapsed += new ElapsedEventHandler(this.tick);
            _timer.Interval = 1000 * 60;                                                
            _timer.Enabled = true;
        }

        public void stop()
        {
            _timer.Enabled = false;
        }

        private void tick(object sender, System.EventArgs e)
        {
            if (!shouldPost()) 
            {
                return;
            }

            TimerHandler handler = onTimer;
            if (handler != null)
            {
                handler();
            }
        }

        //rand func for posting
        //approximately 50 times in one day
        //vk allows 50 posts in one day
        private bool shouldPost()
        {
            for (int i = 1; i < 6; i++)
            {
                if (rand.Next(2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
