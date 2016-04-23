using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NETMVCA4.Models;
using ASP.NETMVCA4.Contracts;
using ASP.NETMVCA4.Contracts.Repositories;

namespace ASP.NET_MVC_A4.Controllers
{
    public class AdminController : Controller
    {
        IRepositoryBase<ASP.NETMVCA4.Models.GameConsole> consoles;
        IRepositoryBase<Game> games;
        IRepositoryBase<Accessory> accessories;

        public AdminController (IRepositoryBase<ASP.NETMVCA4.Models.GameConsole> consoles, IRepositoryBase<Game> games)
        {
            this.consoles = consoles;
            this.games = games;
        }

        public AdminController()
        { }

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ConsoleList()
        {
            var model = new ASP.NETMVCA4.Models.GameConsole();
            return View(model); 
        }

        // Console CRUD
        [HttpPost]
        public ActionResult CreateConsole(GameConsole gameconsole)
        {
            consoles.Insert(gameconsole);
            consoles.Commit();
            return RedirectToAction("Index");
        }

        public ActionResult EditConsole(int id)
        {
            GameConsole gameconsole = consoles.GetById(id);
            return View(gameconsole);
        }

        [HttpPost]
        public ActionResult EditConsole(GameConsole gameconsole)
        {
            consoles.Update(gameconsole);
            consoles.Commit();
            return View(gameconsole);
        }
        
        public ActionResult DetailsConsole(int id)
        {
            var gameconsole = consoles.GetById(id);
            return View(gameconsole);
        }

        public ActionResult DeleteConsole(int id)
        {
            GameConsole gameconsole = consoles.GetById(id);
            if (consoles == null)
            {
                return HttpNotFound();
            }
            return View(gameconsole);
        }

        [HttpPost, ActionName("DeleteConsole")]
        public ActionResult DeleteConsoleConfirm(int id)
        {
            consoles.Delete(consoles.GetById(id));
            consoles.Commit();
            return RedirectToAction("Index");
        }


        //Game CRUD
        public ActionResult GameList()
        {
            var model = new Game();
            return View(model);
        }

        [HttpPost]
        public ActionResult CreateGame(Game game)
        {
            games.Insert(game);
            games.Commit();
            return RedirectToAction("Index");
        }

        public ActionResult EditGame(int id)
        {
            Game game = games.GetById(id);
            return View(game);
        }

        [HttpPost]
        public ActionResult EditGame(Game game)
        {
            games.Update(game);
            games.Commit();
            return View(game);
        }

        public ActionResult DetailsGame(int id)
        {
            var game = games.GetById(id);
            return View(game);
        }

        public ActionResult DeleteGame(int id)
        {
            Game game = games.GetById(id);
            if (games == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        [HttpPost, ActionName("DeleteGame")]
        public ActionResult DeleteGameConfirm(int id)
        {
            games.Delete(games.GetById(id));
            games.Commit();
            return RedirectToAction("Index");
        }

        //Accessory CRUD
        public ActionResult AccessoryList()
        {
            var model = new Accessory();
            return View(model);
        }

        [HttpPost]
        public ActionResult CreateAccessory(Accessory accessory)
        {
            accessories.Insert(accessory);
            accessories.Commit();
            return RedirectToAction("Index");
        }

        public ActionResult EditAccessory(int id)
        {
            Accessory accessory = accessories.GetById(id);
            return View(accessory);
        }

        [HttpPost]
        public ActionResult EditAccessory(Accessory accessory)
        {
            accessories.Update(accessory);
            accessories.Commit();
            return View(accessory);
        }

        public ActionResult DetailsAccessory(int id)
        {
            var game = games.GetById(id);
            return View(game);
        }

        public ActionResult DeleteAccessory(int id)
        {
            Accessory accessory = accessories.GetById(id);
            if (accessories == null)
            {
                return HttpNotFound();
            }
            return View(accessory);
        }

        [HttpPost, ActionName("DeleteAccessory")]
        public ActionResult DeleteAccessoryConfirm(int id)
        {
            accessories.Delete(accessories.GetById(id));
            accessories.Commit();
            return RedirectToAction("Index");
        }

    }
}