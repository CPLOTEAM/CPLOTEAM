using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Anthem.CP.LO.WCFService.DataContracts
{
    [DataContract]
    public class RegisterUserResponse : IResponse
    {
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
