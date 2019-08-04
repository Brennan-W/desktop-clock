# Desktop Clock

This is a simple clock written in C# as a test of C# and Windows desktop applications. As of now, it simple tells the time. 

### Planned Features:

- Themes
- Auto-resizing labels based on window size
- 12-hour or 24-hour formats
- Time zone support
- Countdown timer

## Basic Function

The main form ```Clock``` inherits from ```System.Windows.Forms```.  This form has a timer that checks with the ```ClockInternals``` class every 100 milliseconds to see if anything has changed. The ```ElaspedEventHandler``` of the form check with the instance of ```ClockInternals``` to see if the the hours, minutes, or seconds have changed since the clock was last checked. If so, the current thread that the timer is running is interrupted to return to the UI thread and update the correct label on the main form.

```c#
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
    timer.Elapsed += new
    System.Timers.ElapsedEventHandler(OnTimedEvent);
    timer.AutoReset = true;
    timer.Start();
}
```



## Clock Internals

The clock "runs" off of a custom class ```ClockInternals```. This class works with a timer set to go off every second. The event set to the timer is equivalent to the second hand ticking. Once this happens, ```UpdateSecond()``` is called and gets the current second from the static property ```DateTime.Now```. If the second was 59 before updating, then the minute needs to be updated as well. The same process applies to the hours. Essentially, the timer triggers a chain of necessary updates to match ```DateTime.Now```.

```c#
public void Run()
{
	Timer secondTimer = new Timer();
    secondTimer.Interval = 1000; //wait one second
    secondTimer.Elapsed += new
    ElapsedEventHandler(SecondHandTickEvent);
    secondTimer.AutoReset = true;

    // Start Timer
    secondTimer.Start();
}
```



Mostly for the sake of learning, the time on the internals is stored in a struct that contains the hour, minute and second.

```c#
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
```

