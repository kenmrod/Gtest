using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Sys
{
    public class LoggerRecord
    {
        public DateTime TimeStamp { get; set; }
        public Logger.MessageType MessageType { get; set; }
        public String MessageDetails { get; set; }

        public LoggerRecord()
        {
            TimeStamp = DateTime.Now;
            MessageType = Logger.MessageType.NUL;
            MessageDetails = "";
        }

        public LoggerRecord( DateTime timeStamp, Logger.MessageType messageType, String messageDetails)
        {
            TimeStamp = timeStamp;
            MessageType = messageType;
            MessageDetails = messageDetails;
        }
    }
}
