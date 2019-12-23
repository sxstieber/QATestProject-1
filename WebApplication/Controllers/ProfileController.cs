using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models.Profile;

namespace WebApplication.Controllers
{
    public class ProfileController : Controller
    {
        public ActionResult profileView(string id)
        {
            // Verify value passed from Url is numeric.  If not, send the user home ;)
            if (!Int32.TryParse(id, out int profileID))
            {
                return RedirectToAction("Index", "Home");
            }

            // Instantiate profile model to display profile page
            ProfileModel model = new ProfileModel(Int32.Parse(id), Request.QueryString["Filter"]);
            return View("Profile", model);
        }
    }
}