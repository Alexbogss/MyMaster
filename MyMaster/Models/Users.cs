using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMaster.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public int HashPass { get; set; }

        public int? ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        
        public int? MasterId { get; set; }
        [ForeignKey("MasterId")]
        public Master Master { get; set; }
    }
}