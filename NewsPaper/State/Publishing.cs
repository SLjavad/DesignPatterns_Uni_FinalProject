using NewsPaper.Journal;
using NewsPaper.PublishStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.State
{
    public class Publishing : BaseState
    {
        public void StartPublish(BaseJournal baseJournal)
        {
            Console.WriteLine("Wrong State");
        }

        public void Publish(SubscriberInfo subscriber, string statusNotif, BasePublishStrategy basePublishStrategy)
        {
            basePublishStrategy.Send(subscriber, statusNotif);
        }

        public void GoNext(BaseJournal baseJournal)
        {
            Console.WriteLine("It's the last state");
        }

        public void StartPrint(BaseJournal baseJournal)
        {
            Console.WriteLine("Wrong State");
        }

        public void GetEditingProgress()
        {
            Console.WriteLine("Wrong State");
        }

        public void GetPrintingProgress()
        {
            Console.WriteLine("Wrong State");
        }
    }
}
