using NewsPaper.Journal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.PublishStrategy
{
    public interface BasePublishStrategy
    {
        void Send(SubscriberInfo subscriber, string statusNotif);
    }
}
