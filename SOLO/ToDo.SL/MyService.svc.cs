using System.Runtime.Serialization;

namespace ToDo.SL
{
    public class MyService : IMyService
    {

        public string XMLData(string id)
        {
            return "Your requested product " + id;
        }

        public string JSONData(string id)
        {
            return "Your requested product " + id;
        }


        public User JSONUser()
        {
            return new User() { Name = "Vasya", Age = 51 };
        }
    }
    [DataContract]
    public class User
    {
        [DataMember(Order = 1)]
        public string Name { get; set; }
        [DataMember(Order = 2)]
        public int Age { get; set; }
    }
}
