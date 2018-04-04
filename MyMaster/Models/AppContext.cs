using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyMaster.Models
{
    public class AppContext : DbContext
    {
        public AppContext() : base ("Connection")
        { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Master> Masters { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Specialization> Specs { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Application> Applications { get; set; }
    }
}