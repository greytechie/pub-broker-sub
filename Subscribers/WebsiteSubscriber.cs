using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubExtensible.Subscribers
{
    class WebSiteSubscriber : ISubscriber
    {
        public string[] topics { get; set; }
        public Queue<Message> messages { get; set; }

        public WebSiteSubscriber()
        {
            this.topics = new string[2];
            this.messages = new Queue<Message>();
        }

        public void Listen(string newTopic, int index)
        {
            topics[index] = newTopic;
        }
        public void Update()
        {
            Print();
        }

        /// <summary>
        ///     This is the customized function
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < topics.Length; i++)
            {
                
                while (messages.Count != 0)
                {
                    Message newMessage = messages.Dequeue();
                    var unit = newMessage.topic == "Temperature" ? "Celcius" : "Pascal";
                    Console.WriteLine(String.Format("Website Recieved Measurement: {0} \n {1} {2}", newMessage.topic, newMessage.value, unit));
                }
            }
        }
    }
}
