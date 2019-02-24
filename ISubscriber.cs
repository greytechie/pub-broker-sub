using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubExtensible
{
    public interface ISubscriber
    {
        string[] topics { get; set; }
        Queue<Message> messages { get; set; }

        void Listen(string newTopic, int index);
        void Update();
    }
}
