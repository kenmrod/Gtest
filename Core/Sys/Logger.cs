using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Core.Sys
{
    public class Logger
    {
        public List<LoggerRecord> Logs = new List<LoggerRecord>();
        public enum MessageType
        {
            INF,
            ERR,
            WRN,
            STEP,
            NUL
        }
        public string LogsPath { get; set; }
        private const string INF = "INF";
        private const string ERR = "ERR";
        private const string WRN = "WRN";
        private const string STEP = "STEP";

        private string Batch = null;
        private string TotalBatch = null;


        public void WriteLine(string Message, MessageType MsgType = MessageType.NUL, Boolean IncludeInFile=true)
        {
            string newLine = null;
            if (Batch == null || TotalBatch == null)
                newLine = GetLogHeader(MsgType) + Message;
            else
                newLine = $"[Batch  {Batch} / {TotalBatch}] " +  GetLogHeader(MsgType) + Message;

            Console.WriteLine(newLine);
            if (IncludeInFile)
            {
                Logs.Add(new LoggerRecord(DateTime.Now, MsgType, Message));
            }
        }

        public void WriteLine(ITestScript TestScript, string Message, MessageType MsgType = MessageType.NUL, Boolean IncludeInFile = true)
        {
            string newLine = null;
            if (Batch == null || TotalBatch == null)
                newLine = GetLogHeader(MsgType) + Message;
            else
                newLine = $"[Batch  {Batch} / {TotalBatch}] " + GetLogHeader(MsgType) + Message;

            Console.WriteLine(newLine);
            if (IncludeInFile)
            {
                TestScript.ScriptLogger.Logs.Add(new LoggerRecord(DateTime.Now, MsgType, Message));                
            }
        }

        private string GetLogHeader(MessageType MsgType)
        {
            if (MsgType == MessageType.NUL)
            {
                return string.Empty;
            }
            return "[" + GetMsgTypeToWrite(MsgType) + "] ";
        }

        private string GetMsgTypeToWrite(MessageType MsgType)
        {
            string ret = string.Empty;
            switch (MsgType)
            {
                case MessageType.INF:
                    ret = INF;
                    break;
                case MessageType.ERR:
                    ret = ERR;
                    break;
                case MessageType.STEP:
                    ret = STEP;
                    break;
                case MessageType.WRN:
                    ret = WRN;
                    break;
                default:
                    break;
            }
            return ret;
        }

        private string GetTimeStamp()
        {
            return string.Format("{0:yyyyMMddHHmmss}", DateTime.Now);
        }

        public string TraceMessage(string CustomMessage, string ExceptionMessage, [CallerLineNumber] int LineNumber = 0)
        {
            return String.Format("[Ln {0}] {1} : {2}", LineNumber.ToString(), CustomMessage, ExceptionMessage);
        }

        public Logger SetBatch(int Batch, int TotalBatch)
        {
            this.Batch = Batch.ToString();
            this.TotalBatch = TotalBatch.ToString();
            return this;
        }
        public Logger removeBatch()
        {
            this.Batch = null;
            this.TotalBatch = null;
            return this;
        }
    }
}
