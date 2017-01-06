namespace Timer_Events
{
    using System;
    using System.Threading;

    public class EventTimer
    {
        public EventTimer(int ticksCount, int interval)
        {
            this.TicksCount = ticksCount;
            this.Interval = interval;
        }

        public event EventHandler NextEvent;

        public int TicksCount { get; set; }
        public int Interval { get; set; }

        public void RunTimer()
        {
            while (this.TicksCount > 0)
            {
                this.NextEvent(this, EventArgs.Empty);
                Thread.Sleep(this.Interval);
                this.TicksCount--;
            }
        }
    }
}
