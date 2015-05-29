using ToDo.BLL.Helpers;
using ToDo.DAL;
using User = ToDo.BOL.Entity.User;

namespace Starter
{
    class Program
    {
        static void Main()
        {
            //Console.ReadKey();
            //var client = new RestClient();
            //client.BaseUrl = new Uri("http://localhost:6309/MyService.svc/json");

            //var request = new RestRequest();

            //IRestResponse response = client.Execute(request);

            //response.ToString();

            var us = new UserHelper();
            us.CreateUser(new User(){FirstName = "Ivan", LastName = "Petrov", Email = "adfgadg", Password = "sagadg"});
        }
    }
}
