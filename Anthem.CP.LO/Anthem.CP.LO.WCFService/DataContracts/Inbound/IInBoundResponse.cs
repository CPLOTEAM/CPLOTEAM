using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Anthem.CP.LO.WCFService.DataContracts.InBound
{    
    interface IInBoundResponse
    { 
        bool Success { get; set; }        
        List<Error> Errors { get; set; }
    }
}
