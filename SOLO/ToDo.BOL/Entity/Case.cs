using System;
using System.ComponentModel.DataAnnotations;

namespace ToDo.BOL.Entity
{
    public class Case : Entity
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
    }
}
