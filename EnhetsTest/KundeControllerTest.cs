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
    public class KundeControllerTest
    {
        [TestMethod]
        public void Liste()
        {
            var controller = new KundeController(new VareBLL(new KundeDALStub()));
            var forventetResultat = new List<Kunde>();
            /*var kunde = new Kunde()
            {
                ID = 1,
                Fornavn = "Per",
                Etternavn = "Olsen",
                Adresse = "Osloveien 82"
            };
            forventetResultat.Add(kunde);
            forventetResultat.Add(kunde);
            forventetResultat.Add(kunde);

            // Act
            var actionResult = (ViewResult)controller.kundeListe();
            var resultat = (List<Kunde>)actionResult.Model;
            // Assert

            Assert.AreEqual(actionResult.ViewName, "");

            for (var i = 0; i < resultat.Count; i++)
            {
                Assert.AreEqual(forventetResultat[i].ID, resultat[i].ID);
                Assert.AreEqual(forventetResultat[i].Fornavn, resultat[i].Fornavn);
                Assert.AreEqual(forventetResultat[i].Etternavn, resultat[i].Etternavn);
                Assert.AreEqual(forventetResultat[i].Adresse, resultat[i].Adresse);
            }*/
        }

        [TestMethod]
        public void Registrer()
        {
            var controller = new KundeController(new VareBLL(new KundeDALStub()));

            //var actionResult = (ViewResult)controller.Registrer();

            //Assert.AreEqual(actionResult.ViewName, "");
        }

        [TestMethod]
        public void Registrer_OK()
        {
            var controller = new KundeController(new VareBLL(new KundeDALStub()));

            /*var forventetKunde = new Kunde()
            {
                Fornavn = "Per",
                Etternavn = "Olsen",
                Adresse = "Osloveien 82"
            };
            // Act
            var result = (RedirectToRouteResult)controller.Registrer(forventetKunde);

            // Assert
            Assert.AreEqual(result.RouteName, "");
            Assert.AreEqual(result.RouteValues.Values.First(), "kundeListe");*/
        }

        [TestMethod]
        public void Registrer_feil_modell()
        {
            var controller = new KundeController(new VareBLL(new KundeDALStub()));
            /*var forventetKunde = new Kunde();
            controller.ViewData.ModelState.AddModelError("Fornavn", "Ikke oppgitt fornavn");

            // Act
            var actionResult = (ViewResult)controller.Registrer(forventetKunde);

            // Assert
            Assert.IsTrue(actionResult.ViewData.ModelState.Count == 1);
            Assert.AreEqual(actionResult.ViewName, "");*/
        }

        [TestMethod]
        public void Registrer_feil_db()
        {
            var controller = new KundeController(new VareBLL(new KundeDALStub()));

            /*var forventetKunde = new Kunde();
            forventetKunde.Fornavn = "";

            // Act
            var actionResult = (ViewResult)controller.Registrer(forventetKunde);

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");*/
        }

        [TestMethod]
        public void kundeDetaljer()
        {
            var controller = new KundeController(new VareBLL(new KundeDALStub()));
            /*var forventetResultat = new Kunde()
            {
                ID = 1,
                Fornavn = "Per",
                Etternavn = "Olsen",
                Adresse = "Osloveien 82"
            };
            // Act
            var actionResult = (ViewResult)controller.kundeDetaljer(1);
            var resultat = (Kunde)actionResult.Model;

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");
            Assert.AreEqual(forventetResultat.ID, resultat.ID);
            Assert.AreEqual(forventetResultat.Fornavn, resultat.Fornavn);
            Assert.AreEqual(forventetResultat.Etternavn, resultat.Etternavn);
            Assert.AreEqual(forventetResultat.Adresse, resultat.Adresse);*/
        }

        [TestMethod]
        public void slettKunde()
        {
            var controller = new KundeController(new VareBLL(new KundeDALStub()));

            // Act
            /*var actionResult = (ViewResult)controller.slettKunde(1);
            var resultat = (Kunde)actionResult.Model;

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");*/
        }

        [TestMethod]
        public void slettKunde_funnet()
        {
            // Arrange
            var controller = new KundeController(new VareBLL(new KundeDALStub()));

            /*var innKunde = new Kunde()
            {
                Fornavn = "Per",
                Etternavn = "Olsen",
                Adresse = "Osloveien 82"
            };

            // Act
            var actionResult = (RedirectToRouteResult)controller.slettKunde(1, innKunde);

            // Assert
            Assert.AreEqual(actionResult.RouteName, "");
            Assert.AreEqual(actionResult.RouteValues.Values.First(), "kundeListe");*/
        }

        [TestMethod]
        public void Slett_ikke_funnet_Post()
        {
            // Arrange
            var controller = new KundeController(new VareBLL(new KundeDALStub()));
            /*var innKunde = new Kunde()
            {
                Fornavn = "Per",
                Etternavn = "Olsen",
                Adresse = "Osloveien 82"
            };

            // Act
            var actionResult = (ViewResult)controller.slettKunde(0, innKunde);

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");*/
        }

        [TestMethod]
        public void Endre()
        {
            // Arrange
            var controller = new KundeController(new VareBLL(new KundeDALStub()));

            // Act
            //var actionResult = (ViewResult)controller.Endre(1);

            // Assert
            //Assert.AreEqual(actionResult.ViewName, "");
        }
        [TestMethod]
        public void Endre_Ikke_Funnet_Ved_View()
        {
            // Arrange
            var controller = new KundeController(new VareBLL(new KundeDALStub()));

            // Act
            /*var actionResult = (ViewResult)controller.Endre(0);
            var kundeResultat = (Kunde)actionResult.Model;

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");
            Assert.AreEqual(kundeResultat.ID, 0);*/
        }
        [TestMethod]
        public void Endre_ikke_funnet_Post()
        {
            // Arrange
            var controller = new KundeController(new VareBLL(new KundeDALStub()));
            /*var innKunde = new Kunde()
            {
                ID = 0,
                Fornavn = "Per",
                Etternavn = "Olsen",
                Adresse = "Osloveien 82"
            };

            // Act
            var actionResult = (ViewResult)controller.Endre(0, innKunde);

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");*/
        }
        [TestMethod]
        public void Endre_feil_validering_Post()
        {
            // Arrange
            var controller = new KundeController(new VareBLL(new KundeDALStub()));
            /*var innKunde = new Kunde();
            controller.ViewData.ModelState.AddModelError("feil", "ID = 0");

            // Act
            var actionResult = (ViewResult)controller.Endre(0, innKunde);

            // Assert
            Assert.IsTrue(actionResult.ViewData.ModelState.Count == 1);
            Assert.AreEqual(actionResult.ViewData.ModelState["feil"].Errors[0].ErrorMessage, "ID = 0");
            Assert.AreEqual(actionResult.ViewName, "");*/
        }
        [TestMethod]
        public void Endre_funnet()
        {
            // Arrange
            /*var controller = new KundeController(new KundeBLL(new KundeDALStub()));
            var innKunde = new Kunde()
            {
                Fornavn = "Per",
                Etternavn = "Olsen",
                Adresse = "Osloveien 82"
            };
            // Act
            var actionResultat = (RedirectToRouteResult)controller.Endre(1, innKunde);

            // Assert
            Assert.AreEqual(actionResultat.RouteName, "");
            Assert.AreEqual(actionResultat.RouteValues.Values.First(), "Liste");*/
        }

    }
}
