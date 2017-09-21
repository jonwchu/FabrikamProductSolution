using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using BikeSharing.Web.Configuration;

namespace BikeSharing.Web.Controllers
{
    public class HelpController : Controller
    {
        // GET: Help
        public ActionResult Index()
        { 
            return View();
        }

		private string helpMessage;

		public ActionResult About()
		{
			string message = "Fabrikam App Description Page";

			this.ViewBag.Message = message;

			return View();
		}

		public ActionResult Help()
		{
			ViewBag.Message = Helper.GetMessageFor(helpMessage);
			return View();
		}

	}
}