using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;
using ToDo.PL.WPF.Models;
using DataFormat = System.Windows.DataFormat;

namespace ToDo.PL.WPF.REST_Helpers
{
    class UserRestHelper
    {
        readonly static RestClient client = new RestClient("http://localhost:14846/api") { FollowRedirects = false };
       static void CreateUser(User user)
        {
            RestRequest request = new RestRequest("UserHelperApi", Method.POST) { RequestFormat = DataFormat.Json };
            request.AddBody(user);
            client.Execute(request);
        }

        static private void EditUser(User user)
        {
            RestRequest request = new RestRequest("UserHelperApi", Method.PUT) { RequestFormat = DataFormat.Json };
            request.RequestFormat = DataFormat.Json;
            request.AddBody(user);
            client.Execute(request);
        }

        static void DeleteUser(int id)
        {
            var request = new RestRequest("UserHelperApi/{id}", Method.DELETE);
            request.AddParameter("id", id);
            client.Execute(request);
        }

        static User GetUserById(int id)
        {
            RestRequest request = new RestRequest("UserHelperApi/{id}", Method.GET);
            request.AddParameter("id", id);
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<User>(response.Content);
        }

        static Case GetCaseById(int id)
        {
            RestRequest request = new RestRequest("CaseHelperApi/{id}", Method.GET);
            request.AddParameter("id", id);
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<Case>(response.Content);
        }

        static IEnumerable<User> GetAllUsers()
        {
            RestRequest request = new RestRequest("UserHelperApi", Method.GET);
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<IEnumerable<User>>(response.Content);
        }
    }
}
