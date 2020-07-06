using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.Journal
{
    class Sport : BaseJournal
    {
        private Sport(string headName) : base()
        {
            Name = "Sport".Trim().ToLowerInvariant();
            DateEstablished = DateTime.Now.ToString();
            Hashcode = this.GetHashCode().ToString();
            Head = headName;
        }

        private static Sport instance = null;

        public static Sport CreateInstance(string headName)
        {
            if (instance == null)
            {
                instance = new Sport(headName);
            }
            return instance;
        }
    }
}
