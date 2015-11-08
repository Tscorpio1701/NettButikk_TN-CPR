using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NettButikk_Oppg2.Model;
using NettButikk_Oppg2.DAL;
using NettButikk_Oppg2.BLL;
using NettButikk_Oppg2.Controllers;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

namespace EnhetsTest
{
    [TestClass]
    public class BestillingControllerTest
    {
        [TestMethod]
        public void Liste()
        {
            var controller = new BestillingController(new BestillingBLL(new BestillingDALStub()));
            /*var forventetResultat = new List<Bestilling>();
            var bestilling = new Bestilling()
            {
                BestillingID = 1,
                Total = 23,
                OrdreDato = DateTime.Now,
                Vare = new Vare() { Varenavn = "Eple", Pris = 12, Varebeholdning = 77 }
            };
            forventetResultat.Add(bestilling);
            forventetResultat.Add(bestilling);
            forventetResultat.Add(bestilling);

            // Act
            var actionResult = (ViewResult)controller.BestillingListe();
            var resultat = (List<Bestilling>)actionResult.Model;
            // Assert

            Assert.AreEqual(actionResult.ViewName, "");

            for (var i = 0; i < resultat.Count; i++)
            {
                Assert.AreEqual(forventetResultat[i].BestillingID, resultat[i].BestillingID);
                Assert.AreEqual(forventetResultat[i].Total, resultat[i].Total);
                Assert.AreEqual(forventetResultat[i].OrdreDato, resultat[i].OrdreDato);
                Assert.AreEqual(forventetResultat[i].Vare, resultat[i].Vare);

            }*/
        }

        [TestMethod]
        public void RegistrerBestilling()
        {
            var controller = new BestillingController(new BestillingBLL(new BestillingDALStub()));
            /*Bestilling bes = new Bestilling() { BestillingID = 1 };

            var actionResult = (ViewResult)controller.RegistrerBestilling(1);

            Assert.AreEqual(actionResult.ViewName, "");*/
        }

        [TestMethod]
        public void Registrer_OK()
        {
            var controller = new BestillingController(new BestillingBLL(new BestillingDALStub()));

            /*var forventetBestilling = new Bestilling()
            {
                BestillingID = 1,
                Total = 23,
                OrdreDato = DateTime.Now,
                Vare = new Vare() { Varenavn = "Eple", Pris = 12, Varebeholdning = 77 }
            };
            // Act
            var result = (RedirectToRouteResult)controller.RegistrerBestilling(forventetBestilling);

            // Assert
            Assert.AreEqual(result.RouteName, "");
            Assert.AreEqual(result.RouteValues.Values.First(), "BestillingListe");*/
        }

        [TestMethod]
        public void Registrer_feil_modell()
        {
            var controller = new BestillingController(new BestillingBLL(new BestillingDALStub()));
            var forventetBestilling = new Bestilling();
            /*controller.ViewData.ModelState.AddModelError("Total", "Ikke oppgitt total");

            // Act
            var actionResult = (ViewResult)controller.RegistrerBestilling(forventetBestilling);

            // Assert
            Assert.IsTrue(actionResult.ViewData.ModelState.Count == 1);
            Assert.AreEqual(actionResult.ViewName, "");*/
        }

        [TestMethod]
        public void Registrer_feil_db()
        {
            var controller = new BestillingController(new BestillingBLL(new BestillingDALStub()));
            var forventetBestilling = new Bestilling();
            /*forventetBestilling.Vare.Varenavn = "";

            // Act
            var actionResult = (ViewResult)controller.RegistrerBestilling(forventetBestilling);

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");*/
        }

        [TestMethod]
        public void BestillingDetaljer()
        {
            var controller = new BestillingController(new BestillingBLL(new BestillingDALStub()));
            /*var forventetResultat = new Bestilling()
            {
                BestillingID = 1,
                Total = 23,
                OrdreDato = DateTime.Now,
                Vare = new Vare() { Varenavn = "Eple", Pris = 12, Varebeholdning = 77 }
            };
            // Act
            var actionResult = (ViewResult)controller.BestillingDetaljer(1);
            var resultat = (Bestilling)actionResult.Model;

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");
            Assert.AreEqual(forventetResultat.BestillingID, resultat.BestillingID);
            Assert.AreEqual(forventetResultat.OrdreDato, resultat.OrdreDato);
            Assert.AreEqual(forventetResultat.Total, resultat.Total);
            Assert.AreEqual(forventetResultat.Vare, resultat.Vare);*/
        }

