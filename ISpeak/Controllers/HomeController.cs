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

        [HttpGet]
        public ActionResult Create() 
        {
        return View();
        }
        [HttpPost]
        public ActionResult Create(string UserName, string Email,string Password) 
        {
            using (var Context=new DbContexts()) 
            {
                Users user = new Users();
                user.UserName=UserName;
                user.Email=Email;
                user.Password=Password;
                Context.Users.Add(user);
                Context.SaveChangesAsync();
                return View();
            }
         
        }
    }
}