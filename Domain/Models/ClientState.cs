using System;
using System.Runtime.Serialization;

namespace Domain.Models
{
    [DataContract]
    public enum ClientState
    {
        [EnumMember]
        New,

        [EnumMember]
        InWork,

        [EnumMember]
        Closed
    }
}
