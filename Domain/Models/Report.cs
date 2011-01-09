using System;
using System.Runtime.Serialization;

namespace Domain.Models
{
    [DataContract]
    public class Report
    {
        [DataMember]
        public virtual int ID { get; set; }

        [DataMember]
        public virtual User User { get; set; }

        [DataMember]
        public virtual Client Client { get; set; }

        [DataMember]
        public virtual DateTime Created { get; set; }

        [DataMember]
        public virtual string Description { get; set; }
    }
}
