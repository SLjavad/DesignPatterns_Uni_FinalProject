using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper.Constants
{
    public class Commands
    {
        public const string PRINT_INFO = "/printinfo";
        public const string ADD_Q = "/addq";
        public const string REMOVE_Q = "/removeq";
        public const string ADD_STAR = "/addstar";
        public const string REMOVE_STAR = "/removestar";
        public const string CREATE_MODEL = "/createmodel";
        public const string SUBSCRIBE = "/subscribe";
        public const string CREATE_CHARACTER = "/createcharacter";
        public const string GET_EDITING_PROGRESS = "/geteditingprogress";
        public const string GET_PRINTING_PROGRESS = "/getprintingprogress";
        public const string START_PRINTING = "/startprinting";
        public const string START_PUBLISHING = "/startpublishing";
        public const string PUBLISH = "/publish";
        public const string SET_PUBLISHING_METHOD = "/setpublishingmethod";
        public const string CHECK_SUBSCRIBER_STATUS = "/checksubscriberstatus";
    }
}
