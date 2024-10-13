using System;
using Database.Domain;
using Database.Interfaces;
using DocumentTemplater.Interfaces;

namespace DocumentTemplater.Logging
{
    public class Logger : ILogger
    {
        private IDatabaseConnection<Log> _databaseConnection;
        public Logger(IDatabaseConnection<Log> databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        public void Log(string method, string message, DateTime dateAction)
        {
            var log = new Log
            {
                Method = method,
                Message = message,
                DateAction = dateAction
            };
            _databaseConnection.Add(log);
        }
    }
}
