using NewsPaper.Adapter;
using NewsPaper.PublishStrategy;
using NewsPaper.State;
using NewsPaper.Subscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.Journal
{
    public abstract class BaseJournal
    {
        public BaseJournal()
        {
            PublishStrategy = new CourierDelivery();
            CurrentState = new Editing();
            AdapterTarget = new SubscriberAdapter(new AdapteeService());

            subscribers = new List<SubscriberInfo>();
        }
        public List<SubscriberInfo> subscribers;
        public string Name { get; protected set; }
        public string DateEstablished { get; protected set; }
        public string Hashcode { get; protected set; }
        public string Head { get; protected set; }
        public BaseState CurrentState { get; protected set; }
        public BasePublishStrategy PublishStrategy { get; protected set; }
        public ITarget AdapterTarget { get; set; }
        public void SetState(BaseState baseState)
        {
            CurrentState = baseState;
        }

        public void SetPublishMethod(BasePublishStrategy basePublishStrategy , string publishName)
        {
            PublishStrategy = basePublishStrategy;
            Console.WriteLine($"{Name}'s publishing method has been set to {publishName}");
        }

        public void Subscribe(Subscriber.Subscriber subscriber)
        {
            if (subscribers.Any(x => x.Id == subscriber.Id))
            {
                Console.WriteLine("this person has been subscribed before");
                return;
            }
            SubscriberInfo subscriberInfo = AdapterTarget.Convert(subscriber.personalInformation, subscriber.Id);
            subscribers.Add(subscriberInfo);

            Console.WriteLine(subscriberInfo.ToString());
        }

        public void Unsubscribe(Subscriber.Subscriber subscriber)
        {
            var subInfo = subscribers.Find(s => s.Id == subscriber.Id);
            subscribers.Remove(subInfo);
        }

        public void SendJournalToSubscribers(string stateNotif)
        {
            foreach (SubscriberInfo subscriber in subscribers)
            {
                CurrentState.Publish(subscriber, stateNotif , PublishStrategy);
            }
            Console.WriteLine("End of Notifying");
        }

        public override string ToString()
        {
            return $"Name : {Name}\nDate Stablished: {DateEstablished}\nHashCode : {Hashcode}\nHead : {Head}";
        }
    }
}
