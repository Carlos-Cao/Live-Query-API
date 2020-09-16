using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Live_Query_API.Models
{
    public class Questions
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int questionID { get; set; }

        [Required]
        public string firstName { get; set; }

        [Required]

        public string lastName { get; set; }

        [Required]
        public string question { get; set; }

        [Required]
        public string description { get; set; }

        public ICollection<Comments> data { get; set; }
    }
}
