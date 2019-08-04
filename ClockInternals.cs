using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace DesktopClock
{
    class ClockInternals
    {
        private Time _time;
        private enum TimerType { minute, hour}
        public Time CurrentTime {
            get
            {
                if (!_isMilitaryTime && _time.Hour > 12)
                {
                    _time.Hour -= 12;
                }
                return _time;
            }

        }
        public bool MinuteUpdated = false;
        public bool HourUpdated = false;
        public bool SecondUpdated = false;
        private bool _isMilitaryTime = false;
        public bool IsMiliartyTime
        {
            get { return _isMilitaryTime; }
            set
            {
                _isMilitaryTime = value;
                if (!_isMilitaryTime)
                {

                }
            }
  
        }
        public struct Time
        {
            public int Hour;
            public int Minute;
            public int Second;

            public Time(int hour, int minute, int second)
            {
                Hour = hour;
                Minute = minute;
                Second = second;
            }

            public Time(DateTime time)
            {
                Hour = time.Hour;
                Minute = time.Minute;
                Second = time.Second;
            }
        }

        public ClockInternals()
        {
            _time = new Time(DateTime.Now.ToLocalTime());
            Run();
        }

        public void Run()
        {
            Timer secondTimer = new Timer();
            secondTimer.Interval = 1000; //wait one second
            secondTimer.Elapsed += new ElapsedEventHandler(SecondHandTickEvent);
            secondTimer.AutoReset = true;

             // Start Timer
            secondTimer.Start();
        }
        public void UpdateHour()
        {
            System.Diagnostics.Debug.WriteLine("Updating hour");
            _time.Hour = DateTime.Now.Hour;
            HourUpdated = true;
        }
        public  void UpdateMinute()
        {
            System.Diagnostics.Debug.WriteLine("Updating minute");
            if (_time.Minute == 59)
            {
                UpdateHour();
            }
            _time.Minute = DateTime.Now.Minute;
            MinuteUpdated = true;

        }



        public void UpdateSecond()
        {
            _time.Second = DateTime.Now.Second;
            SecondUpdated = true;
        }

        private void HourUpdatedEvent(object source, ElapsedEventArgs e)
        {
            UpdateHour();
        }

        private void MinuteUpdatedEvent(object source, ElapsedEventArgs e)
        {
            UpdateMinute();
        }

        private void SecondHandTickEvent(object source, ElapsedEventArgs e)
        {
            if (_time.Second == 59)
            {
                UpdateMinute();
            }
            UpdateSecond();
        }


    }
}
