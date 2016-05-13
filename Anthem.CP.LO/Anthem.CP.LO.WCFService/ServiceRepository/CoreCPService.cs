using Anthem.CP.LO.WCFService.DataContracts.OutBound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Anthem.CP.LO.WCFService.ServiceRepository
{
    public class CoreCPService : ICoreCPService
    {
        private const string AddUSER_URL = "data/addnewuser";
        private const string CLAIMSEARCH_URL = "data/claimSearch?";

        public RegisterUserResponse AddNewUser(RegisterUserRequest request)
        {
            var coreResponse = RESTWebHttpClient.MakePutRequest<RegisterUserRequest, RegisterUserResponse>(AddUSER_URL, request);
            if (coreResponse != null)
                return (RegisterUserResponse)coreResponse;
            else
                return new RegisterUserResponse { Success = false };
        }

        public ClaimSearchResponse SearchClaim(ClaimSearchRequest request)
        {
            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("id", request.Id));
            var coreResponse = RESTWebHttpClient.MakeGetRequest<ClaimSearchResponse>(CLAIMSEARCH_URL, data);
            if (coreResponse != null)
                return (ClaimSearchResponse)coreResponse;
            else
                return new ClaimSearchResponse { Success = false };
        }
    }
}