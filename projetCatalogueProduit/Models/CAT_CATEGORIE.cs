//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projetCatalogueProduit.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CAT_CATEGORIE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAT_CATEGORIE()
        {
            this.CAT_PRODUIT = new HashSet<CAT_PRODUIT>();
        }
    
        public int CODE_CATEGORIE { get; set; }
        public string LIBELLE_CATEGORIE { get; set; }
        public Nullable<System.DateTime> DATE_SAISIE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAT_PRODUIT> CAT_PRODUIT { get; set; }
    }
}
