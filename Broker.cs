using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubExtensible
{
    /// <summary>
    /// Broker's responsible:
    /// 1. Recieve message from the Publisher (with 'topic' and 'content')
    /// 2. Send message to respective Subscribers who has subscribed on 'topic'
    /// </summary>
    public class Broker
    {
        public Broker()
        {

        }
        public Queue<Message> buffer = new Queue<Message>();
        public ISubscriber[] subscribers = new ISubscriber[2];
        public void Forward()
        {
            while (buffer.Count != 0)
            {
                Message tempMessage = buffer.Dequeue();
                for (int i = 0; i < subscribers.Length; i++)
                {
                    for (int j = 0; j < subscribers[i].topics.Length; j++)
                    {
                        if (tempMessage.topic == subscribers[i].topics[j])
                        {
                            subscribers[i].messages.Enqueue(tempMessage);                            
                        }
                    }
                    subscribers[i].Update();
                }
            }
        }
    }
}
