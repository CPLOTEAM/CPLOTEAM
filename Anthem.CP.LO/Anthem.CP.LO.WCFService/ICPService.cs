using Anthem.CP.LO.WCFService.DataContracts.InBound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Anthem.CP.LO.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICPService
    {

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Users/Validate", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ValidateUserResponse ValidateUser(ValidateUserRequest request);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Users/AddNew", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        RegisterUserResponse RegisterUser(RegisterUserRequest request);

        [OperationContract]
        [WebGet(UriTemplate = "Users", ResponseFormat = WebMessageFormat.Json)]
        GetUsersResponse GetUsers();
    }
}
