using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.FilterTable.Models;

namespace MVC.FilterTable.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<UserModel> model = GetUsers();
            return View(model);
        }

        public PartialViewResult SearchUser(string searchText)
        {
            List<UserModel> model = GetUsers();
            var result = model.Where(a => a.Name.ToLower().Contains(searchText) || a.Age.ToString().Contains(searchText)).ToList();

            return PartialView("_GridView", result);
        }
        public List<UserModel> GetUsers()
        {
            List<UserModel> listModel = new List<UserModel>
            {
                new UserModel { Id = 1, Name = "Jack", Age = 25, Profesion = "Teacher" },
                new UserModel { Id = 2, Name = "Richard", Age = 21, Profesion = "Bus Driver" },
                new UserModel { Id = 3, Name = "Michael", Age = 33, Profesion = "Developer" },
                new UserModel { Id = 4, Name = "David", Age = 30, Profesion = "Musician" },
                new UserModel { Id = 5, Name = "Michael", Age = 29, Profesion = "Musician" },
                new UserModel { Id = 6, Name = "Martin", Age = 29, Profesion = "Developer" },
                new UserModel { Id = 7, Name = "David", Age = 38, Profesion = "Actor" },
                new UserModel { Id = 8, Name = "Oliver", Age = 25, Profesion = "Musician" },
                new UserModel { Id = 9, Name = "Michael", Age = 33, Profesion = "Musician" },
            };

            return listModel;
        }

        
    }
}