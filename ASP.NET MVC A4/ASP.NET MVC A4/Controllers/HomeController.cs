using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NETMVCA4.Models;
using ASP.NETMVCA4.DAL.Data;
using ASP.NETMVCA4.DAL.Repositories;

namespace ASP.NET_MVC_A4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {           

            return View();
        }
    }
}