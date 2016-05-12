using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Anthem.CP.LO.WCFService.DataContracts.InBound
{
    [DataContract]
    public class ValidateUserResponse : IInBoundResponse
    {
        [DataMember]
        public bool Success { get; set; }
        [DataMember]
        public List<Error> Errors { get; set; }

        public ValidateUserResponse()
        { }

        public ValidateUserResponse(bool success)
        {
            Success = success;
        }

    }
}