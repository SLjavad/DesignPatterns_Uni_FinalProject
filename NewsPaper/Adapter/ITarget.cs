using NewsPaper.Journal;
using NewsPaper.Subscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.Adapter
{
    public interface ITarget
    {
        SubscriberInfo Convert(PersonalInformation personalInformation , int id);
    }
}
