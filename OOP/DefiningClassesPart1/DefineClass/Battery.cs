
namespace DefineClass
{
    class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        Enums.BatteryType batteryType;

        public Battery(string model)
        {
            this.model = model;
        }

        public Battery(string model, double hoursTalk)
            :this(model)
        {
            this.hoursTalk = hoursTalk;
        }

        public Battery(double hoursIdle, string model)
            :this(model)
        {
            this.hoursIdle = hoursIdle;
        }
        public Battery(string model, double hoursTalk, double hoursIdle)
            :this(model)
        {
            this.hoursTalk = hoursTalk;
            this.hoursIdle = hoursIdle;
        }
    }
}
