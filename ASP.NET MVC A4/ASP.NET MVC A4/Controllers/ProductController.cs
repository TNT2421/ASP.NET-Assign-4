using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_A4.Controllers
{
    public class ProductController : Controller
    {
        public class ProductsController : Controller
        {

            IRepositoryBase<Product> products;
            IRepositoryBase<Basket> baskets;
            BasketService basketService;

            public ProductsController(IRepositoryBase<Customer> customers, IRepositoryBase<Product> products, IRepositoryBase<Basket> baskets)
            {
                this.customers = customers;
                this.products = products;
                this.baskets = baskets;
                basketService = new BasketService(this.baskets);
            }



            // GET: Products
            public ActionResult Index()
            {
                var model = products.GetAll();
                return View(model);
            }

            public ActionResult Details(int id)
            {
                var product = products.GetById(id);
                return View(product);
            }

            public ActionResult AddToBasket(int id)
            {
                basketService.AddToBasket(this.HttpContext, id, 1);//always add one to the basket
                return RedirectToAction("BasketSummary");
            }
            public ActionResult BasketSummary()
            {
                var model = basketService.GetBasket(this.HttpContext);
                return View(model.BasketItems);
            }


        }
    }
    }
