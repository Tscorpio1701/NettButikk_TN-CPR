using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NettButikk_Oppg2.Model;
using NettButikk_Oppg2.BLL;

namespace NettButikk_Oppg2.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult AdminListe()
        {
            var AdminDb = new AdminBLL();
            List<Admin> hentAdmins = AdminDb.HentAlleAdmins();

            if (Session["Innlogget"] == null)
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["Innlogget"];
                bool ok = (bool)Session["Innlogget"];
                if (ok) return View(hentAdmins);
            }
            return RedirectToAction("Home");
        }

        public ActionResult AdminDetaljer(int id)
        {
            var AdminDb = new AdminBLL();
            var enAdmin = AdminDb.hentEnAdmin(id);

            if (Session["Innlogget"] == null)
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["Innlogget"];
                bool ok = (bool)Session["Innlogget"];
                if (ok) return View(enAdmin);
            }
            return RedirectToAction("Home");
        }

        public ActionResult LeggTilAdmin()
        {
            if (Session["Innlogget"] == null)
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["Innlogget"];
                bool ok = (bool)Session["Innlogget"];
                if (ok) return View();
            }
            return RedirectToAction("Home");
        }

        [HttpPost]
        public ActionResult LeggTilAdmin(Admin innAdmin)
        {
            if (ModelState.IsValid)
            {
                var Admin = new AdminBLL();
                bool insertOk = Admin.leggTilAdmin(innAdmin);
                if (insertOk)
                {
                    return RedirectToAction("AdminListe");
                }
            }
            if (Session["Innlogget"] == null)
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["Innlogget"];
                bool ok = (bool)Session["Innlogget"];
                if (ok) return View();
            }
            return RedirectToAction("Home");
        }

        public ActionResult EndreAdmin(int id)
        {
            var AdminDb = new AdminBLL();
            Admin enAdmin = AdminDb.hentEnAdmin(id);

            if (Session["Innlogget"] == null)
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["Innlogget"];
                bool ok = (bool)Session["Innlogget"];
                if (ok) return View(enAdmin);
            }
            return RedirectToAction("Home");
        }

        [HttpPost]
        public ActionResult EndreAdmin(int id, Admin endreAdmin)
        {
            if (ModelState.IsValid)
            {
                var Admin = new AdminBLL();
                bool endringOk = Admin.endreAdmin(id, endreAdmin);
                if (endringOk)
                {
                    return RedirectToAction("AdminListe");
                }
            }
            return View();
        }

        public ActionResult SlettAdmin(int id)
        {
            var AdminDB = new AdminBLL();
            Admin enAdmin = AdminDB.hentEnAdmin(id);

            if (Session["Innlogget"] == null)
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["Innlogget"];
                bool ok = (bool)Session["Innlogget"];
                if (ok) return View(enAdmin);
            }
            return RedirectToAction("Home");
        }

        [HttpPost]
        public ActionResult SlettAdmin(int id, Admin slettId)
        {
            if (ModelState.IsValid)
            {
                var Admin = new AdminBLL();
                bool slettOk = Admin.slettAdmin(id);
                if (slettOk)
                {
                    return RedirectToAction("AdminListe");
                }
            }
            return View();
        }

        public ActionResult Home()
        {
            if (Session["Innlogget"] == null)
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["Innlogget"];
            }
            return View();
        }

        public ActionResult LoggInn()
        {
            if (Session["Innlogget"] == null)
            {
                Session["Innlogget"] = false;
                ViewBag.InnLogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["Innlogget"];
            }
            return View();
        }

        [HttpPost]
        public ActionResult LoggInn(Admin innBruker)
        {
            var db = new AdminBLL();
            if (db.adminsjekk(innBruker))
            {
                Session["Innlogget"] = true;
                ViewBag.Innlogget = true;
                return RedirectToAction("AdminPage");
            }
            else
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
                return View();
            }
        }

        public ActionResult AdminPage()
        {
            if (Session["Innlogget"] == null)
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["Innlogget"];
                bool ok = (bool)Session["Innlogget"];
                if (ok) return View();
            }
            return RedirectToAction("LoggInn");
        }

        public ActionResult LoggUt()
        {
            bool innlogget = (bool)Session["Innlogget"];
            if (innlogget)
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
            }
            return RedirectToAction("Home");
        }

    }
}