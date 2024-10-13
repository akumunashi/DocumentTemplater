using System;

namespace Database.Domain
{
    public class Log
    {
        public virtual int Id { get; set; }
        public virtual string Method { get; set; }
        public virtual string Message { get; set; }
        public virtual DateTime DateAction { get; set; }
    }
}
