using Embroidery_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Embroidery_website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Inspiration to my bespoke designs";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact me here.";

            return View();
        }
		public ActionResult Photos(int id)
		{
			// Default.
			string folder = "~/Images/";

			switch (id)
			{
				case 0:
					folder = "~/Images/";
					break;
				case 1:
					folder = "~/Images/Embroidery/";
					break;
				case 2:
					folder = "~/photos/Vinyl/";
					break;
			}

			return View(new Photo(folder));
		}
	}
}