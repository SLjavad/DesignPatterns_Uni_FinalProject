using NewsPaper.Journal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.PrintDecorator
{
    public abstract class PrinterDecorator : IPrintInfo
    {
        private readonly IPrintInfo printInfo;

        public PrinterDecorator(IPrintInfo printInfo)
        {
            this.printInfo = printInfo;
        }

        public IPrintInfo GetInnerInstance()
        {
            return printInfo;
        }

        public virtual void PrintInfo(BaseJournal baseJournal)
        {
            printInfo.PrintInfo(baseJournal);
        }
    }
}
