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
    [KnownType(typeof(COMPTA_AccountingEntries_Periodicity))]
    
    public partial class COMPTA_Periodicity
    {
        public COMPTA_Periodicity()
        {
            this.COMPTA_AccountingEntries_Periodicity = new HashSet<COMPTA_AccountingEntries_Periodicity>();
        }
    
    [DataMember]
        public long id { get; set; }
    [DataMember]
        public string Libelle { get; set; }
    
    [DataMember]
        public virtual ICollection<COMPTA_AccountingEntries_Periodicity> COMPTA_AccountingEntries_Periodicity { get; set; }
    }
}
