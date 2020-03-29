using NLog;
using System;

namespace WarhammerProfessionApp.Utility
{
    public static class Logger
    {
        public static void Log(string target, string message, LogLevel logLevel, Exception exception)
            => logger.Log(logLevel, exception, $"{target} => {message}");

        private static readonly NLog.Logger logger = LogManager.GetCurrentClassLogger();
    }
}