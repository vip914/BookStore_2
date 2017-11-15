using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore_2.Models;

namespace BookStore_2.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();

        public ActionResult Index()
        {
            var books = db.Books;
            var clients = db.Clients;
            ViewBag.Books = books;
            ViewBag.Clients = clients;
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int Id)
        {
            ViewBag.BookId = Id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase Purchase)
        {
            Purchase.Date = DateTime.Now;
            db.Purchases.Add(Purchase);
            db.SaveChanges();

            return string.Format("Спасибо, {0}, за покупку!", Purchase.Person.ToString());
        }

    
    }
}