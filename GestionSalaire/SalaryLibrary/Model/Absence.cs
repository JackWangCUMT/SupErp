//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalaryLibrary.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Absence
    {
        public long id { get; set; }
        public Nullable<long> User_id { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<long> AbsenceType_id { get; set; }
    
        public virtual AbsenceType AbsenceType { get; set; }
        public virtual User User { get; set; }
    }
}
