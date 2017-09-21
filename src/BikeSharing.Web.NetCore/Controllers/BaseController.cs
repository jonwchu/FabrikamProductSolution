using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using BikeSharing.Web.Configuration;

namespace BikeSharing.Web.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base 
        public ActionResult Index()
        {
            return View();
        }
    }
}