using Anthem.CP.LO.WCFService.DataContracts.OutBound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Anthem.CP.LO.WCFService.ServiceRepository
{
    public class CoreCPService : ICoreCPService
    {
        private const string addUserUrl = "data/addnewuser";
        public RegisterUserResponse AddNewUser(RegisterUserRequest request)
        {
            var coreResponse = RESTWebHttpClient.MakePutRequest<RegisterUserRequest, RegisterUserResponse>(addUserUrl, request);
            if (coreResponse != null)
                return (RegisterUserResponse)coreResponse;
            else
                return new RegisterUserResponse { Success = false };
        }
    }
}