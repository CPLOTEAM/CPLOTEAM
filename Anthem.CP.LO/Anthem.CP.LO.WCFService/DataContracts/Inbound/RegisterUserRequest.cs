using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Anthem.CP.LO.WCFService.DataContracts.InBound
{
    [DataContract]
    public class RegisterUserRequest : IInBoundRequest
    {
        [DataMember]
        public User UserInfo { get; set; }
        [DataMember]
        public string MessageId { get; set; }
    }
}
