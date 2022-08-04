using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock ac = new AlarmClock();
            IAlarm ar = (IAlarm)ac;
            IClock cl = (IClock)ac;
            FuncAlarm(ar);
            FuncClock(cl);
        }

        public static void FuncAlarm(IAlarm alarm)
        {
            alarm.SetAlarm();
            alarm.Alarm();
            alarm.StopAlarm();
        }

        public static void FuncClock(IClock clock)
        {
            clock.AdjustTime();
            clock.ShowTime();
        }
    }
}
