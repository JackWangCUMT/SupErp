﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupErp.DAL.FacturationDAL;
using SupErp.Entities;

namespace SupErp.BLL.FacturationBLL
{
    public class BillQuotationBLL
    {
        private static BillQuotationDAL billQuotationDAL { get; set; }

        #region Read

        public IEnumerable<BILL_BillQuotation> GetBillQuotation()
        {
            return billQuotationDAL.GetBillQuotation();
        }

        public BILL_BillQuotation GetBillByNum(string numBill)
        {
            return billQuotationDAL.GetBillByNum(numBill);
        }

        public IEnumerable<BILL_BillQuotation> GetBills()
        {
            return billQuotationDAL.GetBills();
        }

        public IEnumerable<BILL_BillQuotation> GetQuotations()
        {
            return billQuotationDAL.GetQuotations();
        }
        
        public BILL_BillQuotation GetBillQuotation(DateTime dateBillQuotation)
        {
            return billQuotationDAL.GetBillQuotation(dateBillQuotation);
        }

        #endregion

        #region Create

        public BILL_BillQuotation CreateBillQutotation(BILL_BillQuotation billQuotationToAdd)
        {
            return billQuotationDAL.CreateBillQutotation(billQuotationToAdd);
        }

        #endregion

        #region Edit

        public BILL_BillQuotation EditBillQuotation(BILL_BillQuotation billQuotationToEdit)
        {
            return billQuotationDAL.EditBillQuotation(billQuotationToEdit);
        }

        #endregion

        #region Delete

        public bool DeleteBillQuotation(BILL_BillQuotation billQuotationToDelete)
        {
            return billQuotationDAL.DeleteBillQuotation(billQuotationToDelete);
        }

        #endregion

    }
}