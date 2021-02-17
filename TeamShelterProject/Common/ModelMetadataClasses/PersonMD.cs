﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeamShelterProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     
    [MetadataType(typeof(PersonMD))]
    public partial class Person
    {
        
    }
    public partial class PersonMD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        [ScaffoldColumn(false)]
        public int id { get; set; }

        [Display(Name = "First name")]
        public string firstName { get; set; }

        [Display(Name = "Surname")]
        public string surname { get; set; }

        [Display(Name = "street address")]
        public string streetAddress { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        [Display(Name = "role")]
        public int personRole { get; set; }

        [Display(Name = "number of shelter")]
        public int shelterId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Animal> Animals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationForAnimal> ApplicationForAnimals { get; set; }
        public virtual Shelter Shelter { get; set; }
    }    
    
}