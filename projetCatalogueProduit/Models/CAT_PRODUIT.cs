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
    
    public partial class CAT_PRODUIT
    {
        public int CODE_PRODUIT { get; set; }
        public Nullable<int> CODE_CATEGORIE { get; set; }
        public string LIBELLE_PRODUIT { get; set; }
        public string DESCRIPTION_PRODUIT { get; set; }
        public string IMAGE_PRODUIT { get; set; }
        public string URL_IMAGE_PRODUIT { get; set; }
        public Nullable<System.DateTime> DATE_SAISIE { get; set; }
    
        public virtual CAT_CATEGORIE CAT_CATEGORIE { get; set; }
    }
}
