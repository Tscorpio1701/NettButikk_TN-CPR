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
using System.Collections.Generic;

namespace NettButikk_Oppg2.Controllers
{
    public class BestillingController : Controller
    {
        private BestillingBLL bestillingBLL;

        public BestillingController(BestillingBLL bestillingBLL)
        {
            this.bestillingBLL = bestillingBLL;
        }

        // GET: Bestilling
        public ActionResult BestillingListe()
        {
            var bestillingDb = new BestillingDAL();
            List<Bestilling> alleBestillinger = bestillingDb.hentAlleBestillinger();
            if (Session["Innlogget"] == null)
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["Innlogget"];
                bool ok = (bool)Session["Innlogget"];
                if (ok) return View(alleBestillinger);
            }
            return RedirectToAction("Home");
        }

        public ActionResult BestillingDetaljer(int id)
        {
            var bestillingDb = new BestillingDAL();
            Bestilling enBestilling = bestillingDb.hentEnBestilling(id);
            if (Session["Innlogget"] == null)
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["Innlogget"];
                bool ok = (bool)Session["Innlogget"];
                if (ok) return View(enBestilling);
            }
            return RedirectToAction("Home");
        }

        public ActionResult RegistrerBestilling(int id)
        {
            if(ModelState.IsValid)
            {
                BestillingDAL bestilling = new BestillingDAL();
                bool ok = bestilling.leggTilBestilling(id);
                if (ok) RedirectToAction("BestillingListe");

            }
            return RedirectToAction("BestillingListe");
        }

        [HttpPost]

        public ActionResult endreBestilling(int id)
        {
            var bestillingDb = new BestillingDAL();
            Bestilling enBestilling = bestillingDb.hentEnBestilling(id);
            if (Session["Innlogget"] == null)
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["Innlogget"];
                bool ok = (bool)Session["Innlogget"];
                if (ok) return View(enBestilling);
            }
            return RedirectToAction("Home");
        }

        [HttpPost]
        public ActionResult endreBestilling(int id, Bestilling endreBestilling)
        {
            if(ModelState.IsValid)
            {
                var bestilling = new BestillingDAL();
                bool endringOk = bestilling.endreBestilling(id, endreBestilling);
                if(endringOk)
                {
                    return RedirectToAction("BestillingListe");
                }
            }
            return View();
        }

        public ActionResult slettBestilling(int id)
        {
            var bestillingDb = new BestillingDAL();
            Bestilling enBestilling = bestillingDb.hentEnBestilling(id);
            if (Session["Innlogget"] == null)
            {
                Session["Innlogget"] = false;
                ViewBag.Innlogget = false;
            }
            else
            {
                ViewBag.Innlogget = (bool)Session["Innlogget"];
                bool ok = (bool)Session["Innlogget"];
                if (ok) return View(enBestilling);
            }
            return RedirectToAction("Home");
        }

        [HttpPost]
        public ActionResult slettBestilling(int id, Bestilling slettBestilling)
        {
            var bestillingDb = new BestillingDAL();
            bool slettOk = bestillingDb.slettBestilling(id);
            if(slettOk)
            {
                return RedirectToAction("BestillingListe");
            }
            return View();
        }
    }
}