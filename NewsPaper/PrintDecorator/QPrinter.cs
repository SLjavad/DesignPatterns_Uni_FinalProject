using NewsPaper.Journal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.PrintDecorator
{
    public class QPrinter : PrinterDecorator
    {
        public QPrinter(IPrintInfo printInfo) : base(printInfo)
        {
            
        }

        public override void PrintInfo(BaseJournal baseJournal)
        {
            Console.WriteLine("?");
            base.PrintInfo(baseJournal);
        }
    }
}
