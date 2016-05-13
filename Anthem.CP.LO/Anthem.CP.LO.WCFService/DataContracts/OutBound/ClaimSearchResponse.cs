using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Anthem.CP.LO.WCFService.DataContracts.OutBound
{
    public class ClaimSearchResponse: IOutBoundResponse
    {
        public string claimid { get; set; }
        public string claimtype { get; set; }
        public string claimStatus { get; set; }        
        public string message { get; set; }
        public bool Success { get; set; }
    }
}