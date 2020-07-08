using NewsPaper.Journal;
using NewsPaper.Subscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.Adapter
{
    public class SubscriberAdapter : ITarget
    {
        private readonly AdapteeService adaptee;

        public SubscriberAdapter(AdapteeService adaptee)
        {
            this.adaptee = adaptee;
        }

        public SubscriberInfo Convert(PersonalInformation personalInformation , int id)
        {
            return adaptee.Convert(personalInformation, id);
        }
    }
}
