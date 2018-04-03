using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyMaster.Models
{
    public class Service
    {
        public int ServiceId { get; set; }

        public string Name { get; set; }

        public int MasterId { get; set; }
        public Master Master { get; set; }

        public ICollection<Application> Applications;

        Service()
        {
            Master = new Master();
            Applications = new List<Application>();
        }
    }
}