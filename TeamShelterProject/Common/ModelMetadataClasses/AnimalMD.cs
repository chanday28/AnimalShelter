using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamShelterProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof (AnimalMD))]
    public partial class Animal
    {

    }
    public class AnimalMD
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public AnimalMD()
        //{
        //    this.ApplicationForAnimals = new HashSet<ApplicationForAnimal>();
        //}

        public int id { get; set; }

        [Display(Name = "Assign a worker: ")]
        public int workerId { get; set; }

        // Should be species?? This works for though.
        [Display(Name="Animal Type:")]
        public string animalType { get; set; }

        [Display(Name = "Animal Name:")]
        public string name { get; set; }

        
        [Display(Name = "Breed:")]
        public string breed { get; set; }

        [Display(Name = "Gender:")]
        public string gender { get; set; }

        [Display(Name = "Birth date:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime birthDate { get; set; }

        [Display(Name = "Height:")]
        public Nullable<decimal> height { get; set; }

        [Display(Name = "Weight:")]
        public Nullable<decimal> animalWeight { get; set; }

        [Display(Name = "Vaccination Date:")]
        public Nullable<System.DateTime> vacinationDate { get; set; }

        [Display(Name = "De-worming Date:")]
        public Nullable<System.DateTime> dewormingDate { get; set; }

        [Display(Name = "Micro-chipped?")]
        public bool hasMicrochip { get; set; }

        [Display(Name = "Ready for Adoption?")]
        public bool readyForAdoption { get; set; }

        [Display(Name = "Comments:")]
        public string comments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationForAnimal> ApplicationForAnimals { get; set; }
        public virtual Person Person { get; set; }
    }



}