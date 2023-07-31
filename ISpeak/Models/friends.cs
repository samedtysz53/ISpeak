using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ISpeak.Models
{
    public class friends
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FID { get; set; }
        public int friend_ID { get; set; }
        public int User_ID { get; set; }
        public string Status { get; set; }

    }
}