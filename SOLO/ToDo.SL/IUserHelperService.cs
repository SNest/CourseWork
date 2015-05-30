using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using ToDo.BOL.Entity;


namespace ToDo.SL
{
    [ServiceContract]
    public interface IUserHelperService
    {
        [OperationContract]
        [WebInvoke(Method = "PUT",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "api/user/create")]
        void Create(User user);

        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "api/user/create/{id}")]
        void Edit(string id, User user);

        [OperationContract]
        [WebInvoke(Method = "DELETE",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "api/user/delete/{id}")]
        void Delete(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "api/user/get/{id}")]
        User GetById(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "api/user/get")]
        IEnumerable<User> GetAll();

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Xml,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "xml/{id}")]
        string XMLData(string id);
    }
}
