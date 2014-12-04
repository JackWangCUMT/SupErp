﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using SupErp.Entities;

namespace SupErp.WCF.GestionClientWCF
{
    [ServiceContract]
    interface IServiceGestionClient
    {
        //////////////////////////////
        //  COMPANY
        //////////////////////////////
        [OperationContract]
        bool CreateCompany(Company company);

        [OperationContract]
        Company GetCompany(int idCustomer);

        [OperationContract]
        List<Company> GetListCompany();

        [OperationContract]
        bool EditCompany(Company company);



        //////////////////////////////
        //  COMPANY_CONTACT
        //////////////////////////////
        [OperationContract]
        bool CreateCompany_Contact(Company_Contact contact);

        [OperationContract]
        Company_Contact GetCompany_Contact(int idContact);

        [OperationContract]
        List<Company_Contact> GetListCompany_Contact();

        [OperationContract]
        List<Company_Contact> GetListCompany_ContactById(int idCompany);

        [OperationContract]
        bool EditCompany_Contact(Company_Contact contact);

    }
}