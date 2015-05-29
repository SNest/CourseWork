using System.ComponentModel.DataAnnotations;

namespace ToDo.BOL.Entity
{
    public class User : Entity
    {
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
