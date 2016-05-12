using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anthem.CP.LO.WCFService.DataContracts.OutBound
{    
    public class RegisterUserRequest : IOutBoundRequest
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailId { get; set; }
        public string password { get; set; }        
    }
}
