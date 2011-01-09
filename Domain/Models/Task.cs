using System;

namespace Domain.Models
{
    public class Task
    {
        public virtual int ID { get; set; }
        public virtual User User { get; set; }
        public virtual string Description { get; set; }
    }
}
