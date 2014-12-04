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
    [KnownType(typeof(Absence))]
    [KnownType(typeof(Prime))]
    [KnownType(typeof(Role))]
    [KnownType(typeof(Salary))]
    [KnownType(typeof(Status))]
    
    public partial class User
    {
        public User()
        {
            this.Absences = new HashSet<Absence>();
            this.Primes = new HashSet<Prime>();
            this.Salaries = new HashSet<Salary>();
        }
    
    [DataMember]
        public long Id { get; set; }
    [DataMember]
        public string Email { get; set; }
    [DataMember]
        public string Passwordhash { get; set; }
    [DataMember]
        public string Firstname { get; set; }
    [DataMember]
        public string Lastname { get; set; }
    [DataMember]
        public string City { get; set; }
    [DataMember]
        public string Address { get; set; }
    [DataMember]
        public string Zip_code { get; set; }
    [DataMember]
        public Nullable<System.DateTime> Date_arrival { get; set; }
    [DataMember]
        public Nullable<System.DateTime> Date_departure { get; set; }
    [DataMember]
        public Nullable<long> Role_id { get; set; }
    [DataMember]
        public Nullable<long> Status_id { get; set; }
    
    [DataMember]
        public virtual ICollection<Absence> Absences { get; set; }
    [DataMember]
        public virtual ICollection<Prime> Primes { get; set; }
    [DataMember]
        public virtual Role Role { get; set; }
    [DataMember]
        public virtual ICollection<Salary> Salaries { get; set; }
    [DataMember]
        public virtual Status Status { get; set; }
    }
}