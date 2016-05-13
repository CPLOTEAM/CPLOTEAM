using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Anthem.CP.LO.WCFService.DataContracts.OutBound
{
    public class ClaimSearchRequest: IOutBoundRequest
    {
        public string Id { get; set; }
    }
}