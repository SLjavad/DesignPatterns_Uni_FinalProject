using NewsPaper.Journal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.PublishStrategy
{
    public class OnlineDelivery : BasePublishStrategy
    {
        public void Send(SubscriberInfo subscriber, string statusNotif)
        {
            subscriber.Status = statusNotif;
            Console.WriteLine($"Online : We Sent Notif to Character {subscriber.Id}");
        }
    }
}
