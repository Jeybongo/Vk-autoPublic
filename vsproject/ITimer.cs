using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkPoster
{   
    //delegate for timer event
    delegate void TimerHandler();

    interface ITimer
    {
        //raise when timer is ticked
        event TimerHandler onTimer;

        void start();
        void stop();
    }
}
