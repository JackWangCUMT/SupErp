﻿using SupErp.Entities;
using System.Runtime.Serialization;

namespace SupErp.DAL.FacturationModele
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(BILL_Product))]
    public class ProductExtended : BILL_Product
    {
        [DataMember]
        public bool included { get; private set; }

        public ProductExtended(BILL_Product product, long billQuotation_id)
        {
            base.BILL_Category = product.BILL_Category;
            base.BILL_LineBillQuotation = product.BILL_LineBillQuotation;
            base.BILL_Vat = product.BILL_Vat;
            base.Category_Id = product.Category_Id;
            base.DescriptionPro = product.DescriptionPro;
            base.Name = product.Name;
            base.Price = product.Price;
            base.Product_Id = product.Product_Id;
            base.Vat_Id = product.Vat_Id;

            var DAL = new FacturationDAL.LineBillQuotationDAL();
            //var listProduct = DAL.productsIncludedInBill(billQuotation_id);
            included = DAL.productsIncludedInBill(billQuotation_id, Product_Id);
        }
    }
}