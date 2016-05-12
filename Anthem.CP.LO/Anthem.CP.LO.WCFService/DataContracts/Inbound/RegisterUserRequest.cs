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
        public User UserInfo { get; set; }
        public string MessageId { get; set; }
    }
}
