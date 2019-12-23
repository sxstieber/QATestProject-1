using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Profiles.Business;

using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            DatabaseService service = new DatabaseService();
            ProfileCollection collection = new ProfileCollection(service);

            return View(collection);
        }

        [HttpPost]
        public ActionResult SearchForm(SearchModel searchModel)
        {
            // Instantiate profile collection and set filter text
            DatabaseService service = new DatabaseService();
            ProfileCollection collection = new ProfileCollection(service);
            collection.FilterText = searchModel.SearchText;

            return View("Index", collection);
        }
    }
}