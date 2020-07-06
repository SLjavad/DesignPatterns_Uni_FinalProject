using NewsPaper.Journal;
using NewsPaper.PublishStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.State
{
    public class Printing : BaseState
    {
        public void StartPublish(BaseJournal baseJournal)
        {
            GoNext(baseJournal);
            Console.WriteLine("State Has changed to Publishing");
        }

        public void StartPrint(BaseJournal baseJournal)
        {
            Console.WriteLine("Wrong State");
        }

        public void GoNext(BaseJournal baseJournal)
        {
            baseJournal.SetState(new Publishing());
        }

        public void Publish(SubscriberInfo subscriber, string stateNotif, BasePublishStrategy basePublishStrategy)
        {
            Console.WriteLine("Wrong State");
        }

        public void GetEditingProgress()
        {
            Console.WriteLine("Wrong State");
        }

        public void GetPrintingProgress()
        {
            Console.WriteLine(new Random().Next(0, 100));
        }
    }
}
