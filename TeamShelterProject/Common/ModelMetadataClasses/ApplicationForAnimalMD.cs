using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamShelterProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(ApplicationForAnimalMD))]
    public partial class ApplicationForAnimal
    {

    }

    public class ApplicationForAnimalMD
    {


        [Display(Name = "Applcantion Id")]
        public int id { get; set; }

        [Display(Name = "Animal id")]
        public int animalId { get; set; }
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string surname { get; set; }
        [Display(Name = "Street Address")]
        public string streetAddress { get; set; }
        [Display(Name = "City")]
        public string city { get; set; }
        [Display(Name = "Zipcode")]
        public int zipcode { get; set; }
        [Display(Name = "Contact Phone Number")]
        public string phone { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Does anyone of you family members have allergies?")]
        public string allergies { get; set; }
        [Display(Name = "Family situation")]
        public string familySituation { get; set; }
        [Display(Name = "How many children do you have?")]
        public Nullable<int> numberOfKids { get; set; }
        [Display(Name = "What is the age of your youngest child?")]
        public Nullable<int> youngestKidAge { get; set; }
        [Display(Name = "Housing Type")]
        public string housingType { get; set; }
        [Display(Name = "Do you have any other animals?")]
        public string otherAnimals { get; set; }
        [Display(Name = "Specify which ones and write briefly about them")]
        public string animalComment { get; set; }
        [Display(Name = "Tell us about your experience with animals")]
        public string experience { get; set; }
        [Display(Name = "What are the reasons you decided to adopt the animal?")]
        public string reasonsToAdopt { get; set; }
        [Display(Name = "How much time the animal is going to spend alone at home?")]
        public string timeAlone { get; set; }
        [Display(Name = "Who is going to take care for the animal while you are away for a longer period of time? (eg on vacation)")]
        public string tripOptions { get; set; }
        [Display(Name = "Do you have a possibility to take the animal to a vet when and if needed?")]
        public string possibilityForVet { get; set; }
        [Display(Name = "Where have you found out about us?")]
        public string infoSource { get; set; }
        [Display(Name = "You can add any free comment here:")]
        public string freeComment { get; set; }
        [Display(Name = "Animal Id")]
        public virtual Animal Animal { get; set; }
        [Display(Name = "Applcant Id")]
        public virtual Person Person { get; set; }
    }
}

