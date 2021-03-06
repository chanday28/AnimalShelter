//------------------------------------------------------------------------------
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
    
    public partial class ApplicationForAnimal
    {
        public int id { get; set; }
        public int animalId { get; set; }
        public int workerId { get; set; }
        public string firstName { get; set; }
        public string surname { get; set; }
        public string streetAddress { get; set; }
        public string city { get; set; }
        public int zipcode { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string allergies { get; set; }
        public string familySituation { get; set; }
        public Nullable<int> numberOfKids { get; set; }
        public Nullable<int> youngestKidAge { get; set; }
        public string housingType { get; set; }
        public string otherAnimals { get; set; }
        public string animalComment { get; set; }
        public string experience { get; set; }
        public string reasonsToAdopt { get; set; }
        public string timeAlone { get; set; }
        public string tripOptions { get; set; }
        public string possibilityForVet { get; set; }
        public string infoSource { get; set; }
        public string freeComment { get; set; }
        public string owner { get; set; }
    
        public virtual Animal Animal { get; set; }
        public virtual Person Person { get; set; }
    }
}
