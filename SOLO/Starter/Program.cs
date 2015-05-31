using System;
using RestSharp;
using ToDo.BLL.Helpers;
using ToDo.BLL.Helpers.Concrete;
using ToDo.DAL;
using User = ToDo.BOL.Entity.User;

namespace Starter
{
    class Program
    {
        static void Main()
        {
            Console.ReadKey();
            var client = new RestClient();
            client.BaseUrl = new Uri("http://localhost:6309/UserHelperService.svc/api/user/get/4");

            var request = new RestRequest();

            IRestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);

            Console.ReadKey();

            //var us = new UserHelper();

            //Console.WriteLine(us.GetById(4).Email);
            //User u = us.GetById(4);
            //u.Email = "DDDD";
            //us.Edit(4, u);

            //Console.WriteLine(us.GetById(4).Email);
            //Console.ReadKey();

            //us.Create(new User(){FirstName = "Gosha", Email = "dfgdg", Password = "dfhhd"});
        }
    }
}
