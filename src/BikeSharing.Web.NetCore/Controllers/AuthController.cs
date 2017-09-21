using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using BikeSharing.Web.Configuration;

namespace BikeSharing.Web.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }

		private string authMessage;

		public ActionResult About()
		{
			string message = "Fabrikam App Description Page";

			this.ViewBag.Message = message;

			return View();
		}

		public ActionResult Help()
		{
			ViewBag.Message = Helper.GetMessageFor(authMessage);
			return View();
		}

	}
}