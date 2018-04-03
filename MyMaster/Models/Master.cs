using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyMaster.Models
{
    public class Master
    {
        public int MasterId { get; set; }

        public string Surname { get; set; }
        
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

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