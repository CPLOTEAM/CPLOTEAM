using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Anthem.CP.LO.WCFService.DataContracts.InBound
{
    [DataContract]
    public class RegisterUserResponse : IInBoundResponse
    {
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public bool Success { get; set; }
        [DataMember]
        public List<Error> Errors { get; set; }

        public RegisterUserResponse() { }
        public RegisterUserResponse(bool success)
        {
            Success = success;
        }
    }
}
