using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anthem.CP.LO.WCFService.DataContracts.InBound
{
    interface IInBoundRequest
    {
        string MessageId { get; set; }
    }
}