        [TestMethod]
        public void slettBestilling()
        {
            var controller = new BestillingController(new BestillingBLL(new BestillingDALStub()));

            // Act
            /*var actionResult = (ViewResult)controller.slettBestilling(1);
            var resultat = (Bestilling)actionResult.Model;

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");*/
        }

        [TestMethod]
        public void slettBestilling_funnet()
        {
            // Arrange
            var controller = new BestillingController(new BestillingBLL(new BestillingDALStub()));
            /*var innBestilling = new Bestilling()
            {
                BestillingID = 1,
                Total = 23,
                OrdreDato = DateTime.Now,
                Vare = new Vare() { Varenavn = "Eple", Pris = 12, Varebeholdning = 77 }
            };

            // Act
            var actionResult = (RedirectToRouteResult)controller.slettBestilling(1, innBestilling);

            // Assert
            Assert.AreEqual(actionResult.RouteName, "");
            Assert.AreEqual(actionResult.RouteValues.Values.First(), "BestillingListe");*/
        }

        [TestMethod]
        public void Slett_ikke_funnet_Post()
        {
            // Arrange
            var controller = new BestillingController(new BestillingBLL(new BestillingDALStub()));
            /*var innBestilling = new Bestilling()
            {
                BestillingID = 1,
                Total = 23,
                OrdreDato = DateTime.Now,
                Vare = new Vare() { Varenavn = "Eple", Pris = 12, Varebeholdning = 77 }
            };

            // Act
            var actionResult = (ViewResult)controller.slettBestilling(0, innBestilling);

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");*/
        }

        [TestMethod]
        public void endreBestilling()
        {
            // Arrange
            var controller = new BestillingController(new BestillingBLL(new BestillingDALStub()));

            // Act
            //var actionResult = (ViewResult)controller.endreBestilling(1);

            // Assert
            //Assert.AreEqual(actionResult.ViewName, "");
        }
        [TestMethod]
        public void Endre_Ikke_Funnet_Ved_View()
        {
            // Arrange
            var controller = new BestillingController(new BestillingBLL(new BestillingDALStub()));

            // Act
            /*var actionResult = (ViewResult)controller.endreBestilling(0);
            var bestillingResultat = (Kunde)actionResult.Model;

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");
            Assert.AreEqual(bestillingResultat.ID, 0);*/
        }
        [TestMethod]
        public void Endre_ikke_funnet_Post()
        {
            // Arrange
            var controller = new BestillingController(new BestillingBLL(new BestillingDALStub()));
            /*var innBestilling = new Bestilling()
            {
                BestillingID = 1,
                Total = 23,
                OrdreDato = DateTime.Now,
                Vare = new Vare() { Varenavn = "Eple", Pris = 12, Varebeholdning = 77 }
            };

            // Act
            var actionResult = (ViewResult)controller.endreBestilling(0, innBestilling);

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");*/
        }
        [TestMethod]
        public void Endre_feil_validering_Post()
        {
            // Arrange
            /*var controller = new BestillingController(new BestillingBLL(new BestillingDALStub()));
            var innBestilling = new Bestilling();
            controller.ViewData.ModelState.AddModelError("feil", "ID = 0");

            // Act
            var actionResult = (ViewResult)controller.endreBestilling(0, innBestilling);

            // Assert
            Assert.IsTrue(actionResult.ViewData.ModelState.Count == 1);
            Assert.AreEqual(actionResult.ViewData.ModelState["feil"].Errors[0].ErrorMessage, "ID = 0");
            Assert.AreEqual(actionResult.ViewName, "");*/
        }
        [TestMethod]
        public void Endre_funnet()
        {
            // Arrange
            var controller = new BestillingController(new BestillingBLL(new BestillingDALStub()));
            /*var innBestilling = new Bestilling()
            {
                BestillingID = 1,
                Total = 23,
                OrdreDato = DateTime.Now,
                Vare = new Vare() { Varenavn = "Eple", Pris = 12, Varebeholdning = 77 }
            };
            // Act
            var actionResultat = (RedirectToRouteResult)controller.endreBestilling(1, innBestilling);

            // Assert
            Assert.AreEqual(actionResultat.RouteName, "");
            Assert.AreEqual(actionResultat.RouteValues.Values.First(), "BestillingListe");*/
        }
    }
}
