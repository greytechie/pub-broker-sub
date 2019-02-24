using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubExtensible
{
    public class Message
    {
        public string topic;
        public int value;
        public Message(string topic, int value)
        {
            this.topic = topic;
            this.value = value;
        }
    }
}
