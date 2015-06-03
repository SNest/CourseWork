using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using ToDo.BOL.Entity;
using Newtonsoft.Json;

namespace Starter
{
    class Program
    {
        static void Main()
        {
            Console.ReadKey();
            //GetUserById(5);
            //EditUser(5, new User(){FirstName = "IVAN", LastName = "TIHOMIROV"});

            IEnumerable<User> li= GetAllUsers();
            User u = GetUserById(5);
            Console.ReadKey();
        }

        void CreateUser()
        {
            
        }

        static private void EditUser(int id, User user)
        {
            var client = new RestClient("http://localhost:14846");
            client.FollowRedirects = false;
            var request = new RestRequest("api/UserHelperApi", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("id", id);
            request.AddBody(request.JsonSerializer.Serialize(user));
            client.Execute(request);
        }

        void DeleteUser(int id)
        {
            
        }

        static User GetUserById(int id)
        {
            var client = new RestClient("http://localhost:14846");
    
            var request = new RestRequest("api/UserHelperApi/{id}", Method.GET);
            request.AddParameter("id", id);
            //var queryResult = client.Execute<User>(request).Data;
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<User>(response.Content);
        }

        static IEnumerable<User> GetAllUsers()
        {
            var client = new RestClient("http://localhost:14846");
            var request = new RestRequest("api/UserHelperApi", Method.GET);
            var queryResult = client.Execute<List<User>>(request).Data;
            //return queryResult.ToList();
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<IEnumerable<User>>(response.Content);
        }
    }
}
