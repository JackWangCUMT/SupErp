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
    [KnownType(typeof(User))]
    
    public partial class Salary
    {
    [DataMember]
        public long id { get; set; }
    [DataMember]
        public Nullable<long> User_id { get; set; }
    [DataMember]
        public Nullable<decimal> NetSalary { get; set; }
    [DataMember]
        public Nullable<System.DateTime> Date { get; set; }
    
    [DataMember]
        public virtual User User { get; set; }
    }
}