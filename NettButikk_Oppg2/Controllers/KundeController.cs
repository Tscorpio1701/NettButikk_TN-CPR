using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NettButikk_Oppg2.Model;
using System.Data.Entity.Validation;
using System.Web.Security;
using NettButikk_Oppg2.BLL;
using BLL;

namespace NettButikk_Oppg2.Controllers
{
    public class KundeController : Controller
    {

        private IKundeBLL bll;

        public KundeController()
        {
            bll = new VareBLL();
        }

        public KundeController(IKundeBLL stub)
        {
            bll = stub;
        }
        public ActionResult kundeListe()
        {
            var kundeDb = new VareBLL();
            List<Kunde> alleKunder = kundeDb.hentAlle();
            if (Session["Innlogget"] == null)
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
            }
            else
           {
                ViewBag.Innlogget = (bool)Session["Innlogget"];
                bool ok = (bool)Session["Innlogget"];
                if (ok) return View(alleKunder);
            }
            return RedirectToAction("Home");
        }

        public ActionResult kundeDetaljer(int id = 0)
        {
            var kundeDb = new VareBLL();
            Kunde enKunde = kundeDb.hentEnKunde(id);
            if (Session["Innlogget"] == null)
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["Innlogget"];
                bool ok = (bool)Session["Innlogget"];
                if (ok) return View(enKunde);
            }
            return RedirectToAction("Home");
        }

        public ActionResult Registrer()
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
        public ActionResult Registrer(Kunde innKunde)
        {
            if (ModelState.IsValid)
            {
                var kundeDb = new VareBLL();
                bool insertOK = kundeDb.leggTilKunde(innKunde);
                if (insertOK)
                {
                    return RedirectToAction("kundeListe");
                }
            }
            return View();
        }

        public ActionResult Endre(int id)
        {
            var kundeDb = new VareBLL();
            Kunde enKunde = kundeDb.hentEnKunde(id);
            if (Session["Innlogget"] == null)
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["Innlogget"];
                bool ok = (bool)Session["Innlogget"];
                if (ok) return View(enKunde);
            }
            return RedirectToAction("Home");
        }

        [HttpPost]
        public ActionResult Endre(int id, Kunde endreKunde)
        {
            if (ModelState.IsValid)
            {
                var kundeDb = new VareBLL();
                bool endringOK = kundeDb.endreKunde(id, endreKunde);
                if (endringOK)
                {
                    return RedirectToAction("kundeListe");
                }
            }
            return View();
        }

        public ActionResult slettKunde(int id)
        {
            var kundeDb = new VareBLL();
            Kunde enKunde = kundeDb.hentEnKunde(id);
            if (Session["Innlogget"] == null)
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["Innlogget"];
                bool ok = (bool)Session["Innlogget"];
                if (ok) return View(enKunde);
            }
            return RedirectToAction("Home");
        }

        [HttpPost]
        public ActionResult slettKunde(int id, Kunde slettKunde)
        {
            var kundeDb = new VareBLL();
            bool slettOK = kundeDb.slettKunde(id);
            if (slettOK)
            {
                return RedirectToAction("kundeListe");
            }
           
            return View();
        }

        //View for Hjemmeside
        

       
    
    }
}

