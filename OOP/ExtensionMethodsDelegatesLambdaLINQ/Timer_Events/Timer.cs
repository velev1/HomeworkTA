namespace Timer_Events
{
    using System.Threading;

    public delegate void TimerAction(string text);

    public class Timer
    {
        private TimerAction action;

        public Timer(int tickCount, int interval, TimerAction action)
        {
            this.Interval = interval;
            this.TicksCount = tickCount;
            this.action = action;
        }

        public int Interval { get; set; }
        public int TicksCount { get; set; }

        public void Run()
        {
            while (this.TicksCount > 0)
            {
                this.action(this.TicksCount.ToString());
                Thread.Sleep(this.Interval);
                this.TicksCount--;
            }
        }
    }
}
