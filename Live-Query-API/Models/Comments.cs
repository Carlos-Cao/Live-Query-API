using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Live_Query_API.Models
{
    public class Comments
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int commentID { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string comment { get; set; }

        [Required]
        public int questionID { get; set; }
    }
}
