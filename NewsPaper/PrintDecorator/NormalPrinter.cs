using NewsPaper.Journal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.PrintDecorator
{
    public class NormalPrinter : IPrintInfo
    {
        public IPrintInfo GetInnerInstance()
        {
            return this;
        }

        public void PrintInfo(BaseJournal baseJournal)
        {
            Console.WriteLine(baseJournal.ToString());
        }
    }
}
