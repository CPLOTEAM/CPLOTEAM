using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Anthem.CP.LO.WCFService.DataContracts.OutBound
{    
    [DataContract]
    public class RegisterUserResponse : IOutBoundResponse
    {
        [DataMember]
        public string uniqueIdentifierId { get; set; }
        [DataMember]
        public bool flag { get; set; }
        [DataMember]
        public string message { get; set; }
        public bool Success { get; set; }
    }
}
