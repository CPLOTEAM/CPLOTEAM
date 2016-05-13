using Anthem.CP.LO.WCFService.DataContracts.InBound;
using Anthem.CP.LO.WCFService.ServiceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Anthem.CP.LO.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CPService : ICPService
    {
        public ValidateUserResponse ValidateUser(ValidateUserRequest request)
        {
            return new ValidateUserResponse(true);
        }

        public RegisterUserResponse RegisterUser(RegisterUserRequest request)
        {
            CoreCPService coreService = new CoreCPService();
            var response = coreService.AddNewUser(new DataContracts.OutBound.RegisterUserRequest
            {
                firstName = request.UserInfo.FirstName.Trim(),
                lastName = request.UserInfo.LastName.Trim(),
                emailId = request.UserInfo.Email.Trim(),
                password = request.UserInfo.Password.Trim()
            });
            if (response == null || !response.Success)
            {
                return new RegisterUserResponse()
                {
                    Success = false,
                    Errors = new List<Error>() { new Error { Code = 500, Message = response.message } }
                };
            }
            else
            {
                return new RegisterUserResponse()
                {
                    Success = true,
                    UserId = response.uniqueIdentifierId
                };
            }
        }

        public GetUsersResponse GetUsers()
        {
            return new GetUsersResponse()
            {
                Success = true,
                Users = new List<User>{
                    new User{ Id="1",FirstName="Test",LastName="Test",Email="Test@Test.com"},
                    new User{ Id="2",FirstName="Test",LastName="Test",Email="Test@Test.com"},
                }
            };
        }

        public ClaimSearchResponse SearchClaim(ClaimSearchRequest request)
        {
            CoreCPService coreService = new CoreCPService();
            var response = coreService.SearchClaim(new DataContracts.OutBound.ClaimSearchRequest
            {
                Id = request.Id
            });
            if (response == null || !response.Success)
            {
                return new ClaimSearchResponse()
                {
                    Success = false,
                    Errors = new List<Error>() { new Error { Code = 500, Message = response.message } }
                };
            }
            else
            {
                return new ClaimSearchResponse()
                {
                    Success = true,
                    ClaimId = response.claimid,
                    ClaimStatus = response.claimStatus,
                    ClaimType = response.claimtype
                };
            }
        }
    }
}
