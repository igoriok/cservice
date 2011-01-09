using System;
using System.Runtime.Serialization;

namespace Domain.Models
{
    [DataContract(IsReference = true)]
    public class Client
    {
        [DataMember]
        public virtual int ID { get; set; }

        [DataMember]
        public virtual ClientState State { get; set; }

        [DataMember]
        public virtual float Credit { get; set; }
    }
}
