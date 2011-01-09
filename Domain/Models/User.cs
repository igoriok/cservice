using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Domain.Models
{
    [DataContract]
    public class User
    {
        [DataMember]
        public virtual int ID { get; set; }

        [DataMember]
        public virtual bool IsVisible { get; set; }
    }
}
