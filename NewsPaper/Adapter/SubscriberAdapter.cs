using NewsPaper.Journal;
using NewsPaper.Subscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.Adapter
{
    public class SubscriberAdapter : SubscriberInfo
    {
        private readonly Subscriber.Subscriber subscriber;

        public SubscriberAdapter(Subscriber.Subscriber subscriber)
        {
            this.subscriber = subscriber;
        }

        public SubscriberInfo Convert()
        {
            this.FullName = subscriber.personalInformation.Name + " " + subscriber.personalInformation.Family;
            this.BirthDate = DateTime.Parse(subscriber.personalInformation.BirthDate);
            this.Gender = subscriber.personalInformation.Gender;
            this.Id = subscriber.Id;
            return this;
        }
    }
}
