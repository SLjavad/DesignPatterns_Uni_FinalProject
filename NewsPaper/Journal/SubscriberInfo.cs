using NewsPaper.Subscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.Journal
{
    public class SubscriberInfo
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string BirthDate { get; set; }
        public int Gender { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"Fullname : {FullName}\nBirthDate : {BirthDate}\nGender : {Gender}\nStatus : {Status}";
        }
    }
}
