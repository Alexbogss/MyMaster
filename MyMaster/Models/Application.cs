using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyMaster.Models
{
    public class Application
    {
        public int ApplicationId { get; set; }

        public DateTime Temp { get; set; }

        public int ServiceId { get; set; }

        public int ClientId { get; set; }

        public int MasterId { get; set; }

        public string Comment { get; set; }

        public Master Master { get; set; }

        public Service Service { get; set; }

        public Client Client { get; set; }
    }
}