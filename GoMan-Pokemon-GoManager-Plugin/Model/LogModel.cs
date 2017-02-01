﻿using System;
using GoPlugin;
using MethodResult = GoMan.Model.MethodResult;

namespace GoMan.Model
{
    public class LogModel : Log
    {
        public DateTime LogTime;

        public LogModel(LoggerTypes loggerType, string message, Exception ex = null) : base(loggerType, message, ex)
        {
            LogTime = DateTime.Now;
        }

        public override string ToString()
        {
            return Message;
        }
    }
}
