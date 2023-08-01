using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ISpeak.Models
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Description { get; set; }
        public string Date_of_birth { get; set; }
        public string DATE_OF_REGISTRATION { get; set; }
        public string gender { get; set; }
        public string Country { get; set; }


    }
}