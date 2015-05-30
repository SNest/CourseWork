using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDo.BOL.Entity
{
    public class Event : Entity
    {
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public string Place { get; set; }

        [Required]
        public Priority Priority { get; set; }

        public int? UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public virtual ICollection<Note> Notes { get; set; } 
    }
}
