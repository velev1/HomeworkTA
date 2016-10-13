
namespace DefineClass
{
    using System;

    class GSMTest
    {
        GSM[] collectionOfGSM = new GSM[3];

        public GSMTest()
        {
            for (int i = 0; i < collectionOfGSM.Length; i++)
            {
                string manifacturer = Console.ReadLine();
                string model = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                string owner = Console.ReadLine();
                collectionOfGSM[i] = new GSM(model, manifacturer, price, owner);
            }

            GSM.IPhone4S = new GSM("iphone 4S", "Apple");

            for (int i = 0; i < collectionOfGSM.Length; i++)
            {
                Console.WriteLine(collectionOfGSM[i].ToString());
            }
            Console.WriteLine(GSM.IPhone4S.ToString());
        }

    }
}
