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
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    
    [DataContract(IsReference = true)]
    [KnownType(typeof(BILL_Product))]
    
    public partial class BILL_Category
    {
        public BILL_Category()
        {
            this.BILL_Product = new HashSet<BILL_Product>();
        }
    
    [DataMember]
        public long Category_Id { get; set; }
    [DataMember]
        public string Name { get; set; }
    [DataMember]
        public string DescriptionCat { get; set; }
    
    [DataMember]
        public virtual ICollection<BILL_Product> BILL_Product { get; set; }
    }
}
