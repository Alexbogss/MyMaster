using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMaster.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int MasterId { get; set; }
        [ForeignKey("MasterId")]
        public Master Master { get; set; }

        public ICollection<Application> Applications;

        Service()
        {
            Master = new Master();
            Applications = new List<Application>();
        }
    }
}
