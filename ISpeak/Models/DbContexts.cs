using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace ISpeak.Models
{
    public class DbContexts:DbContext
    {
        public DbContexts() : base("Connection") 
        {
        
        }
        public DbSet<friends> Friends { get; set; }
        public  DbSet<Users> Users { get; set; }
        public DbSet<Messages> Messages { get; set; }

    }
}