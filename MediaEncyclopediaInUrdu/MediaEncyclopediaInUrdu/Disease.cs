//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediaEncyclopediaInUrdu
{
    using System;
    using System.Collections.Generic;
    
    public partial class Disease
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Disease()
        {
            this.Treatments = new HashSet<Treatment>();
            this.Categories = new HashSet<Category>();
            this.Symptoms = new HashSet<Symptom>();
        }
    
        public int DiseaseID { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public int SymptomID { get; set; }
    
        public virtual Symptom Symptom { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Treatment> Treatments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category> Categories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Symptom> Symptoms { get; set; }
    }
}
