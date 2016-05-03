using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Anthem.CP.LO.WCFService.DataContracts
{    
    interface IResponse
    { 
        bool Success { get; set; }        
        List<Error> Errors { get; set; }
    }
}
