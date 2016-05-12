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
            RegisterUserResponse response = new RegisterUserResponse();
            var coreResponse = RESTWebHttpClient.MakePutRequest<RegisterUserRequest, RegisterUserResponse>(addUserUrl, request);
            return response;
        }
    }
}