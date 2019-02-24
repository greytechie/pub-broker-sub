using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubExtensible
{
    class Publisher
    {
        public Publisher()
        {

        }
        public void Publish(Message newMessage, Broker Broker)
        {
            Broker.buffer.Enqueue(newMessage);
        }
    }
}
