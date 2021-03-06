﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SupErp.WCF.GestionClientWCF;
using SupErp.Entities;

namespace SupErp.Tests
{
    /// <summary>
    /// Description résumée pour ClientTest
    /// </summary>
    [TestClass]
    public class ClientTest
    {
        private ServiceGestionClient clientService;

        public ClientTest()
        {
            //
            // TODO: ajoutez ici la logique du constructeur
            //
        }

        [TestInitialize]
        public void Init()
        {
            clientService = new ServiceGestionClient();
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        //
        // Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        // Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test de la classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilisez ClassCleanup pour exécuter du code une fois que tous les tests d'une classe ont été exécutés
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestCreateCompany()
        {
            Company comp = new Company();
            comp.name = "testCreate";
            comp.siret = "3333";
            comp.city = "Bordeaux";
            comp.address = "lol";
            comp.postalcode = 33300;

            Assert.IsTrue(clientService.CreateCompany(comp) > 0);
        }

        [TestMethod]
        public void TestGetCompany()
        {
            Company comp = new Company();
            comp.name = "testGet";
            comp.siret = "3333";
            comp.city = "Bordeaux";
            comp.address = "lol";
            comp.postalcode = 33300;

            int newCompanyId = clientService.CreateCompany(comp);
            Assert.IsTrue(newCompanyId > 0);
            Company compget = new Company();
            compget = clientService.GetCompany(newCompanyId);

            Assert.AreEqual("testGet", comp.name);
        }

        [TestMethod]
        public void TestGetListCompany()
        {
            List<Company> comp = new List<Company> ();
            comp = clientService.GetListCompany();

            Assert.IsTrue(comp.Count > 1);
        }

        [TestMethod]
        public void TestCreateCompany_Contact()
        {
            Company_Contact cont = new Company_Contact();
            cont.firstname = "pierre";
            cont.lastname = "Geogre";
            cont.gender = 1;
            cont.email = "pierre@geogre.fr";
            cont.phone = "0506";
            cont.company_id = 1;

            Assert.IsTrue(clientService.CreateCompany_Contact(cont) > 0);
        }

        [TestMethod]
        public void TestDeleteCompany_Contact()
        {

            Company_Contact cont = new Company_Contact();
            cont.firstname = "pierre";
            cont.lastname = "Geogre";
            cont.gender = 1;
            cont.email = "pierre@geogre.fr";
            cont.phone = "0506";
            cont.company_id = 1;

            int id =  clientService.CreateCompany_Contact(cont);

            Assert.IsTrue(clientService.DeleteCompany_Contact(id));

            
        }

        [TestMethod]
        public void TestDeleteCompany()
        {

            Company comp = new Company();
            comp.name = "testsupprComp";
            comp.siret = "3333";
            comp.city = "Bordeaux1";
            comp.address = "Saint Louis RPZ";
            comp.postalcode = 33300;
            comp.id = 2;

            int id = clientService.CreateCompany(comp);

            Assert.IsTrue(clientService.DeleteCompany(id));
        }

        [TestMethod]
        public void TestGetCompany_Contact()
        {
            Company_Contact cont = new Company_Contact();
            cont.firstname = "jacques";
            cont.lastname = "Geogre";
            cont.gender = 1;
            cont.email = "jacques@geogre.fr";
            cont.phone = "0506";
            cont.company_id = 2;

            int id = clientService.CreateCompany_Contact(cont);

            Company_Contact contGet;
            contGet = clientService.GetCompany_Contact(id);

            Assert.AreEqual("jacques", contGet.firstname);
            Assert.AreEqual("Geogre", contGet.lastname);
            Assert.AreEqual(1, contGet.gender);
            Assert.AreEqual("jacques@geogre.fr", contGet.email);
            Assert.AreEqual("0506", contGet.phone);
            Assert.AreEqual(2, contGet.company_id);
        }

        [TestMethod]
        public void TestGetListCompany_Contact()
        {
            List<Company_Contact> lcont;
            lcont = clientService.GetListCompany_Contact();

            Assert.IsTrue(lcont.Count > 1);
        }

        [TestMethod]
        public void TestGetListCompany_ContactByCompany()
        {
            List<Company_Contact> lcont;
            lcont = clientService.GetListCompany_ContactById(1);

            Assert.IsTrue(lcont.Count > 0);
        }

         [TestMethod]
        public void testEditCompany_contact ()
        {
            Company_Contact cont = new Company_Contact();
            cont.id = 4;
            cont.firstname = "pierreT";
            cont.lastname = "George";
            cont.gender = 1;
            cont.email = "pierre@geogre.fr";
            cont.phone = "0506";
            cont.company_id = 1;

            Assert.IsTrue(clientService.EditCompany_Contact(cont));


        }
    }
}
