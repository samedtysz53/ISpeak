using ISpeak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISpeak.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Email,string Password) 
        {
            using (var Context=new DbContexts()) 
            {
                var Query=Context.Users.FirstOrDefault(u => u.Email == Email && u.Password==Password);
                if (Query != null) 
                {
                    Session["Email"] = Email;
                    return View("Home");
                   
                }
                else 
                {
                    ViewBag.error = "Kullanıcı adı veye şifre hatalı";
                    return View();
                }
            }
                
        }

    
        [HttpPost]
        
        public ActionResult Create(string UserName, string Email,string Password,string Description, DateTime? Date_of_birth, DateTime? DATE_OF_REGISTRATION,string gender,string Country) 
        {
            using (var Context=new DbContexts()) 
            {
                DateTime dt = DateTime.Now;
                Users user = new Users();
                user.UserName=UserName;
                user.Email= Email;
                user.Password= Password;
                user.Description= Description;
                user.Date_of_birth= Date_of_birth.ToString();
               
                user.DATE_OF_REGISTRATION = dt.ToString();
                user.gender= gender;
                user.Country= Country;
                Context.Users.Add(user);
                Context.SaveChanges();
                return View("Home");
            }
         
        }
        [HttpGet]
        public ActionResult Home() 
        {
            return View();
        }
    }
}