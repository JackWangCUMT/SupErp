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
    [KnownType(typeof(Company))]
    
    public partial class COMPTA_SupplierJournalLine
    {
    [DataMember]
        public long id { get; set; }
    [DataMember]
        public Nullable<bool> direction { get; set; }
    [DataMember]
        public Nullable<decimal> amount { get; set; }
    [DataMember]
        public Nullable<System.DateTime> postingDate { get; set; }
    [DataMember]
        public Nullable<long> SupplierAccount_id { get; set; }
    
    [DataMember]
        public virtual Company Company { get; set; }
    }
}
