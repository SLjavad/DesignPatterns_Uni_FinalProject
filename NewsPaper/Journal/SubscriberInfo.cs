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
        public DateTime BirthDate { get; set; }
        public GenderType Gender { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"Fullname : {FullName}\nBirthDate : {BirthDate.ToString()}\nGender : {Gender}\nStatus : {Status}";
        }
    }
}
