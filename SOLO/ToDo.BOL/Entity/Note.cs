using System;
using System.ComponentModel.DataAnnotations;

namespace ToDo.BOL.Entity
{
    public class Note : Entity
    {
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
      
    }
}
