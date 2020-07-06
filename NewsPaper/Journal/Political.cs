using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.Journal
{
    class Political : BaseJournal
    {
        private Political(string headName) : base()
        {
            Name = "Political".Trim().ToLowerInvariant();
            DateEstablished = DateTime.Now.ToString();
            Hashcode = this.GetHashCode().ToString();
            Head = headName;
        }

        private static Political instance = null;

        public static Political CreateInstance(string headName)
        {
            if (instance == null)
            {
                instance = new Political(headName);
            }
            return instance;
        }
    }
}
