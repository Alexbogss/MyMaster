using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyMaster.Models
{
    public class Specialization
    {
        public int Id { get; set; }

        public string SpecName { get; set; }

        public ICollection<Master> Masters { get; set; }

        public Specialization() => Masters = new List<Master>();
    }
}