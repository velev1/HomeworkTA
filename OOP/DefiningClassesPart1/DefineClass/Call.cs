
namespace DefineClass
{
    using System;
    class Call
    {
        DateTime dateTimeOfCall;
        ulong dialledNumber;
        int durationOfCall;

        public Call()
        {

        }

        public Call(DateTime dateTimeOfCall, ulong dialledNumber, int durationOfCall)
        {
            this.dateTimeOfCall = dateTimeOfCall;
            this.dialledNumber = dialledNumber;
            this.durationOfCall = durationOfCall;
        }

        public DateTime DateTimeOfCall
        {
            get
            {
                return dateTimeOfCall;
            }

            set
            {
                dateTimeOfCall = value;
            }
        }

        public int DurationOfCall
        {
            get
            {
                return durationOfCall;
            }

            set
            {
                durationOfCall = value;
            }
        }

        public string PrintCallHistory()
        {
            return ToString();
        }
        public override string ToString()
        {
            return dateTimeOfCall + " " + dialledNumber + " " + durationOfCall;
        }
    }
}
