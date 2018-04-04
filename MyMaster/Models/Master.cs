using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMaster.Models
{
    public class Master
    {
        [Key]
        public int MasterId { get; set; }

        [Required]
        public string Surname { get; set; }
        
        [Required]
        public string Name { get; set; }

        [MaxLength(10)]
        public string PhoneNumber { get; set; }

        [Required]
        public char Gender { get; set; }

        public string Address { get; set; } 

        public byte[] Photo { get; set; }
        
        public ICollection<Specialization> Specs { get; set; }
        
        public ICollection<Service> Services { get; set; }

        public ICollection<Application> Applications { get; set; }

        public Master()
        {
            Specs = new List<Specialization>();
            Services = new List<Service>();
            Applications = new List<Application>();
        }
        
    }
}