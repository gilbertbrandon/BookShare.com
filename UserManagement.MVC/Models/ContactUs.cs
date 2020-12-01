using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagement.MVC.Models
{
    public class ContactUs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Comments { get; set; }
        

    }
}
