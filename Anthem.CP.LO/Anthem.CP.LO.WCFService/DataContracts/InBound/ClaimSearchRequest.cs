using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Anthem.CP.LO.WCFService.DataContracts.InBound
{
    [DataContract]
    public class ClaimSearchRequest: IInBoundRequest
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string MessageId { get; set; }
    }
}