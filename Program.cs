using System;
using PubSubExtensible.Subscribers;

namespace PubSubExtensible
{
    class Program
    {
        static void Main(string[] args)
        {
            #region initialization
            Broker Broker = new Broker();

            Publisher Publisher = new Publisher();

            ISubscriber Website = new WebSiteSubscriber();
            ISubscriber Radio = new RadioSubscriber();
            #endregion

            #region subscription
            Website.Listen("Temperature", 0);
            Website.Listen("Pressure", 1);

            Radio.Listen("Temperature", 0);

            Broker.subscribers[0] = Website;
            Broker.subscribers[1] = Radio;
            #endregion

            while (true)
            {
                Console.WriteLine("What is the change type? (1: Temperature, 2: Pressure)");
                int typeInt = Convert.ToInt32(Console.ReadLine());
                var typeName = typeInt == 1 ? "Temperature" : "Pressure";

                Console.WriteLine("What is current value?");
                var typeMessage = Convert.ToInt32(Console.ReadLine());

                Publisher.Publish(new Message(typeName, typeMessage), Broker);

                Console.Clear();

                Broker.Forward();

                Console.WriteLine("Click again to proceed!");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
