using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMaster.Models
{
    public class Specialization
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string SpecName { get; set; }

        public ICollection<Master> Masters { get; set; }

        public Specialization()
        {
            Masters = new List<Master>();
        }
    }
}
