using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASP.NETMVCA4.Models;
using ASP.NET_MVC_A4.Context;
using ASP.NETMVCA4.Contracts.Repositories;
using ASP.NETMVCA4.Models;


namespace ASP.NET_MVC_A4.Controllers
{
    public class GameConsolesController : Controller
    {
        IRepositoryBase<GameConsole> consoles;

        public GameConsolesController()
        { }

        public GameConsolesController(IRepositoryBase<GameConsole> consoles)
        {
            this.consoles = consoles;

        }

        public ActionResult Index()
        {
            var model = consoles.GetAll();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var console = consoles.GetById(id);
            return View(console);
        }
    }
}
