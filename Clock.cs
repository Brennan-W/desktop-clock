using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClock
{
    public partial class Clock : Form
    {
        private ClockInternals _clock;
        private ClockInternals.Time _currentTime => _clock.CurrentTime;
        private string _currentMinute => MakeTwoDigits(_currentTime.Minute.ToString());
           
        private string _currentHour => MakeTwoDigits(_currentTime.Hour.ToString());

        private string MakeTwoDigits(string text)
        {
            return text.Length == 1 ? 0 + text : text;
        }
        private string _currentSecond => MakeTwoDigits(_currentTime.Second.ToString());
        
        public Clock()
        {
            InitializeComponent();
            // Set Colors
            this.labelColon.BackColor = Color.Transparent;
            this.labelHour.BackColor = Color.Transparent;
            this.labelMinute.BackColor = Color.Transparent;

            // Start Clock
            _clock = new ClockInternals();
            this.labelHour.Text = _currentHour;
            this.labelMinute.Text = _currentMinute;
            this.labelSecond.Text = _currentSecond;

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 100; //wait one minute
            timer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimedEvent);
            timer.AutoReset = true;
            timer.Start();
        }

        private void OnTimedEvent(object sender, EventArgs e)
        {

            //Debug.WriteLine("The _clock has been updated");

            /* Multi-Threading Challange:
             *  For Windows Froms, the UI is created on a separte thread from
             *  the timer being used. To address this, a dummy method of type
             *  MethodIvoker is Invoked on the control in order to return to 
             *  the main thread temporarily and udpate the _clock.
             */
            if (_clock.HourUpdated)
            {
                this.labelHour.Invoke((MethodInvoker)delegate
                {
                    this.labelHour.Text = _currentHour;
                });

                _clock.HourUpdated = false;
            }
            if (_clock.MinuteUpdated)
            {
                this.labelMinute.Invoke((MethodInvoker)delegate
                {
                    this.labelMinute.Text = _currentMinute;
                });
                _clock.MinuteUpdated = false;
            }
            if (_clock.SecondUpdated)
            {
                this.labelSecond.Invoke((MethodInvoker)delegate
               {
                   this.labelSecond.Text = _currentSecond;
               });
                _clock.SecondUpdated = false;
            }

        }
    }
}
