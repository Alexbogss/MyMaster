using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMaster.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }

        public ICollection<Application> Applications;

        Client()
        {
            Applications = new List<Application>();
        }
        
    }
}