using NewsPaper.Journal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.PrintDecorator
{
    public interface IPrintInfo
    {
        void PrintInfo(BaseJournal baseJournal);
        IPrintInfo GetInnerInstance();
    }
}
