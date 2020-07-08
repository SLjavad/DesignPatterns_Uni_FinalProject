using NewsPaper.Journal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.PublishStrategy
{
    public class CourierDelivery : BasePublishStrategy
    {
        public void Send(SubscriberInfo subscriber, string statusNotif)
        {
            subscriber.Status = statusNotif;
            Console.WriteLine($"Curier : character {subscriber.Id} got the notif");
            Console.WriteLine();
            Console.WriteLine(subscriber.ToString());

        }
    }
}
