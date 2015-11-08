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
    public class VareControllerTest
    {
        [TestMethod]
        public void VareListe()
        {
            var controller = new VareController(new VareBLL(new VareDALStub()));
            var forventetResultat = new List<Vare>();
            var vare = new Vare()
            {
                ID = 1,
                Varenavn = "eple",
                Pris = 5,
                Varebeholdning = 77
            };
            forventetResultat.Add(vare);
            forventetResultat.Add(vare);
            forventetResultat.Add(vare);

            // Act
            var actionResult = (ViewResult)controller.VareListe();
            var resultat = (List<Vare>)actionResult.Model;
            // Assert

            Assert.AreEqual(actionResult.ViewName, "");

            for (var i = 0; i < resultat.Count; i++)
            {
                Assert.AreEqual(forventetResultat[i].ID, resultat[i].ID);
                Assert.AreEqual(forventetResultat[i].Varenavn, resultat[i].Varenavn);
                Assert.AreEqual(forventetResultat[i].Pris, resultat[i].Pris);
                Assert.AreEqual(forventetResultat[i].Varebeholdning, resultat[i].Varebeholdning);
            }
        }

        [TestMethod]
        public void Registrer()
        {
            var controller = new VareController(new VareBLL(new VareDALStub()));

            //var actionResult = (ViewResult)controller.RegistrerVare();

            //Assert.AreEqual(actionResult.ViewName, "");
        }

        [TestMethod]
        public void Registrer_OK()
        {
            var controller = new VareController(new VareBLL(new VareDALStub()));
            var forventetResultat = new List<Vare>();
            var vare = new Vare()
            {
                ID = 1,
                Varenavn = "eple",
                Pris = 5,
                Varebeholdning = 77
            };
            forventetResultat.Add(vare);
            forventetResultat.Add(vare);
            forventetResultat.Add(vare);

            // Act
            var actionResult = (ViewResult)controller.VareListe();

            // Assert
            Assert.AreEqual(result.RouteName, "");
            Assert.AreEqual(result.RouteValues.Values.First(), "VareListe");
        }

        [TestMethod]
        public void Registrer_feil_modell()
        {
            var controller = new VareController(new VareBLL(new VareDALStub()));
            var ForventetVare = new Vare();
            controller.ViewData.ModelState.AddModelError("Varenavn", "Ikke oppgitt varenavn");

            // Act
            var actionResult = (ViewResult)controller.RegistrerVare(ForventetVare);

            // Assert
            Assert.IsTrue(actionResult.ViewData.ModelState.Count == 1);
            Assert.AreEqual(actionResult.ViewName, "");
        }

        [TestMethod]
        public void Registrer_feil_db()
        {
            var controller = new VareController(new VareBLL(new VareDALStub()));

            var forventetVare = new Vare();
            forventetVare.Varenavn = "";

            // Act
            var actionResult = (ViewResult)controller.RegistrerVare(forventetVare);

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");
        }

        [TestMethod]
        public void VareDetaljer()
        {
            var controller = new VareController(new VareBLL(new VareDALStub()));
            var forventetResultat = new Vare()
            {
                ID = 1,
                Varenavn = "eple",
                Pris = 5,
                Varebeholdning = 77
            };
            // Act
            var actionResult = (ViewResult)controller.VareDetaljer(1);
            var resultat = (Vare)actionResult.Model;

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");
            Assert.AreEqual(forventetResultat.ID, resultat.ID);
            Assert.AreEqual(forventetResultat.Varenavn, resultat.Varenavn);
            Assert.AreEqual(forventetResultat.Pris, resultat.Pris);
            Assert.AreEqual(forventetResultat.Varebeholdning, resultat.Varebeholdning);
        }

        [TestMethod]
        public void slettVare()
        {
            var controller = new VareController(new VareBLL(new VareDALStub()));

            // Act
            var actionResult = (ViewResult)controller.slettVare(1);
            var resultat = (Kunde)actionResult.Model;

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");
        }

        [TestMethod]
        public void slettVare_funnet()
        {
            // Arrange
            var controller = new VareController(new VareBLL(new VareDALStub()));

            var innVare = new Vare()
            {
                ID = 1,
                Varenavn = "eple",
                Pris = 5,
                Varebeholdning = 77
            };

            // Act
            var actionResult = (RedirectToRouteResult)controller.slettVare(1, innVare);

            // Assert
            Assert.AreEqual(actionResult.RouteName, "");
            Assert.AreEqual(actionResult.RouteValues.Values.First(), "VareListe");
        }

        [TestMethod]
        public void Slett_ikke_funnet_Post()
        {
            // Arrange
            var controller = new VareController(new VareBLL(new VareDALStub()));
            var innVare = new Vare()
            {
                ID = 1,
                Varenavn = "eple",
                Pris = 5,
                Varebeholdning = 77
            };

            // Act
            var actionResult = (ViewResult)controller.slettVare(0, innVare);

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");
        }

        [TestMethod]
        public void EndreVare()
        {
            // Arrange
            var controller = new VareController(new VareBLL(new VareDALStub()));

            // Act
            var actionResult = (ViewResult)controller.EndreVare(1);

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");
        }
        [TestMethod]
        public void Endre_Ikke_Funnet_Ved_View()
        {
            // Arrange
            var controller = new VareController(new VareBLL(new VareDALStub()));

            // Act
            var actionResult = (ViewResult)controller.EndreVare(0);
            var kundeResultat = (Vare)actionResult.Model;

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");
            Assert.AreEqual(kundeResultat.ID, 0);
        }
        [TestMethod]
        public void Endre_ikke_funnet_Post()
        {
            // Arrange
            var controller = new VareController(new VareBLL(new VareDALStub()));
            var innKunde = new Vare()
            {
                ID = 1,
                Varenavn = "eple",
                Pris = 5,
                Varebeholdning = 77
            };

            // Act
            var actionResult = (ViewResult)controller.endreVare(0, innKunde);

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");
        }
        [TestMethod]
        public void Endre_feil_validering_Post()
        {
            // Arrange
            var controller = new VareController(new VareBLL(new VareDALStub()));
            var innVare = new Vare();
            controller.ViewData.ModelState.AddModelError("feil", "ID = 0");

            // Act
            var actionResult = (ViewResult)controller.endreVare(0, innVare);

            // Assert
            Assert.IsTrue(actionResult.ViewData.ModelState.Count == 1);
            Assert.AreEqual(actionResult.ViewData.ModelState["feil"].Errors[0].ErrorMessage, "ID = 0");
            Assert.AreEqual(actionResult.ViewName, "");
        }
        [TestMethod]
        public void Endre_funnet()
        {
            // Arrange
            var controller = new VareController(new VareBLL(new VareDALStub()));
            var innVare = new Vare()
            {
                Varenavn = "eple",
                Pris = 5,
                Varebeholdning = 77
            };
            // Act
            var actionResultat = (RedirectToRouteResult)controller.endreVare(1, innVare);

            // Assert
            Assert.AreEqual(actionResultat.RouteName, "");
            Assert.AreEqual(actionResultat.RouteValues.Values.First(), "VareListe");
        }
    }
}
