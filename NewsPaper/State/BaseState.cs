using NewsPaper.Journal;
using NewsPaper.PublishStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.State
{
    public interface BaseState
    {
        void GoNext(BaseJournal baseJournal);
        void GetEditingProgress();
        void GetPrintingProgress();
        void StartPublish(BaseJournal baseJournal);
        void Publish(SubscriberInfo subscriber ,string stateNotif , BasePublishStrategy basePublishStrategy);
        void StartPrint(BaseJournal baseJournal);
    }
}
