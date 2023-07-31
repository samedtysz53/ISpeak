using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ISpeak.Models
{
    public class Messages
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessagesID { get; set; }
        public int SETID { get; set; }
        public int GETID { get; set; }
        public string Subject { get; set; }
        public DateTime time { get; set; }


    }
}