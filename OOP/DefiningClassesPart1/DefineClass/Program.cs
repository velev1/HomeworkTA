
namespace DefineClass
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var phones = new List<GSM>();
            
            var peshoPhone = new GSM("3310", "Nokia", 50, "Pesho");
            var goshoPhone = new GSM("Galaxy S6", "Samsung", 200, "Gosho");
            var toshoPhone = new GSM("p9", "Huawei", 250, "Tosho");
            GSM.IPhone4S = new GSM("s6", "Apple", 300, "Ivan");
            phones.Add(peshoPhone);
            phones.Add(goshoPhone);
            phones.Add(toshoPhone);
            phones.Add(GSM.IPhone4S);
            foreach (var phone in phones)
            {
                Console.WriteLine(phone.ToString());
            }

            GSMCallHistoryTest test = new GSMCallHistoryTest();
        }
    }
}
