using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Anthem.CP.LO.WCFService.DataContracts.InBound
{
    [DataContract]
    public class GetUsersResponse : IInBoundResponse
    {
        [DataMember]
        public List<User> Users { get; set; }
        [DataMember]
        public bool Success { get; set; }
        [DataMember]
        public List<Error> Errors { get; set; }
    }
}