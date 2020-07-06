using NewsPaper.PublishStrategy;
using NewsPaper.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.Journal
{
    class Economy : BaseJournal
    {
        private Economy(string headName) : base()
        {
            Name = "Economy".Trim().ToLowerInvariant();
            DateEstablished = DateTime.Now.ToString();
            Hashcode = this.GetHashCode().ToString();
            Head = headName;
        }

        private static Economy instance = null;

        public static Economy CreateInstance(string headName)
        {
            if (instance == null)
            {
                instance = new Economy(headName);
            }
            return instance;
        }
    }
}
