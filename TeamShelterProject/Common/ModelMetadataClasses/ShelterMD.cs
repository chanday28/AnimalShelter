using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamShelterProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(ShelterMD))]
    public partial class Shelter
    {
    
    }

    public class ShelterMD
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Shelter()
        //{
        //    this.People = new HashSet<Person>();
        //}

        public int id { get; set; }
        [Display(Name = "Shelter name")]
        public string name { get; set; }

        [Display (Name = "street address")]
        public string streetAddress { get; set; }

        public string phone { get; set; }
        public string email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> People { get; set; }
    }

}
