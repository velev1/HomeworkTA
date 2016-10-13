
namespace DefineClass
{
    using System;
    using System.Linq;

    class GSMCallHistoryTest
    {
        GSM phone = new GSM("3311", "nokia");

        public GSMCallHistoryTest()
        {
            phone.AddtoHistory(DateTime.Now, 45454, 120);
            phone.AddtoHistory(DateTime.Now, 45454, 120);
            phone.AddtoHistory(DateTime.Now, 45454, 120);
            phone.AddtoHistory(DateTime.Now, 45454, 130);
            phone.AddtoHistory(DateTime.Now, 45454, 120);

            foreach (var call in phone.CallHistory)
            {
                Console.WriteLine(call.PrintCallHistory());
            }
            Console.WriteLine("Total price: " + phone.CalculatePhoneBill());
            
            var longestCall = phone.CallHistory.Max(r => r.DurationOfCall);
            phone.CallHistory.RemoveAll(r => r.DurationOfCall == longestCall);
            Console.WriteLine("Total price: " + phone.CalculatePhoneBill());

            foreach (var call in phone.CallHistory)
            {
                Console.WriteLine(call.PrintCallHistory());
            }
        }
    }
}
