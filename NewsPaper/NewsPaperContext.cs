using NewsPaper.Constants;
using NewsPaper.Journal;
using NewsPaper.PrintDecorator;
using NewsPaper.PublishStrategy;
using NewsPaper.State;
using NewsPaper.Subscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper
{
    public class NewsPaperContext
    {
        private List<BaseJournal> journals;
        private List<Subscriber.Subscriber> subscribers;
        private IPrintInfo printInfo;
        public NewsPaperContext()
        {
            journals = new List<BaseJournal>();
            subscribers = new List<Subscriber.Subscriber>();
            printInfo = new NormalPrinter();
        }

        public void PrintInfo()
        {
            foreach (BaseJournal item in journals)
            {
                printInfo.PrintInfo(item);
                Console.WriteLine();
            }
        }

        public void AddQ()
        {
            printInfo = new QPrinter(printInfo);
        }

        public void RemoveQ()
        {
            if (printInfo.GetType() == typeof(QPrinter))
            {
                printInfo = printInfo.GetInnerInstance();
            }
        }

        public void AddStar()
        {
            printInfo = new StarPrinter(printInfo);
        }

        public void RemoveStar()
        {
            if (printInfo.GetType() == typeof(StarPrinter))
            {
                printInfo = printInfo.GetInnerInstance();
            }
        }

        public void CreateModel(string modelName , string headName)
        {
            switch (modelName.Trim().ToLowerInvariant())
            {
                case "sport":
                    {
                        Sport sport = Sport.CreateInstance(headName);
                        if (!journals.Contains(sport))
                        {
                            journals.Add(sport);
                        }
                        break;
                    }
                case "political":
                    {
                        Political political = Political.CreateInstance(headName);
                        if (!journals.Contains(political))
                        {
                            journals.Add(political);
                        }
                        break;
                    }
                case "economical":
                    {
                        Economy economy = Economy.CreateInstance(headName);
                        if (!journals.Contains(economy))
                        {
                            journals.Add(economy);
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        public void CreateCharacter(string name , string family , string birthdate , GenderType genderType)
        {
            Subscriber.Subscriber subscriber = new Subscriber.Subscriber()
            {
                personalInformation = new PersonalInformation()
                {
                    Name = name,
                    Family = family,
                    BirthDate = birthdate,
                    Gender = genderType
                }
            };

            subscribers.Add(subscriber);
            subscriber.Id = subscribers.IndexOf(subscriber);

            Console.WriteLine($"Character {subscriber.Id} has been created");
            Console.WriteLine(subscriber.ToString());
        }

        public void Subscribe(string journalName , int id)
        {
            BaseJournal journal = journals.Find(j => j.Name == journalName.Trim().ToLowerInvariant());
            Subscriber.Subscriber subscriber = subscribers.Find(s => s.Id == id);
            journal.Subscribe(subscriber);
        }

        public void GetEditingProgress(string journalName)
        {
            BaseJournal journal = journals.Find(j => j.Name == journalName.Trim().ToLowerInvariant());

            journal.CurrentState.GetEditingProgress();
        }

        public void StartPrinting(string journalName)
        {
            BaseJournal journal = journals.Find(j => j.Name == journalName.Trim().ToLowerInvariant());

            journal.CurrentState.StartPrint(journal);
        }

        public void GetPrintingProgress(string journalName)
        {
            BaseJournal journal = journals.Find(j => j.Name == journalName.Trim().ToLowerInvariant());

            journal.CurrentState.GetPrintingProgress();
        }

        public void StartPublishing(string journalName)
        {
            BaseJournal journal = journals.Find(j => j.Name == journalName.Trim().ToLowerInvariant());

            journal.CurrentState.StartPublish(journal);
        }

        public void Publish(string journalName , string statusNotif)
        {
            BaseJournal journal = journals.Find(j => j.Name == journalName.Trim().ToLowerInvariant());

            foreach (SubscriberInfo subscriber in journal.subscribers)
            {
                journal.CurrentState.Publish(subscriber, statusNotif, journal.PublishStrategy);
            }
        }

        public void SetPublishingMode(string journalName , string publishMode)
        {
            BaseJournal journal = journals.Find(j => j.Name == journalName.Trim().ToLowerInvariant());

            switch (publishMode.Trim().ToLowerInvariant())
            {
                case "courier":
                    {
                        journal.SetPublishMethod(new CourierDelivery(), publishMode);
                        break;
                    }
                case "online":
                    {
                        journal.SetPublishMethod(new OnlineDelivery(), publishMode);
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
