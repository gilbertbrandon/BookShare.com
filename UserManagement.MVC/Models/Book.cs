using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.MVC.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime? Date { get; set; }

        public string UploadedBy {get; set;}

     
    }
}
