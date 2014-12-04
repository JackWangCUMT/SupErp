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
    
    public partial class User
    {
        public User()
        {
            this.Absences = new HashSet<Absence>();
            this.Primes = new HashSet<Prime>();
            this.Salaries = new HashSet<Salary>();
        }
    
        public long Id { get; set; }
        public string Email { get; set; }
        public string Passwordhash { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Zip_code { get; set; }
        public Nullable<System.DateTime> Date_arrival { get; set; }
        public Nullable<System.DateTime> Date_departure { get; set; }
        public Nullable<long> Role_id { get; set; }
        public Nullable<long> Status_id { get; set; }
    
        public virtual ICollection<Absence> Absences { get; set; }
        public virtual ICollection<Prime> Primes { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
        public virtual Status Status { get; set; }
    }
}
