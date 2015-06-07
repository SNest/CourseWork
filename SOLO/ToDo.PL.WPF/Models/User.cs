using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToDo.PL.WPF.Models
{
    
    public class User : PL.WPF.Models.Entity
    {
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Case> Cases { get; set; }
        public virtual ICollection<Note> Notes { get; set; }

        public User()
        {
            Events = new List<Event>();

            Cases = new List<Case>();

            Notes = new List<Note>();
        }
    }
}
