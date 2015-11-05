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


namespace NettButikk_Oppg2.Controllers
{
    public class VareController : Controller
    {        
        public ActionResult VareListe()
        {
            var VareDb = new VareBLL();
            List<Vare> hentAlleVarer = VareDb.HentAlleVarer();
            return View(hentAlleVarer);   
        }

        public ActionResult VareDetaljer(int id)
        {
            var VareDb = new VareBLL();
            Vare enVare = VareDb.hentEnVare(id);
            
            return View(enVare);
        }

        public ActionResult RegistrerVare()
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
        public ActionResult RegistrerVare(Vare innVare)
        {
            if(ModelState.IsValid)
            {
                var vare = new VareBLL();
                bool insertOK = vare.leggTilVare(innVare);
                if(insertOK)
                {
                    return RedirectToAction("VareListe");
                    bool ok = (bool)Session["Innlogget"];
                    if (ok) return View();
                }
            }
            return RedirectToAction("Home");
        }

        public ActionResult EndreVare(int id)
        {
            var vareDb = new VareBLL();
            Vare enVare = vareDb.hentEnVare(id);
            if (Session["Innlogget"] == null)
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["Innlogget"];
                bool ok = (bool)Session["Innlogget"];
                if (ok) return View(enVare);
            }
            return RedirectToAction("Home");
        }

        [HttpPost]
        public ActionResult endreVare(int id, Vare endreVare)
        {
            if(ModelState.IsValid)
            {
                var Vare = new VareBLL();
                bool endringOk = Vare.endreVare(id, endreVare);
                if(endringOk)
                {
                    return RedirectToAction("VareListe");
                }
            }
            return View();
        }

        public ActionResult slettVare(int id)
        {
            var vareDb = new VareBLL();
            Vare enVare = vareDb.hentEnVare(id);
            if (Session["Innlogget"] == null)
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["Innlogget"];
                bool ok = (bool)Session["Innlogget"];
                if (ok) return View(enVare);
            }
            return RedirectToAction("Home");
        }

        [HttpPost]
        public ActionResult slettVare(int id, Vare vare)
        {
            var VareDb = new VareBLL();
            bool slettOk = VareDb.slettVare(id);
            if(slettOk)
            {
                return RedirectToAction("VareListe");
            }
            return View();
        }

        


    }
}