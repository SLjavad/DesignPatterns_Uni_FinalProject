using NewsPaper.Journal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.Subscriber
{
    public class Subscriber
    {
        public int Id { get; set; }
        public PersonalInformation personalInformation { get; set; }

        public override string ToString()
        {
            return $"Name : {personalInformation.Name}\nFamily : {personalInformation.Family}\nBirthDate : {personalInformation.BirthDate}" +
                $"\nGender : {personalInformation.Gender}";
        }
    }
}
