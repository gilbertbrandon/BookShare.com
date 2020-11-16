using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagement.MVC.Models
{
    public class Search
    {
        [Key]
        public int SearchId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int FileId { get; set; }


        [Display(Name = "Date Uploaded")]
        public DateTime DateUploaded { get; set; }

        public string Action { get; set; }

        public int Rating { get; set; }

       
    }
}
