using System;

namespace DocumentTemplater.Interfaces
{
    public interface ILogger
    {
        void Log(string method, string message, DateTime dateAction);
    }
}
