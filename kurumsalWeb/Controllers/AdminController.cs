using kurumsalWeb.Models;
using kurumsalWeb.Models.DataContext;
using kurumsalWeb.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kurumsalWeb.Controllers
{
    public class AdminController : Controller
    {
        KurumsalDBContext db = new KurumsalDBContext();
        // GET: Admin
        public ActionResult Index()
        {
            var sorgu = db.Kategori.ToList();
            return View(sorgu);
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var login = db.Admin.Where(x => x.Eposta == admin.Eposta).SingleOrDefault();
            if(login.Eposta==admin.Eposta && login.Sifre == admin.Sifre)
            {
                Session["adminid"] = login.AdminId;
                Session["eposta"] = login.Eposta;
                return RedirectToAction("Index","Admin");
            } 

            ViewBag.Uyari = "Kullanıcı adı yada şifre yanlış";
            return View();

        }
        public ActionResult Logout()
        {
            Session["adminid"] = null;
            Session["eposta"] = null;
            Session.Abandon();
            return RedirectToAction("Login", "Admin");
        
        }
    }
}