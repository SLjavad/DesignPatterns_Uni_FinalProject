using NewsPaper.Journal;
using NewsPaper.PublishStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.State
{
    public class Editing : BaseState
    {
        public void StartPublish(BaseJournal baseJournal)
        {
            Console.WriteLine("Wrong State");
        }


        public void StartPrint(BaseJournal baseJournal)
        {
            GoNext(baseJournal);
            Console.WriteLine("State has changed to printing");
        }

        public void GoNext(BaseJournal baseJournal)
        {
            baseJournal.SetState(new Printing());
        }

        public void Publish(SubscriberInfo subscriber, string stateNotif, BasePublishStrategy basePublishStrategy)
        {
            Console.WriteLine("Wrong State");
        }

        public void GetEditingProgress()
        {
            Console.WriteLine(new Random().Next(0, 100));
        }

        public void GetPrintingProgress()
        {
            Console.WriteLine("Wrong State");
        }
    }
}
