using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anthem.CP.LO.WCFService.DataContracts.InBound
{
    public class Error
    {
        public int Code { get; set; }
        public string Message { get; set; }
    }
}
