//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SupErp.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class BILL_Product
    {
        public long Product_Id { get; set; }
        public string Name { get; set; }
        public string DescriptionPro { get; set; }
        public double Price { get; set; }
        public Nullable<long> Category_Id { get; set; }
        public Nullable<long> Vat_Id { get; set; }
    
        public virtual BILL_Category BILL_Category { get; set; }
        public virtual BILL_Vat BILL_Vat { get; set; }
    }
}
