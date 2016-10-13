
namespace DefineClass
{
    using System.Collections.Generic;
    using System;

    class GSM
    {
        private static GSM iPhone4S;
        private const decimal priceOfCall = 0.37M;


        public string Model { get; private set; }
        public string Manufacturer { get; private set; }
        public double Price { get; private set; }
        public string Owner { get; private set; }

        List<Call> callHistory = new List<Call>();

        internal static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }

            set
            {
                iPhone4S = value;
            }
        }

        internal List<Call> CallHistory
        {
            get
            {
                return callHistory;
            }

            set
            {
                callHistory = value;
            }
        }

        public GSM(string model, string manufacturer)
        {
            Model = model;
            Manufacturer = manufacturer;

        }
        public GSM(string model, string manufacturer, double price)
            : this(model, manufacturer)
        {
            Price = price;
        }

        public GSM(string model, string manufacturer, string owner)
            : this(model, manufacturer)
        {
            Owner = owner;
        }

        public GSM(string model, string manufacturer, double price, string owner)
            : this(model, manufacturer)
        {
            Price = price;
            Owner = owner;
        }

        public override string ToString()
        {
            return $"Manufacturer: {Manufacturer} model: {Model } price: {Price} owner: {Owner}";
        }

        public void AddtoHistory(DateTime dateTimeOfCall, ulong phoneNumber, int durationCall)
        {
            callHistory.Add(new Call(dateTimeOfCall, phoneNumber, durationCall));
        }

        public void DellFromHistory(DateTime dateTimeOfCall)
        {
            callHistory.RemoveAll(x => x.DateTimeOfCall == dateTimeOfCall);
        }

        public void ClearHistory()
        {
            callHistory.Clear();
        }

        public decimal CalculatePhoneBill(decimal ratePerMin = priceOfCall)
        {
            double minutes = 0;
            foreach (var call in callHistory)
            {
                minutes += Math.Ceiling(((double)call.DurationOfCall / 60));
            }
            return (decimal)minutes * ratePerMin;
        }
    }
}
