using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Anthem.CP.LO.WCFService.DataContracts.InBound
{
    public class ClaimSearchResponse : IInBoundResponse
    {
        public string ClaimId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimStatus { get; set; }
        public bool Success { get; set; }
        public List<Error> Errors { get; set; }
    }
}