using Anthem.CP.LO.WCFService.DataContracts.OutBound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anthem.CP.LO.WCFService.ServiceRepository
{
    interface ICoreCPService
    {
        RegisterUserResponse AddNewUser(RegisterUserRequest request);
    }
}
