using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anthem.CP.LO.WCFService.DataContracts.OutBound
{
    public interface IOutBoundResponse 
    {
        bool Success { get; set; }
    }
}
